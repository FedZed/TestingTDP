using Microsoft.VisualBasic;
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
    public partial class Register : Form
    {
        static Random random = new Random();
        static int codigo = random.Next(100000, 999999);
        public Register()
        {
            InitializeComponent();
        }
        public class MainFunc
        {
            public static MySqlConnection? connection;
            public static string connString = "server=localhost;database=tdp;uid=root;pwd=\"\"";


        }
        private void button1_Click(object sender, EventArgs e)
        {

            string correo = Corre.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            var checkInfo = new MySqlCommand($"select email from usuario WHERE Nombre =\"{Corre.Text}\"", connection);
            var reade = checkInfo.ExecuteReader();
            reade.Read();
            if (reade.HasRows)
            {
                MessageBox.Show("Error no existe un mail", "JO-NA - Panaderia ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                reade.Close();

                Correo.Email(correo, "Reseteo de contraseña - JO-NA Panaderia",
                $"Aqui tiene su Codigo para restablecer su.<br>Contraseña Codigo:\"{codigo}\"<br><br>Saludos cordiales,<br>TDP<br>Para alguna otra consulta inserte email de asesor");
                MessageBox.Show("codigo para resablecer contraseña", "JO-NA - Panaderia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string contra1 = Cotra2.Text;
            string contra = Ncontraseña.Text;
            string correo = Corre.Text;
            int codig = int.Parse(Codi.Text);
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            var checkInfo = new MySqlCommand($"select email from usuario WHERE Nombre =\"{Corre.Text}\"", connection);
            var reade = checkInfo.ExecuteReader();
            reade.Read();
            if (reade.HasRows || contra1 == contra || codig == codigo)
            {
                reade.Close();

                var registerQuery = new MySqlCommand($"UPDATE usuario SET contraseña=\"{Class1.HashString(contra1)}\" WHERE email=\"{correo}\";", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show("Cambio de constraseña exitoso", "JO-NA - Panaderia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Datos erroneos intente nuevamente", "JO-NA - Panaderia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Login = new Form1();
            Login.Show();
            this.Hide();
        }
    }
}
