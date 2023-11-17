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
    public partial class agregarmatcs : Form
    {

        public agregarmatcs()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT DISTINCT tipo FROM materia_prima;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                MateriaPrima.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }
        //SELECT DISTINCT tipo FROM producto;
        public class MainFunc
        {
            public static MySqlConnection? connection;
            public static string connString = "server=localhost;database=tdp;uid=root;pwd=\"\"";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre = Nombretxt.Text;
            string cantidad = Cantidadtxt.Text;
            string IdD = iDd.Text;
            string Tipo = Tipotxt.Text;



            connection.Open();

            var checkInfo1 = new MySqlCommand($"Select Rut From distribuidor where Rut=\"{IdD}\"", connection);
            var Reader = checkInfo1.ExecuteReader();
            Reader.Read();
            if (Reader.HasRows)
            {
                Reader.Close();
                var registerQuery = new MySqlCommand($"INSERT INTO materia_prima (Nombre, tipo , cantidad , IdD,visible) VALUES (\"{nombre}\", \"{Tipo}\", \"{cantidad}\", \"{IdD}\",0)", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show("La materia prima se a registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Reader.Close();
                MessageBox.Show("El Distribuidor no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MateriaPrima_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            Tipotxt.Text = MateriaPrima.CurrentRow.Cells[0].Value.ToString();

        }

        private void MateriaPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
