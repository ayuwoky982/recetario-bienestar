using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class fav : Form
    {
        public string usuario;
        public int id_us;

        public fav(string usuariorecived)
        {
            InitializeComponent();

            this.usuario = usuariorecived;

            using (var conn = new MySqlConnection("server=localhost;user id=root;password=;database=recetario_bienestar"))
            {
                conn.Open();
                this.id_us = ObtenerIDUsuario(conn, this.usuario);
            }
        }

        // =====================================
        // OBTIENE ID DEL USUARIO
        // =====================================
        private int ObtenerIDUsuario(MySqlConnection connection, string nombreUsuario)
        {
            string queryUsuario = "SELECT ID FROM usuarios WHERE usuario = @usuario";

            using (MySqlCommand cmd = new MySqlCommand(queryUsuario, connection))
            {
                cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        // =====================================
        // CARGAR TODAS LAS RECETAS FAVORITAS
        // =====================================
        private void fav_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT 
                    r.num AS 'Número de receta',
                    r.desayuno AS 'Desayuno',
                    r.comida AS 'Comida',
                    r.cena AS 'Cena'
                FROM favoritos f
                JOIN recetas r ON f.id_receta = r.num
                WHERE f.id_usuario = @id_us;
                ";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id_us", id_us);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No tienes recetas favoritas.");
                            return;
                        }

                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        // =====================================
        // ELIMINAR FAVORITO
        // =====================================
        private void btnEliminarFav_Click(object sender, EventArgs e)
        {
            int recetasEliminadas = 0;
            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int idReceta = Convert.ToInt32(row.Cells["Número de receta"].Value);

                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM favoritos WHERE id_usuario = @id_us AND id_receta = @id_re";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_us", id_us);
                        cmd.Parameters.AddWithValue("@id_re", idReceta);

                        recetasEliminadas += cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Se eliminaron " + recetasEliminadas + " favoritos.");

            // Refrescar DGV
            fav_Load(null, null);
        }

        // =====================================
        // DESCARGAR LISTA A .TXT
        // =====================================
        private void btnDescargarFav_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
            List<string> lista = new List<string>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT r.desayuno, r.comida, r.cena
                FROM favoritos f
                JOIN recetas r ON r.num = f.id_receta
                WHERE f.id_usuario = @id_us";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_us", id_us);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["desayuno"].ToString() != "") lista.Add(reader["desayuno"].ToString());
                            if (reader["comida"].ToString() != "") lista.Add(reader["comida"].ToString());
                            if (reader["cena"].ToString() != "") lista.Add(reader["cena"].ToString());
                        }
                    }
                }
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, lista);
                MessageBox.Show("Lista guardada correctamente.");
            }
        }

        private void lblRegresar_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5(usuario);
            f.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbConsejos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbRecetas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
