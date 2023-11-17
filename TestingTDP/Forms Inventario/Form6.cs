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
    public partial class Form6 : Form
    {
        string Datos;
        String Tipo;
        public Form6()
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            InitializeComponent();
            Tipotxt.ReadOnly = true;
            radioButton3.Checked = true;
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
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre = Nombretxt.Text;
            string precio = Precio.Text;
            string cantidad = Cantidadtxt.Text;
            string IdD = iDd.Text;
            string datos = ll.Text;
            connection.Open();

            var checkInfo1 = new MySqlCommand($"Select Rut From distribuidor where Rut=\"{IdD}\"", connection);
            var Reader = checkInfo1.ExecuteReader();
            Reader.Read();
            if (Reader.HasRows)
            {
                Reader.Close();
                var registerQuery = new MySqlCommand($"UPDATE producto SET Nombre=\"{nombre}\",tipo=\"{Tipo}\",Precio=\"{precio}\",cantidad=\"{cantidad}\",id_Distribuidores=\"{IdD}\" WHERE id_producto=\"{datos}\"", connection);

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Tipo = "Comestible";
            Tipotxt.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Tipo = "Bebible";
            Tipotxt.ReadOnly = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Tipotxt.ReadOnly = false;
            Tipo = Tipotxt.Text;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nombretxt_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (Nombretxt.Text == "")
            {
                try
                {

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = connection;
                    comando.CommandText = ("select nombre,cantidad,precio,tipo,Id_Distribuidores from producto where integrado !=\"X\" ;");

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
            if (Nombretxt.Text != "")
            {
                string nombre2 = Nombretxt.Text;
                var checkInfo = new MySqlCommand($"select Nombre , cantidad, precio  ,tipo , Id_Distribuidores  from producto WHERE integrado !=\"X\" and Nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"select Nombre , cantidad, precio  ,tipo ,  Id_Distribuidores  from producto WHERE integrado !=\"X\" and  Nombre  LIKE \"%{nombre2}%\"", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    dataGridView2.DataSource = tabla;

                }

            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            Nombretxt.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Cantidadtxt.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Precio.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            iDd.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            Tipotxt.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            string iD = Nombretxt.Text;
            var checkInfo = new MySqlCommand($"select Id_Producto from producto WHERE nombre= \"{iD}\"", connection);
            MySqlDataReader reade;
            reade = checkInfo.ExecuteReader();
            if (reade.Read())
            {
                ll.Text = reade["Id_Producto"].ToString();
            }
            reade.Read();
        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ll_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

