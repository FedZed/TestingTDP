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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void button10_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select Nombre,Cantidad,tipo,IdD from materia_prima where visible != 1 ;");

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
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,cantidad,tipo,idD from materia_prima where visible != 0 ;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView3.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            String Datos = MateriaPrima.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            var registerQuery = new MySqlCommand($"UPDATE materia_prima SET visible=1 WHERE nombre=\"{Datos}\";", connection);
            registerQuery.ExecuteNonQuery();
            MessageBox.Show("El Producto sea a Eliminado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select Nombre,Cantidad,tipo,IdD from materia_prima where visible != 1 ;");

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

        private void button2_Click(object sender, EventArgs e)
        {
            Txtbusq.Visible = false;
            ags.Visible = false;
            Elin.Visible = false;
            eliminarp.Visible = false;
            np.Visible = false;
            mod.Visible = false;
            eli.Visible = false;
            dataGridView3.Visible = false;
            panel2.BringToFront();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            MateriaPrima.Visible = true;
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,cantidad,tipo,idD from materia_prima where visible != 1 ;");

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

        private void button14_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            agregarmatcs FF = new agregarmatcs();
            AddOwnedForm(FF);
            FF.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            Mat FF = new Mat();
            AddOwnedForm(FF);
            FF.Show();
        }

        private void MateriaPrima_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            Eliminar.Visible = false;
            Modificar.Visible = false;
            Agg.Visible = false;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Eliminar.Visible = true;
            Modificar.Visible = true;
            Agg.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            ModificarMat FF = new ModificarMat();
            AddOwnedForm(FF);
            FF.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            Txtbusq.Visible = true;
            dataGridView3.Visible = true;
            MateriaPrima.Visible = false;
            Elin.Visible = true;
            ags.Visible = false;
            agm.Visible = false;
            np.Visible = false;
            mod.Visible = false;
            eli.Visible = false;
            eliminarp.Visible = true;
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,cantidad,tipo,idD from materia_prima where visible != 0 ;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView3.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            MateriaPrima.Visible = true;
            agm.Visible = true;
            Elin.Visible = false;
            eliminarp.Visible = false;
            txtbus.Visible = false;
            Txtbusq.Visible = true;
        }

        private void MateriaPrima_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ags.Visible = true;

            np.Visible = true;
            mod.Visible = true;
            eli.Visible = true;
        }

        private void ags_Click(object sender, EventArgs e)
        {
            agstock Fagstock = new agstock();
            AddOwnedForm(Fagstock);
            Fagstock.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            String Datos = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            var registerQuery = new MySqlCommand($"UPDATE materia_prima SET visible=0 WHERE nombre=\"{Datos}\";", connection);
            registerQuery.ExecuteNonQuery();
            MessageBox.Show("El Producto sea a Eliminado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select Nombre,Cantidad,tipo,IdD from materia_prima where visible != 0 ;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView3.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void eliminarp_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre1 = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            connection.Open();
            var registerQuery = new MySqlCommand($"DELETE from materia_prima WHERE Nombre =\"{nombre1}\"", connection);
            registerQuery.ExecuteNonQuery();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select Nombre,Cantidad,tipo,IdD from materia_prima where visible != 0 ;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView3.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (txtbus.Text == "")
            {
                label1.Visible = false;
                MateriaPrima.Visible = true;
            }
            else
            if (txtbus.Text != "")
            {
                label1.Visible = false;
                MateriaPrima.Visible = true;
                string nombre2 = txtbus.Text;
                var checkInfo = new MySqlCommand($"select Nombre , cantidad, tipo , IdD  from materia_prima WHERE visible !=\"1\" and Nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"select Nombre , cantidad ,tipo ,  IdD  from materia_prima WHERE visible !=\"1\" and  Nombre  LIKE \"%{nombre2}%\"", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    MateriaPrima.DataSource = tabla;

                }
                else
                {
                    MateriaPrima.Visible = false;
                    label1.Visible = true;
                }

            }
        }

        private void Txtbusq_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (Txtbusq.Text == "")
            {
                label1.Visible = false;
                dataGridView3.Visible = true;
            }
            else
            if (Txtbusq.Text != "")
            {
                string nombre2 = Txtbusq.Text;
                var checkInfo = new MySqlCommand($"select Nombre , cantidad, tipo , IdD  from materia_prima WHERE visible !=\"0\" and Nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    label1.Visible = false;
                    dataGridView3.Visible = true;
                    reade.Close();


                    var registerQuery = new MySqlCommand($"select Nombre , cantidad ,tipo ,  IdD  from materia_prima WHERE visible !=\"0\" and  Nombre  LIKE \"%{nombre2}%\"", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    dataGridView3.DataSource = tabla;

                }
                else
                {
                    dataGridView3.Visible = false;
                    label1.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Facturacion.BringToFront();
            Elimin.Visible = false;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,cantidad,precio from producto where integrado !=\"X\";");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Produ.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }

        }

        private void Produ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Elimin.Visible = false;
            Nep.Text = Produ.CurrentRow.Cells[0].Value.ToString();
            int one = int.Parse(Produ.CurrentRow.Cells[1].Value.ToString());


            for (int i = 1; i <= one; i++)
            {
                cmbCant.Items.Add(i.ToString());
                cmbCant.SelectedIndex = 0;
            }
        }

        private void AgregarP_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            string Nom = Nep.Text;
            int n = DtFactura.Rows.Add();

            DtFactura.Rows[n].Cells[0].Value = Nep.Text;
            DtFactura.Rows[n].Cells[1].Value = cmbCant.Text;
            var checkInfo = new MySqlCommand($"select precio2 from producto WHERE nombre= \"{Nom}\"", connection);
            MySqlDataReader reade;
            reade = checkInfo.ExecuteReader();
            if (reade.Read())
            {
                int Precio = int.Parse(reade["precio2"].ToString());
                int canti = int.Parse(cmbCant.Text);
                int PrecioTotal = Precio * canti;
                DtFactura.Rows[n].Cells[2].Value = reade["precio2"].ToString();
                DtFactura.Rows[n].Cells[3].Value = "$" + PrecioTotal;

            }
            reade.Read();



        }

        private void DtFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Elimin.Visible = true;
        }

        private void Elimin_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in DtFactura.SelectedRows)
            {
                if (!fila.IsNewRow)
                {
                   DtFactura.Rows.Remove(fila);
                }
            }
        }
    }
}





