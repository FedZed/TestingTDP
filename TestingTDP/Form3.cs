using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;

namespace TestingTDP
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            Pancho.BringToFront();
            dataGridView2.Visible = false;
        }
        public class MainFunc
        {
            public static MySqlConnection? connection;
            public static string connString = "server=localhost;database=tdp;uid=root;pwd=\"\"";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panelDeAdministracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtInventario_Click(object sender, EventArgs e)
        {
            Pancho2.BringToFront();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            Eliminar.Visible = false;
            Agg.Visible = false;
            Modificar.Visible = false;
            Busqueda2.Visible = false;
            Busqueda.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            Reintegrar.Visible = false;
            Borrar.Visible = false;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,cantidad,precio,tipo, Id_Distribuidores from producto where integrado !=\"X\";");

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

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Busqueda_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (Busqueda.Text == "")
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
                    dataGridView1.DataSource = tabla;

                }
                catch (Exception b)
                {

                    MessageBox.Show(b.Message + b.StackTrace);
                }
            }
            else
            if (Busqueda.Text != "")
            {
                string nombre2 = Busqueda.Text;
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
                    dataGridView1.DataSource = tabla;

                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 p = new Form4();
            p.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,cantidad,precio,tipo, Id_Distribuidores from producto where integrado !=\"X\";");

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Eliminar.Visible = true;
            Modificar.Visible = true;
            Agg.Visible = true;

        }


        private void Eliminar_Click(object sender, EventArgs e)
        {

            String Datos = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            var registerQuery = new MySqlCommand($"UPDATE producto SET Integrado=\"X\" WHERE nombre=\"{Datos}\";", connection);
            registerQuery.ExecuteNonQuery();
            MessageBox.Show("El Producto se a registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Agg_Click(object sender, EventArgs e)
        {
            String Datos = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            Form5 FF = new Form5();
            AddOwnedForm(FF);
            FF.txtNombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FF.Show();

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            String Datos = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            Form6 FF2 = new Form6();
            AddOwnedForm(FF2);
            FF2.Nombretxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FF2.Cantidadtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FF2.Precio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FF2.iDd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            FF2.Tipotxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            var checkInfo = new MySqlCommand($"select Id_Producto,precio2 from producto WHERE nombre= \"{Datos}\"", connection);
            MySqlDataReader reade;
            reade = checkInfo.ExecuteReader();
            if (reade.Read())
            {
                FF2.ll.Text = reade["Id_Producto"].ToString();
                FF2.Precio.Text = reade["precio2"].ToString();
            }
            reade.Read();


            FF2.Show();
        }

        private void DtE_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            Eliminar.Visible = false;
            Agg.Visible = false;
            Modificar.Visible = false;
            Busqueda2.Visible = true;
            Busqueda.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            Reintegrar.Visible = true;
            Borrar.Visible = true;

            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,cantidad,precio,tipo, Id_Distribuidores from producto where integrado = \"X\";");

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



        private void Reintegrar_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            String Nombre = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            var registerQuery = new MySqlCommand($"UPDATE producto SET  Integrado=\"I\" WHERE Nombre=\"{Nombre}\";", connection);
            registerQuery.ExecuteNonQuery();

            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,cantidad,precio,tipo, Id_Distribuidores from producto where integrado = \"X\";");

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

        private void DtC_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            Eliminar.Visible = false;
            Agg.Visible = false;
            Modificar.Visible = false;
            Busqueda2.Visible = false;
            Busqueda.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            Reintegrar.Visible = false;
            Borrar.Visible = false;
        }

        private void Busqueda2_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (Busqueda2.Text == "")
            {
                try
                {

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = connection;
                    comando.CommandText = ("select nombre,cantidad,precio,tipo,Id_Distribuidores from producto where integrado =\"X\" ;");

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
            if (Busqueda2.Text != "")
            {
                string nombre2 = Busqueda2.Text;
                var checkInfo = new MySqlCommand($"select Nombre , cantidad, precio  ,tipo , Id_Distribuidores  from producto WHERE integrado =\"X\" and Nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"select Nombre , cantidad, precio  ,tipo ,  Id_Distribuidores  from producto WHERE integrado =\"X\" and  Nombre  LIKE \"%{nombre2}%\"", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    dataGridView2.DataSource = tabla;

                }

            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre1 = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            connection.Open();
            var registerQuery = new MySqlCommand($"DELETE from producto WHERE Nombre =\"{nombre1}\"", connection);
            registerQuery.ExecuteNonQuery();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,cantidad,precio,tipo,Id_Distribuidores from producto where integrado =\"X\" ;");

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
    }
}





