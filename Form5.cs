using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form5 : Form
    {
        public string usuariorecived;

        public Form5(string usuario)
        {
            InitializeComponent();
            this.usuariorecived = usuario;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form4 perfil = new Form4(usuariorecived);
            this.Hide();
            perfil.Show();

        }
        #region Funciónes
        private int ObtenerIDUsuario(MySqlConnection connection, string nombreUsuario)
        {
            int id_usuario = 0;

                string queryUsuario = "SELECT ID FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand cmdUsuario = new MySqlCommand(queryUsuario, connection))
                {
                    cmdUsuario.Parameters.AddWithValue("@usuario", nombreUsuario);
                    id_usuario = Convert.ToInt32(cmdUsuario.ExecuteScalar());
                }
                return id_usuario;
                // ObtenerIDUsuario(connection, usuariorecived);
        }
        private bool VerificarFavoritos(int id_receta, string tipo_comida)
        {
            string checkFav = "SELECT COUNT(*) FROM favoritos WHERE id_usuario=@id_usuario AND id_receta=@id_receta AND tipo_comida=@tipo_comida";
            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                int id_usuario = ObtenerIDUsuario(connection, usuariorecived);

                using (MySqlCommand cmdCheck = new MySqlCommand(checkFav, connection))
                {
                    cmdCheck.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmdCheck.Parameters.AddWithValue("@id_receta", id_receta);
                    cmdCheck.Parameters.AddWithValue("@tipo_comida", tipo_comida);

                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    return count > 0;
                    // VerificarFavoritos(id_receta, tipo);
                }
            }
        }
        #endregion

        #region Animación botón favoritos


        #endregion

        private void rdbRecetas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRecetas.Checked)
            {
                pnlFavRec.Show();
                dataGridView1.Columns.Clear();
            }
            else
                pnlFavRec.Hide();
        }

        private void rdbConsejos_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT num AS 'Número', consejos AS 'Consejos' FROM recycon2";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["Número"].Width = 70;

                    }
                }
            }
        }
        private void timerEstrellaAumentar_Tick(object sender, EventArgs e)
        {
            if (picMenuFav.Width <= 55 && picMenuFav.Height <= 55)
            {
                picMenuFav.Width += 1;
                picMenuFav.Height += 1;
                picMenuFav.Left -= 1 / 2;
                picMenuFav.Top -= 1 / 2;
            }
            else
                timerEstrellaAumentar.Stop();
        }

        private void timerEstrellaDisminuir_Tick(object sender, EventArgs e)
        {
            if (picMenuFav.Width >= 50 && picMenuFav.Height >= 50)
            {
                picMenuFav.Width -= 1;
                picMenuFav.Height -= 1;
                picMenuFav.Left += 1 / 2;
                picMenuFav.Top += 1 / 2;
            }
            else
                timerEstrellaDisminuir.Stop();
        }

        private void pnlFavRec_MouseEnter(object sender, EventArgs e)
        {
            timerEstrellaDisminuir.Stop();
            timerEstrellaAumentar.Start();
        }

        private void pnlFavRec_MouseLeave(object sender, EventArgs e)
        {
            timerEstrellaAumentar.Stop();
            timerEstrellaDisminuir.Start();
        }

        private void pnlFavRec_Click(object sender, EventArgs e)
        {
            /*
          if (grpMenuFav.Visible == false)
              grpMenuFav.Show();
          else
              grpMenuFav.Hide();
          */
        }

        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void cboTipoComida_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboTipoComida.Text == "Desayuno" || cboTipoComida.Text == "Comida" || cboTipoComida.Text == "Cena")
            {
                string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
                using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "";
                    if (cboTipoComida.Text == "Desayuno")
                    {
                        query = "SELECT num AS 'Número de receta', desayuno AS 'Receta' FROM recetas WHERE desayuno IS NOT NULL AND desayuno <> ''";
                    }
                    else if (cboTipoComida.Text == "Comida")
                    {
                        query = "SELECT num AS 'Número de receta', comida AS 'Receta' FROM recetas WHERE comida IS NOT NULL AND comida <> ''";
                    }
                    else if (cboTipoComida.Text == "Cena")
                    {
                        query = "SELECT num AS 'Número de receta', cena AS 'Receta' FROM recetas WHERE cena IS NOT NULL AND cena <> ''";
                    }

                    // DataGridView1 Rellenado
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                            if (!dataGridView1.Columns.Contains("Favorito"))
                            {
                                DataGridViewImageColumn colFav = new DataGridViewImageColumn();
                                colFav.Name = "Favorito";
                                colFav.HeaderText = "★";
                                colFav.Width = 40;
                                colFav.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                                colFav.ImageLayout = DataGridViewImageCellLayout.Zoom;
                                dataGridView1.Columns.Add(colFav);
                            }
                            dataGridView1.RowTemplate.Height = 50;
                            dataGridView1.Columns["Receta"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                            dataGridView1.Columns["Número de receta"].Width = 70;
                            dataGridView1.Columns["Número de receta"].Resizable = DataGridViewTriState.False;
                            dataGridView1.Columns["Favorito"].Width = 50;
                        }

                        int id_usuario = ObtenerIDUsuario(connection, usuariorecived);
                        string tipo = cboTipoComida.Text.ToLower();
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["Número de receta"].Value != null)
                            {
                                int id_receta = Convert.ToInt32(row.Cells["Número de receta"].Value);
                                bool esFavorito = VerificarFavoritos(id_receta, tipo);
                            }
                        }
                    }
                }
            }
            else
            {
                DataTable dt = new DataTable();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            this.Hide();
            inicio.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                int id_usuario = ObtenerIDUsuario(connection, usuariorecived);
                List<string> ListaFavoritos = new List<string>();
                string commandListaFav = "SELECT r.desayuno, r.comida, r.cena FROM favoritos f JOIN recetas r ON f.id_receta = r.num WHERE f.id_usuario = @id_usuario;";
                using (MySqlCommand command = new MySqlCommand(commandListaFav, connection))
                {
                    command.Parameters.AddWithValue("@id_usuario", id_usuario);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!string.IsNullOrEmpty(reader["desayuno"].ToString()))
                                ListaFavoritos.Add(reader["desayuno"].ToString());
                            if (!string.IsNullOrEmpty(reader["comida"].ToString()))
                                ListaFavoritos.Add(reader["comida"].ToString());
                            if (!string.IsNullOrEmpty(reader["cena"].ToString()))
                                ListaFavoritos.Add(reader["cena"].ToString());
                        }
                    }
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter archivo = new StreamWriter(saveFileDialog1.FileName))
                        {
                            foreach (string receta in ListaFavoritos)
                                archivo.WriteLine(receta);
                        }
                        MessageBox.Show("Lista de favoritos guardada");
                    }
                }
            }
        }

        private void btnAgregarFav_Click(object sender, EventArgs e)
        {
            int recetas_agregadas = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
                {
                    using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Definir variables
                        int id_usuario = ObtenerIDUsuario(connection, usuariorecived);
                        int id_receta = Convert.ToInt32(row.Cells["Número de receta"].Value);
                        string tipo_comida = cboTipoComida.Text.ToLower();

                        // Insertar en favoritos
                        if (!VerificarFavoritos(id_receta, tipo_comida))
                        {
                            string insertFav = "INSERT INTO favoritos (id_usuario, id_receta, tipo_comida) VALUES (@id_usuario, @id_receta, @tipo_comida)";
                            using (MySqlCommand cmdInsert = new MySqlCommand(insertFav, connection))
                            {
                                cmdInsert.Parameters.AddWithValue("@id_usuario", id_usuario);
                                cmdInsert.Parameters.AddWithValue("@id_receta", id_receta);
                                cmdInsert.Parameters.AddWithValue("@tipo_comida", tipo_comida);
                                cmdInsert.ExecuteNonQuery();
                                recetas_agregadas++;
                                //row.Cells["Favorito"].Value = Properties.Resources.star_shine;
                            }
                        }
                    }
                }
            }
            if (recetas_agregadas > 0)
                MessageBox.Show("Se agregaron " + recetas_agregadas + " receta(s) a favoritos.");
            else
                MessageBox.Show("No se agregó ninguna receta (ya estaban en favoritos).");
        }

        private void btnEliminarFav_Click(object sender, EventArgs e)
        {
            int recetas_eliminadas = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
                {
                    using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Definir variables
                        int id_usuario = ObtenerIDUsuario(connection, usuariorecived);
                        int id_receta = Convert.ToInt32(row.Cells["Número de receta"].Value);
                        string tipo_comida = cboTipoComida.Text.ToLower();

                        // Eliminar de favoritos
                        if (VerificarFavoritos(id_receta, tipo_comida))
                        {
                            string deleteFav = "DELETE FROM favoritos WHERE id_usuario = @id_usuario AND id_receta = @id_receta AND tipo_comida = @tipo_comida";
                            using (MySqlCommand cmdDelete = new MySqlCommand(deleteFav, connection))
                            {
                                cmdDelete.Parameters.AddWithValue("@id_usuario", id_usuario);
                                cmdDelete.Parameters.AddWithValue("@id_receta", id_receta);
                                cmdDelete.Parameters.AddWithValue("@tipo_comida", tipo_comida);
                                cmdDelete.ExecuteNonQuery();
                                recetas_eliminadas++;
                                //row.Cells["Favorito"].Value = Properties.Resources.star_empty;
                            }
                        }
                    }
                }
            }
            if (recetas_eliminadas > 0)
                MessageBox.Show("Se eliminaron " + recetas_eliminadas + " receta(s) de favoritos.");
            else
                MessageBox.Show("No se elimino ninguna receta (no había recetas en favoritos).");
        }
    }
}

