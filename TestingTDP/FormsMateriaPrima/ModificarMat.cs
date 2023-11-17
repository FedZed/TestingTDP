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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TestingTDP
{
    public partial class ModificarMat : Form
    {
        public ModificarMat()
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            InitializeComponent();
            connection.Open();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,tipo,cantidad,idD from materia_prima where visible =\"0\" ;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView2.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }
        public class MainFunc
        {
            public static MySqlConnection? connection;
            public static string connString = "server=localhost;database=tdp;uid=root;pwd=\"\"";

        }
        private void Tipotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarMat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre = Nombretxt.Text;
            string precio = Precio.Text;
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
                var registerQuery = new MySqlCommand($"UPDATE materia_prima SET Nombre=\"{nombre}\",tipo=\"{Tipo}\",cantidad=\"{cantidad}\",idD=\"{IdD}\" WHERE nombre=\"{nombre}\"", connection);

                registerQuery.ExecuteNonQuery();
                MessageBox.Show("El Producto se a Modificado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin FF3 = new Admin();
                AddOwnedForm(FF3);
                this.Close();


            }
            else
            {
                Reader.Close();
                MessageBox.Show("El Distribuidor no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            Nombretxt.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Cantidadtxt.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            iDd.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            Tipotxt.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            Nombretxt.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Cantidadtxt.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            iDd.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            Tipotxt.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
