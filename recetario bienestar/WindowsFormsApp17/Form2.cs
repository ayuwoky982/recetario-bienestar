using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form2 : Form
    {
        public string usuariorecived;

        public Form2(string usuario)
        {
            InitializeComponent();
           this.usuariorecived = usuario;   
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
            if (!String.IsNullOrEmpty(usuario2.Text) && !String.IsNullOrEmpty(contraseña2.Text) && !String.IsNullOrEmpty(Ccontraseña.Text) && !String.IsNullOrEmpty(edad1.Text) && !String.IsNullOrEmpty(diabetes1.Text) && !String.IsNullOrEmpty(peso1.Text))
            {
                string usuario = usuario2.Text;
                Form5 form2 = new Form5(usuario);
                string contraseña = contraseña2.Text;
                int edad = Convert.ToInt32(edad1.Text);
                string diabetes = diabetes1.Text;
                string tpodbts = tipodb.Text;
                int peso = Convert.ToInt32(peso1.Text);
                MySqlCommand mySqlCommand = new MySqlCommand();

                string checkUserQuery = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(checkUserQuery, connection))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        int userCount = Convert.ToInt32(command.ExecuteScalar());
                        if (userCount > 0)
                        {
                            MessageBox.Show("El nombre de usuario ya existe. Por favor, elige otro.");
                            return;
                        }
                    }

                    if (contraseña2.Text == Ccontraseña.Text)
                    {
                        string insertQuery = "INSERT INTO usuarios (usuario, contraseña, edad, diabetes, tipodiabetes, peso) VALUES (@usuario, @contraseña, @edad, @diabetes, @tipodbts, @peso)";
                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@usuario", usuario);
                            command.Parameters.AddWithValue("@contraseña", contraseña);
                            command.Parameters.AddWithValue("@edad", edad);
                            command.Parameters.AddWithValue("@diabetes", diabetes);
                            command.Parameters.AddWithValue("@tipodbts", tpodbts);
                            command.Parameters.AddWithValue("@peso", peso);
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                Juego_recetario segpag = new Juego_recetario(usuario2.Text);
                                this.Hide();
                                segpag.Show();
                            }
                            else
                            {
                                MessageBox.Show("Registro fallido, intenta de nuevo.");
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Falta de datos nececarios por llenar");
            }
        }

        private void diabetes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (diabetes1.Text == "Si")
            {
                tipodb.Visible = true;
                label6.Visible = true;
            }
            else
            {
                tipodb.Visible = false;
            }
            if (tipodb.Visible == false)
            {
                tipodb.Text = "";
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            this.Hide();
            inicio.Show();
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = Color.DarkRed;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.White;

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            contraseña2.PasswordChar = '\0';
        }

        private void picVerContra_MouseDown(object sender, MouseEventArgs e)
        {
            Ccontraseña.PasswordChar = '\0';
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            contraseña2.PasswordChar = '*';
        }

        private void picVerContra_MouseUp(object sender, MouseEventArgs e)
        {
            Ccontraseña.PasswordChar = '*';
        }

        private void contraseña2_Click(object sender, EventArgs e)
        {
            contraseña2.PasswordChar = '*';
        }

        private void Ccontraseña_TextChanged(object sender, EventArgs e)
        {
            Ccontraseña.PasswordChar = '*';
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
                using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    connection.Open();
                }
                if (!String.IsNullOrEmpty(usuario2.Text) && !String.IsNullOrEmpty(contraseña2.Text) && !String.IsNullOrEmpty(Ccontraseña.Text) && !String.IsNullOrEmpty(edad1.Text) && !String.IsNullOrEmpty(diabetes1.Text) && !String.IsNullOrEmpty(peso1.Text))
                {
                    string usuario = usuario2.Text;
                    Form5 form2 = new Form5(usuario);
                    string contraseña = contraseña2.Text;
                    int edad = Convert.ToInt32(edad1.Text);
                    string diabetes = diabetes1.Text;
                    string tpodbts = tipodb.Text;
                    int peso = Convert.ToInt32(peso1.Text);
                    MySqlCommand mySqlCommand = new MySqlCommand();

                    string checkUserQuery = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(checkUserQuery, connection))
                        {
                            command.Parameters.AddWithValue("@usuario", usuario);
                            int userCount = Convert.ToInt32(command.ExecuteScalar());
                            if (userCount > 0)
                            {
                                MessageBox.Show("El nombre de usuario ya existe. Por favor, elige otro.");
                                return;
                            }
                        }

                        if (contraseña2.Text == Ccontraseña.Text)
                        {
                            string insertQuery = "INSERT INTO usuarios (usuario, contraseña, edad, diabetes, tipodiabetes, peso) VALUES (@usuario, @contraseña, @edad, @diabetes, @tipodbts, @peso)";
                            using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@usuario", usuario);
                                command.Parameters.AddWithValue("@contraseña", contraseña);
                                command.Parameters.AddWithValue("@edad", edad);
                                command.Parameters.AddWithValue("@diabetes", diabetes);
                                command.Parameters.AddWithValue("@tipodbts", tpodbts);
                                command.Parameters.AddWithValue("@peso", peso);
                                int result = command.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    Juego_recetario segpag = new Juego_recetario(usuario2.Text);
                                    this.Hide();
                                    segpag.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Registro fallido, intenta de nuevo.");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Falta de datos nececarios por llenar");

                }
            }
        }
    }
}