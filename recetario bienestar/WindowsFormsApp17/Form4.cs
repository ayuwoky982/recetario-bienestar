using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
   
    public partial class Form4 : Form
    {
        public string usuariorecived;
        public Form4(String usuariorecived1)
        {
            InitializeComponent();
            this.usuariorecived = usuariorecived1;
            label4.Text = usuariorecived;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
            string nombreUsuario = usuariorecived;

            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query1 = "SELECT edad FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command1 = new MySqlCommand(query1, connection))
                {
                    command1.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result1 = command1.ExecuteScalar();
                    if (result1 != null)
                        txtEdad.Text = result1.ToString();
                }

                string query2 = "SELECT usuario FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result2 = command2.ExecuteScalar();
                    if (result2 != null)
                        lblNombreUsuario.Text = result2.ToString();
                }

                string query3 = "SELECT contraseña FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command3 = new MySqlCommand(query3, connection))
                {
                    command3.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result3 = command3.ExecuteScalar();
                    if (result3 != null)
                        txtContraseña.Text = result3.ToString();
                }
                string query4 = "SELECT diabetes FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command4 = new MySqlCommand(query4, connection))
                {
                    command4.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result4 = command4.ExecuteScalar();
                    if (result4 != null)
                        cboTienesDiab.SelectedItem = result4.ToString();
                }
                string query5 = "SELECT tipodiabetes FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command5 = new MySqlCommand(query5, connection))
                {
                    command5.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result5 = command5.ExecuteScalar();
                    if (result5 != null)
                        cboTipoDiab.SelectedItem = result5.ToString();
                }
                string query6 = "SELECT peso FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command1 = new MySqlCommand(query6, connection))
                {
                    command1.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result1 = command1.ExecuteScalar();
                    if (result1 != null)
                        txtPeso.Text = result1.ToString();
                }
            }
            if (cboTienesDiab.Text == "NO")
                cboTipoDiab.Text = null;
        }

        private void label12_Click(object sender, EventArgs e)
        {

            Form5 inicio = new Form5(usuariorecived);
            this.Hide();
            inicio.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = usuariorecived;
        }

        private void lblCalcularIMC_Click(object sender, EventArgs e)
        {
            Form6 cimc = new Form6(usuariorecived);
            this.Hide();    
            cimc.Show();
        }

        private void lblModUsuario_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Enabled == false || txtEdad.Enabled == false || txtPeso.Enabled == false || cboTienesDiab.Enabled == false || cboTipoDiab.Enabled == false)
            {
                txtContraseña.Enabled = true;
                txtEdad.Enabled = true;
                txtPeso.Enabled = true;
                cboTienesDiab.Enabled = true;
                picVerContra.Enabled = true;
                lblGuarCamb.Visible = true;
                lblCancelar.Visible = true;
            }
            if (cboTienesDiab.SelectedItem.ToString() == "SI")
            {
                cboTipoDiab.Enabled = true;
            }
        }

        private void lblGuarCamb_Click(object sender, EventArgs e)
        {
            txtContraseña.Enabled = false;
            txtEdad.Enabled = false;
            txtPeso.Enabled = false;
            cboTienesDiab.Enabled = false;
            cboTipoDiab.Enabled = false;
            lblGuarCamb.Visible = false;
            lblCancelar.Visible = false;
            //picVerContra.Enabled = false;

            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
            string nombreUsuario = usuariorecived;
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE usuarios SET contraseña = @contraseña, edad = @edad, peso = @peso, diabetes = @diabetes, tipodiabetes = @tipodiabetes WHERE usuario = @usuario";
                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {

                    command.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
                    command.Parameters.AddWithValue("@edad", txtEdad.Text);
                    command.Parameters.AddWithValue("@peso", txtPeso.Text);
                    command.Parameters.AddWithValue("@diabetes", cboTienesDiab.SelectedItem?.ToString());
                    command.Parameters.AddWithValue("@tipodiabetes", cboTipoDiab.SelectedItem?.ToString());
                    command.Parameters.AddWithValue("@usuario", nombreUsuario);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cambios guardados correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron cambios.");
                    }
                }
            }
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            txtContraseña.Enabled = false;
            txtEdad.Enabled = false;
            txtPeso.Enabled = false;
            cboTienesDiab.Enabled = false;
            cboTipoDiab.Enabled = false;
            lblGuarCamb.Visible = false;
            lblCancelar.Visible = false;
            //picVerContra.Enabled = false;

            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
            string nombreUsuario = usuariorecived;

            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();

                string query1 = "SELECT edad FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command1 = new MySqlCommand(query1, connection))
                {
                    command1.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result1 = command1.ExecuteScalar();
                    if (result1 != null)
                        txtEdad.Text = result1.ToString();
                }

                string query3 = "SELECT contraseña FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command3 = new MySqlCommand(query3, connection))
                {
                    command3.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result3 = command3.ExecuteScalar();
                    if (result3 != null)
                        txtContraseña.Text = result3.ToString();
                }

                string query6 = "SELECT peso FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command1 = new MySqlCommand(query6, connection))
                {
                    command1.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result1 = command1.ExecuteScalar();
                    if (result1 != null)
                        txtPeso.Text = result1.ToString();
                }
            }
        }

        private void picVerContra_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseña.PasswordChar = '\0';

        }
        private void picVerContra_MouseUp(object sender, MouseEventArgs e)
        {
            txtContraseña.PasswordChar = '*';

        }

        private void cboTienesDiab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Enabled == true || txtEdad.Enabled == true || txtPeso.Enabled == true || cboTienesDiab.Enabled == true || cboTipoDiab.Enabled == true)
            {
                if (cboTienesDiab.SelectedItem.ToString() == "NO")
                {
                    cboTipoDiab.Enabled = false;
                    cboTipoDiab.Text = null;
                }
                else
                {
                    cboTipoDiab.Enabled = true;
                }
            }
        }

        private void lblFavoritos_Click(object sender, EventArgs e)
        {
            fav favoritos = new fav(usuariorecived);
            favoritos.Show();
            this.Hide();
        }
    }
}
