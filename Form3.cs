using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{

    public partial class Form3 : Form
    {
        public string usuariorecived;
        public Form3(string usuario)
        {
            InitializeComponent();
            this.usuariorecived = usuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            this.Hide();
            inicio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
            }
            string usuario = usuario1.Text;
            string contraseña = contraseña1.Text;
            string checkUserQuery = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND contraseña = @contraseña";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(checkUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    if (userCount > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso");
                        Juego_recetario segpag = new Juego_recetario(usuario1.Text);
                        this.Hide();
                        segpag.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
            }
          
        }

        private void usuario1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

            Form1 inicio = new Form1();
            this.Hide();
            inicio.Show();
        }

        private void picVerContra_Click(object sender, EventArgs e)
        {

        }
        private void picVerContra_MouseDown(object sender, MouseEventArgs e)
        {
         contraseña1.PasswordChar = '\0';
        }
        private void picVerContra_MouseUp(object sender, MouseEventArgs e)
        {
            contraseña1.PasswordChar = '*';
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = Color.DarkRed;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.White;
        }

        private void contraseña1_Click(object sender, EventArgs e)
        {
            contraseña1.PasswordChar = '*';
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
                using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    connection.Open();
                }
                string usuario = usuario1.Text;
                string contraseña = contraseña1.Text;
                string checkUserQuery = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND contraseña = @contraseña";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(checkUserQuery, connection))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@contraseña", contraseña);
                        int userCount = Convert.ToInt32(command.ExecuteScalar());
                        if (userCount > 0)
                        {
                            MessageBox.Show("Inicio de sesión exitoso");
                            Juego_recetario segpag = new Juego_recetario(usuario1.Text);
                            this.Hide();
                            segpag.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                        }
                    }
                }
            }
        }
    }
}
