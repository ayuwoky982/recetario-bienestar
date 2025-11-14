using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form6 : Form
    {
        public string usuariorecived1;
        public Form6(string usuariorecived)
        {
            InitializeComponent();
            this.usuariorecived1 = usuariorecived;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT altura FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command1 = new MySqlCommand(query1, connection))
                {
                    command1.Parameters.AddWithValue("@usuario", usuariorecived1);
                    object result1 = command1.ExecuteScalar();
                    if (result1 != null)
                        alturalbl.Text = result1.ToString();
                }
                string query2 = "SELECT peso FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@usuario", usuariorecived1);
                    object result2 = command2.ExecuteScalar();
                    if (result2 != null)
                        pesolbl.Text = result2.ToString();
                }
                string query3 = "SELECT sexo FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command3 = new MySqlCommand(query3, connection))
                {
                    command3.Parameters.AddWithValue("@usuario", usuariorecived1);
                    object result3 = command3.ExecuteScalar();
                    if (result3 != null)
                        sexolbl.Text = result3.ToString();
                }
                usuariolbl.Text = usuariorecived1;
            }
        }
        private void lblCalcularRes_Click(object sender, EventArgs e)
        {
            int peso, altura;
            string sexo;
            double imc;

            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT altura FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command1 = new MySqlCommand(query1, connection))
                {
                    command1.Parameters.AddWithValue("@usuario", usuariorecived1);
                    object result1 = command1.ExecuteScalar();
                    if (result1 != null)
                        alturalbl.Text = result1.ToString();
                }
                string query2 = "SELECT peso FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@usuario", usuariorecived1);
                    object result2 = command2.ExecuteScalar();
                    if (result2 != null)
                        pesolbl.Text = result2.ToString();
                }
                string query3 = "SELECT sexo FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command3 = new MySqlCommand(query3, connection))
                {
                    command3.Parameters.AddWithValue("@usuario", usuariorecived1);
                    object result3 = command3.ExecuteScalar();
                    if (result3 != null)
                        sexolbl.Text = result3.ToString();
                }
                usuariolbl.Text = usuariorecived1;

                altura = Convert.ToInt32(alturalbl.Text);
                peso = Convert.ToInt32(pesolbl.Text);
                sexo = sexolbl.Text;
                imc = ((peso * 10000.0) / Math.Pow(altura, 2));

                string insertOrUpdateQuery = @"
                 INSERT INTO imc (usuario, IMC)
                 VALUES (@usuario, @IMC)
                 ON DUPLICATE KEY UPDATE
                 IMC = VALUES(IMC);";

                using (MySqlCommand command = new MySqlCommand(insertOrUpdateQuery, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuariorecived1);
                    command.Parameters.AddWithValue("@IMC", imc);
                    command.ExecuteNonQuery();
                }
                switch (sexo)
                {
                    case "Masculino":
                        if (imc < 20)
                        {
                            resultado1.Text = imc.ToString("0.00");
                            resultado2.Text = "Bajo peso";
                        }
                        else if (imc >= 20 && imc < 25)
                        {
                            resultado1.Text = imc.ToString("0.00");
                            resultado2.Text = "Peso normal";
                        }
                        else if (imc >= 25 && imc < 30)
                        {
                            resultado1.Text = imc.ToString("0.00");
                            resultado2.Text = "Sobrepeso";
                        }
                        else if (imc >= 30)
                        {
                            resultado1.Text = imc.ToString("0.00");
                            resultado2.Text = "Obesidad";
                        }
                        break;
                    case "Femenino":
                        if (imc < 20)
                        {
                            resultado1.Text = imc.ToString("0.00");
                            resultado2.Text = "Bajo peso";
                        }
                        else if (imc >= 20 && imc < 25)
                        {
                            resultado1.Text = imc.ToString("0.00");
                            resultado2.Text = "Peso normal";
                        }
                        else if (imc >= 25 && imc < 30)
                        {
                            resultado1.Text = imc.ToString("0.00");
                            resultado2.Text = "Sobrepeso";
                        }
                        else if (imc >= 30)
                        {
                            resultado1.Text = imc.ToString("0.00");
                            resultado2.Text = "Obesidad";
                        }
                        break;
                }
            }
        }

        private void lblDescargarRes_Click(object sender, EventArgs e)
        {
            int peso, altura;
            string sexo;
            double imc;

            string connectionString = "server=localhost;user id=root;password=;database=recetario_bienestar";
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT altura FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command1 = new MySqlCommand(query1, connection))
                {
                    command1.Parameters.AddWithValue("@usuario", usuariorecived1);
                    object result1 = command1.ExecuteScalar();
                    if (result1 != null)
                        alturalbl.Text = result1.ToString();
                }
                string query2 = "SELECT peso FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@usuario", usuariorecived1);
                    object result2 = command2.ExecuteScalar();
                    if (result2 != null)
                        pesolbl.Text = result2.ToString();
                }
                string query3 = "SELECT sexo FROM usuarios WHERE usuario = @usuario";
                using (MySqlCommand command3 = new MySqlCommand(query3, connection))
                {
                    command3.Parameters.AddWithValue("@usuario", usuariorecived1);
                    object result3 = command3.ExecuteScalar();
                    if (result3 != null)
                        sexolbl.Text = result3.ToString();
                }
                usuariolbl.Text = usuariorecived1;
            }

            altura = Convert.ToInt32(alturalbl.Text);
            peso = Convert.ToInt32(pesolbl.Text);
            sexo = sexolbl.Text;
            imc = (peso * 10000.0) / Math.Pow(altura, 2);

            switch (sexo)
            {
                case "Masculino":
                    if (imc < 20)
                    {
                        guardar1.Text = ("tu IMC es: " + imc.ToString("0.00"));
                        guardar2.Text = "Bajo peso";
                    }
                    else if (imc >= 20 && imc < 25)
                    {
                        guardar1.Text = ("tu IMC es: " + imc.ToString("0.00"));
                        guardar2.Text = "Peso normal";
                    }
                    else if (imc >= 25 && imc < 30)
                    {
                        guardar1.Text = ("tu IMC es: " + imc.ToString("0.00"));
                        guardar2.Text = "Sobrepeso";
                    }
                    else if (imc >= 30)
                    {
                        guardar1.Text = ("tu IMC es: " + imc.ToString("0.00"));
                        guardar2.Text = "Obesidad";
                    }
                    break;
                case "Femenino":
                    if (imc < 20)
                    {
                        guardar1.Text = ("tu IMC es: " + imc.ToString("0.00"));
                        guardar2.Text = "Bajo peso";
                    }
                    else if (imc >= 20 && imc < 25)
                    {
                        guardar1.Text = ("tu IMC es: " + imc.ToString("0.00"));
                        guardar2.Text = "Peso normal";
                    }
                    else if (imc >= 25 && imc < 30)
                    {
                        guardar1.Text = ("tu IMC es: " + imc.ToString("0.00"));
                        guardar2.Text = "Sobrepeso";
                    }
                    else if (imc >= 30)
                    {
                        guardar1.Text = ("tu IMC es: " + imc.ToString("0.00"));
                        guardar2.Text = "Obesidad";
                    }
                    break;
            }

            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(escritorio, "ResultadosIMC.txt");

            using (StreamWriter archivo = new StreamWriter(rutaArchivo, false))
            {
                archivo.WriteLine("Datos del usuario");
                archivo.WriteLine("                                 ");
                archivo.WriteLine("nombre del usuario: " + usuariorecived1);
                archivo.WriteLine("peso del usuario: " + peso + "Kg");
                archivo.WriteLine("altura del usuario: " + altura + "Cm");
                archivo.WriteLine("sexo del usuario: " + sexo);

                archivo.WriteLine("Resultados del IMC:");
                archivo.WriteLine("Resultado IMC: " + guardar1.Text);
                archivo.WriteLine("Diagnóstico: " + guardar2.Text);
                archivo.WriteLine("Fecha de la generacion de resultados: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            }
            MessageBox.Show("Los resultados se han guardado automáticamente en el Escritorio." + "Recetario del Bienestar" + MessageBoxButtons.OK + MessageBoxIcon.Information);
        }

        private void lblRegresar_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(usuariorecived1);
            form4.Show();
            this.Hide();
        }
    }
}
