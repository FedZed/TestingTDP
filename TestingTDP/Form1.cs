using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace TestingTDP
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public class MainFunc
        {
            public static MySqlConnection? connection;
            public static string connString = "server=localhost;database=tdp;uid=root;pwd=\"\"";




        }
        public static class informacion
        {
            public static string? correoLogin { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            informacion.correoLogin = textBox1.Text;
            var NombreUsuario_form = textBox1.Text;
            var loginQuery = new MySqlCommand($"SELECT Cargo,visible FROM usuario WHERE Nombre=\"{NombreUsuario_form}\" AND Contraseña=\"{Class1.HashString(textBox2.Text)}\" and visible=1", connection);
            var reader = loginQuery.ExecuteReader();
            reader.Read();
            if ((reader.HasRows && reader["Cargo"].ToString() == "Administrador"))
            {
                Admin paneladmin = new Admin();
                this.Hide();
                paneladmin.Show();
            }

            else if ((reader.HasRows && reader["Cargo"].ToString() == "Panadero"))
            {
                Admin paneladmin = new Admin();

                AddOwnedForm(paneladmin);
                paneladmin.BtInventario.Visible = false;
                paneladmin.button3.Visible = false;
                paneladmin.button4.Visible = false;
                paneladmin.button2.Location = new System.Drawing.Point(18, 35);
                this.Hide();
                paneladmin.Show();
            }
            else if ((reader.HasRows && reader["Cargo"].ToString() == "Caja"))
            {
                Admin paneladmin = new Admin();

                AddOwnedForm(paneladmin);
                paneladmin.button3.Visible = false;
                paneladmin.button2.Visible = false;
                paneladmin.button4.Location = new System.Drawing.Point(18, 100);
                paneladmin.MtFactu.Location = new System.Drawing.Point(18, 140);
                this.Hide();
                paneladmin.Show();
            }
            else
            {
                MessageBox.Show("Su usuario/contraseña son invalidos o no se encuentra verificado en este momento", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pb1.BringToFront();
            textBox2.PasswordChar = '\0';
        }

        private void Pb1_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            textBox2.PasswordChar = '*';
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            p1.BringToFront();
        }

        private void OlvideMiContraseña_Click(object sender, EventArgs e)
        {
            Register regis = new Register();
            regis.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}