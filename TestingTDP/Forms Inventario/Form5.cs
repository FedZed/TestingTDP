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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,cantidad from producto where integrado !=\"X\" ;");

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
        private void button1_Click(object sender, EventArgs e)
        {
            string edit = txtNombre.Text;
            string edit1 = txtCant.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"UPDATE producto SET Cantidad=Cantidad + \"{edit1}\" WHERE Nombre=\"{edit}\";", connection);
            registerQuery.ExecuteNonQuery();
            MessageBox.Show("Se agrego el stock de forma correcta", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (txtNombre.Text == "")
            {
                try
                {

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = connection;
                    comando.CommandText = ("select nombre,cantidad from producto where integrado !=\"X\" ;");

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
            else
            if (txtNombre.Text != "")
            {
                string nombre2 = txtNombre.Text;
                var checkInfo = new MySqlCommand($"select Nombre , cantidad  from producto WHERE integrado !=\"X\" and Nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"select Nombre , cantidad  from producto WHERE integrado !=\"X\" and  Nombre  LIKE \"%{nombre2}%\"", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    dataGridView2.DataSource = tabla;

                }

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
