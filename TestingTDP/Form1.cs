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
            var correo_form = textBox1.Text;
            var passwd_form = textBox2.Text;
            var loginQuery = new MySqlCommand($"SELECT id FROM usuario WHERE Administrador=\"{correo_form}\" AND Contraseña=\"{passwd_form}\"", connection);
            var reader = loginQuery.ExecuteReader();
            reader.Read();

            if ((reader.HasRows && reader["id"].ToString() == "1"))
            {
                Form2 paneladmin = new Form2();
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
    }
}