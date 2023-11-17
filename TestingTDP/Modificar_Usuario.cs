using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySqlConnector;
namespace TestingTDP
{
    public partial class Modificar_Usuario : Form
    {
        string cc;
        public string DandD;
        public Modificar_Usuario()
        {
            InitializeComponent();
        }
        public class MainFunc
        {
            public static MySqlConnection? connection;
            public static string connString = "server=localhost;database=tdp;uid=root;pwd=\"\"";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre = Nombre.Text;
            string correo = Correo.Text;

            connection.Open();

            var checkInfo1 = new MySqlCommand($"Select * From usuario where nombre=\"{DandD}\"", connection);
            var Reader = checkInfo1.ExecuteReader();
            Reader.Read();
            if (Reader.HasRows)
            {
                Reader.Close();
                var registerQuery = new MySqlCommand($"UPDATE usuario SET Nombre=\"{nombre}\",cargo=\"{cc}\",email=\"{correo}\" WHERE nombre=\"{DandD}\"", connection);

                registerQuery.ExecuteNonQuery();
                MessageBox.Show($"El Usuario cambio Nombre :\"{nombre}\" , cargo=\"{cc}\" , email=\"{correo}\" ", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin FF3 = new Admin();
                AddOwnedForm(FF3);
                try
                {

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = connection;
                    comando.CommandText = ("SELECT Nombre,email,cargo FROM `usuario` where visible=1;");

                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    FF3.Usview.DataSource = tabla;

                }
                catch (Exception b)
                {

                    MessageBox.Show(b.Message + b.StackTrace);
                }
                this.Close();


            }
            else
            {
                Reader.Close();
                MessageBox.Show("No se ah seleccionado Usuario correctamente ", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Carg_CheckedChanged(object sender, EventArgs e)
        {
            cc = "Caja";
        }

        private void Cargo_CheckedChanged(object sender, EventArgs e)
        {
            cc = "Panadero";
        }
    }
}
