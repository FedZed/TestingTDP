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
    public partial class Mat : Form
    {
        int si = 1;
        public Mat()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT DISTINCT nombre,precio FROM producto where tipo=\"Panaderia\";");

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
        public class MainFunc
        {
            public static MySqlConnection? connection;
            public static string connString = "server=localhost;database=tdp;uid=root;pwd=\"\"";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre = Nombretxt.Text;
            string precio = Preciotxt.Text;
            string cantidad = Cantidadtxt.Text;

            connection.Open();

            var checkInfo1 = new MySqlCommand($"Select nombre From Producto where nombre=\"{nombre}\"", connection);
            var Reader = checkInfo1.ExecuteReader();
            Reader.Read();
            if (Reader.HasRows)
            {
                Reader.Close();
                var registerQuery = new MySqlCommand($"UPDATE producto SET Precio2=\"{precio}\",Precio=\"${precio}\" ,Cantidad=Cantidad + \"{cantidad}\" WHERE Nombre=\"{nombre}\";", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show("Se agrego el stock de forma correcta", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Reader.Close();
                var registerQuery = new MySqlCommand($"INSERT INTO producto (Nombre, tipo , precio2 , precio , cantidad , Id_Distribuidores,integrado) VALUES (\"{nombre}\", \"Panaderia\", \"{precio}\", \"${precio}\", \"{cantidad}\", \"0\",\"I\")", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show("El Producto se a registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Pancho.Visible = true;
            si = 1;

            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT  nombre,tipo,cantidad FROM materia_prima where visible !=\"1\";");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }

        }

        private void MateriaPrima_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            Nombretxt.Text = MateriaPrima.CurrentRow.Cells[0].Value.ToString();
            Preciotxt.Text = MateriaPrima.CurrentRow.Cells[1].Value.ToString();
        }

        private void Cant_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cantidadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Preciotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Preciotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            string nombre = textNombre.Text;
            string canti = Cantidaduti.Text;
            int Mt = Int32.Parse(Cant.Text);

            if (Mt < si)
            {
                Pancho.Visible = false;
                this.Close();
             
            }
            else
            {
                si = si + 1;

                var registerQuery = new MySqlCommand($"UPDATE materia_prima SET Cantidad=Cantidad -\"{canti}\" WHERE Nombre=\"{nombre}\";", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show("Se agrego el stock de forma correcta", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
