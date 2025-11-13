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
        public Form4( String usuariorecived1)
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
                        label26.Text = result1.ToString();
                }

                string query2 = "SELECT usuario FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result2 = command2.ExecuteScalar();
                    if (result2 != null)
                        label22.Text = result2.ToString();
                }

                string query3 = "SELECT contraseña FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command3 = new MySqlCommand(query3, connection))
                {
                    command3.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result3 = command3.ExecuteScalar();
                    if (result3 != null)
                        label23.Text = result3.ToString();
                }
                string query4 = "SELECT diabetes FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command4 = new MySqlCommand(query4, connection))
                {
                    command4.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result4 = command4.ExecuteScalar();
                    if (result4 != null)
                        label24.Text = result4.ToString();
                }

                string query5 = "SELECT tipodiabetes FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command5 = new MySqlCommand(query5, connection))
                {
                    command5.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result5 = command5.ExecuteScalar();
                    if (result5 != null)
                        label25.Text = result5.ToString();
                }
                string query6 = "SELECT peso FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command1 = new MySqlCommand(query6, connection))
                {
                    command1.Parameters.AddWithValue("@usuario", nombreUsuario);
                    object result1 = command1.ExecuteScalar();
                    if (result1 != null)
                    {
                        label27.Text = result1.ToString();
                        
                    }
                }
            }
         

        }

        private void label12_Click(object sender, EventArgs e)
        {

            Form5 inicio = new Form5(usuariorecived);
            this.Hide();
            inicio.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = usuariorecived;
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Form6 cimc = new Form6(usuariorecived);
            this.Hide();
            cimc.Show();
        }
    }
}
