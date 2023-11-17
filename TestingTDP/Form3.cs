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
using System.Reflection.PortableExecutable;
using System.Security.Policy;
using MySqlX.XDevAPI.Relational;
using static TestingTDP.Form1;
using System.Runtime.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TestingTDP
{
    public partial class Admin : Form
    {
        string CargoU;
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
            VUs.Visible = false;
            MtFactu.Visible = false;
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
                dataGridView1.Visible = true;
                label1.Visible = false;
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
            else if (Busqueda.Text != "")
            {
                label1.Visible = false;
                dataGridView1.Visible = true;
                string nombre2 = Busqueda.Text;
                var checkInfo = new MySqlCommand($"select Nombre , cantidad, precio  ,tipo , Id_Distribuidores  from producto WHERE integrado !=\"X\" and Nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();

                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"select Nombre , cantidad, precio  ,tipo , Id_Distribuidores  from producto WHERE integrado !=\"X\" and Nombre LIKE \"%{nombre2}%\"", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    dataGridView1.DataSource = tabla;

                }
                else
                {
                    dataGridView1.Visible = false;
                    label1.Visible = true;
                    label1.BringToFront();
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

            var checkInfo = new MySqlCommand($"select Id_Producto from producto WHERE nombre= \"{Datos}\"", connection);
            MySqlDataReader reade;
            reade = checkInfo.ExecuteReader();
            if (reade.Read())
            {
                FF2.ll.Text = reade["Id_Producto"].ToString();

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

        }

        private void Busqueda2_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (Busqueda2.Text == "")
            {
                dataGridView2.Visible = true;
                label1.Visible = false;
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
                label1.Visible = false;
                dataGridView2.Visible = true;
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"select Nombre , cantidad, precio  ,tipo , Id_Distribuidores  from producto WHERE integrado =\"X\" and Nombre LIKE \"%{nombre2}%\"", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    dataGridView2.DataSource = tabla;

                }
                else
                {
                    dataGridView2.Visible = false;
                    label1.Visible = true;
                    label1.BringToFront();
                }

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
            MessageBox.Show("La Materia prima sea a Eliminado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            VUs.Visible = false;
            MtFactu.Visible = false;
            Txtbusq.Visible = false;
            ags.Visible = false;
            Elin.Visible = false;
            button6.Visible = true;
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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (txtbus.Text == "")
            {
                label1.Visible = false;
                MateriaPrima.Visible = true;
                try
                {

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = connection;
                    comando.CommandText = ("select Nombre,Cantidad,tipo,IdD from materia_prima where visible = 0 ;");

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
            else
            if (txtbus.Text != "")
            {
                label1.Visible = false;
                MateriaPrima.Visible = true;
                string nombre2 = txtbus.Text;
                var checkInfo = new MySqlCommand($"select Nombre , cantidad, tipo , IdD  from materia_prima WHERE visible =\"0\" and Nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"select Nombre , cantidad ,tipo ,  IdD  from materia_prima WHERE visible =\"0\" and  Nombre  LIKE \"%{nombre2}%\"", connection);
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
                    label1.BringToFront();
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
            else
            if (Txtbusq.Text != "")
            {
                string nombre2 = Txtbusq.Text;
                var checkInfo = new MySqlCommand($"select Nombre , cantidad, tipo , IdD  from materia_prima WHERE visible =\"1\" and Nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    label1.Visible = false;
                    dataGridView3.Visible = true;
                    reade.Close();


                    var registerQuery = new MySqlCommand($"select Nombre , cantidad ,tipo ,  IdD  from materia_prima WHERE visible =\"1\" and  Nombre  LIKE \"%{nombre2}%\"", connection);
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
                    label1.BringToFront();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VUs.Visible = false;
            TextBusca.Visible = false;
            MtFactu.Visible = true;
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
            int cant = int.Parse(cmbCant.Text);
            var checkInfo = new MySqlCommand($"select precio from producto WHERE nombre= \"{Nom}\"", connection);
            MySqlDataReader reade;
            reade = checkInfo.ExecuteReader();
            bool productoExistente = false;
            cmbCant.Items.Clear();
            foreach (DataGridViewRow row in DtFactura.Rows)
            {
                if (row.Cells["Nombre_Producto"].Value != null)
                {
                    string nombreProductoExistente = row.Cells["Nombre_Producto"].Value.ToString();

                    if (Nom == nombreProductoExistente)
                    {
                        int cantidadExistente = int.Parse(row.Cells["Cantidad"].Value.ToString());
                        cantidadExistente += cant;
                        row.Cells["Cantidad"].Value = cantidadExistente.ToString();
                        int PrecioExistente = int.Parse(row.Cells["Precio"].Value.ToString());
                        PrecioExistente = PrecioExistente * cantidadExistente;
                        row.Cells["Ptotal"].Value = PrecioExistente.ToString();
                        productoExistente = true;
                        break;
                    }
                }
            }

            if (!productoExistente)
            {
                int n = DtFactura.Rows.Add();
                DtFactura.Rows[n].Cells[0].Value = Nep.Text;
                DtFactura.Rows[n].Cells[1].Value = cmbCant.Text;

                if (reade.Read())
                {
                    int Precio = int.Parse(reade["precio"].ToString());
                    int PrecioTotal = Precio * cant;
                    DtFactura.Rows[n].Cells[2].Value = reade["precio"].ToString();
                    DtFactura.Rows[n].Cells[3].Value = PrecioTotal;
                }
            }

            reade.Close();
            connection.Close();

            int cont = 0;
            int one = 0;
            one = DtFactura.RowCount;
            for (int i = 0; i < one; i++)
            {
                cont += int.Parse(DtFactura.Rows[i].Cells[3].Value.ToString());
                txtPre.Text = cont.ToString();
            }

        }

        private void DtFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Elimin.Visible = true;
        }

        private void Elimin_Click(object sender, EventArgs e)
        {
            //Borra la fila en el datagriedview dtfactura
            foreach (DataGridViewRow fila in DtFactura.SelectedRows)
            {
                if (!fila.IsNewRow)
                {
                    DtFactura.Rows.Remove(fila);
                }
            }

            int cont = 0;
            int one = 0;
            one = DtFactura.RowCount;
            for (int i = 0; i < one; i++)
            {
                cont += int.Parse(DtFactura.Rows[i].Cells[3].Value.ToString());
                txtPre.Text = cont.ToString();
            }

        }

        private void Venta_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            int can = DtFactura.RowCount;
            string id;
            var checkInfo = new MySqlCommand($"select max(IdF) as D from factura", connection);
            MySqlDataReader reade;
            reade = checkInfo.ExecuteReader();
            DateTime fechaActual = DateTime.Now;
            string formatoFecha = fechaActual.ToString("yyyy-MM-dd");
            int MDL = int.Parse(Pg.Text);
            int P = int.Parse(txtPre.Text);
            int res = MDL - P;
            if (reade.Read())
            {
                id = reade["D"].ToString();
                int ids = int.Parse(id);
                ids = ids + 1;
                reade.Read();
                reade.Close();


                ClsFc.CreaTicket Ticket1 = new ClsFc.CreaTicket();

                Ticket1.TextoCentro("Jo-Na Panaderia"); //imprime una linea de descripcion
                Ticket1.TextoCentro("**********************************");

                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
                Ticket1.TextoIzquierda("No Fac: " + ids);
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Atencion en Caja");
                Ticket1.TextoIzquierda("");
                ClsFc.CreaTicket.LineasGuion();

                ClsFc.CreaTicket.EncabezadoVenta();
                ClsFc.CreaTicket.LineasGuion();
                foreach (DataGridViewRow Cantrow in DtFactura.Rows)
                {
                    // PROD                        // CANT                                          PrECIO                       TOTAL
                    Ticket1.AgregaArticulo(Cantrow.Cells[0].Value.ToString(), int.Parse(Cantrow.Cells[2].Value.ToString()), int.Parse(Cantrow.Cells[1].Value.ToString()), int.Parse(Cantrow.Cells[3].Value.ToString())); //imprime una linea de descripcion
                }


                ClsFc.CreaTicket.LineasGuion();
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total", int.Parse(txtPre.Text)); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Efectivo Entregado:", int.Parse(Pg.Text));
                Ticket1.AgregaTotales("Efectivo Devuelto:", int.Parse(res.ToString()));


                // Ticket1.LineasTotales(); // imprime linea 

                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoCentro("*     Gracias por preferirnos    *");

                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer";
                Ticket1.ImprimirTiket(impresora);





                for (int i = 0; i < can; i++)
                {
                    string Nombre = DtFactura.Rows[i].Cells[0].Value.ToString();
                    string precio = DtFactura.Rows[i].Cells[2].Value.ToString();
                    string cantidad = DtFactura.Rows[i].Cells[1].Value.ToString();
                    string cantotal = DtFactura.Rows[i].Cells[3].Value.ToString();

                    var registerQuery = new MySqlCommand($"INSERT INTO factura (Nombre_Producto,Precio,Cantidad,Precio_Total,IdF,Factura,Fecha,visible) VALUES (\"{Nombre}\", \"{precio}\", \"{cantidad}\" , \"{cantotal}\", \"{ids}\",\"Factura\", \"{formatoFecha}\",\"1\")", connection);
                    registerQuery.ExecuteNonQuery();
                    var registerQuerys = new MySqlCommand($"UPDATE Producto SET Cantidad=Cantidad - \"{cantidad}\" WHERE Nombre=\"{Nombre}\";", connection);
                    registerQuerys.ExecuteNonQuery();


                }
                DtFactura.Rows.Clear();
                MessageBox.Show("La venta se a realizado con exito", "Registro Exitoso", MessageBoxButtons.OK);
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


        }

        private void button3_Click(object sender, EventArgs e)
        {
            VUs.Visible = false;
            textBox3.Visible = true;
            Rdis.Visible = false;
            Didi.Visible = false;
            BDIS.Visible = false;
            Modius.Visible = false;
            pandis.BringToFront();
            ElimiDis.Visible = false;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT rut,nombre,telefono,direccion FROM `distribuidor` where visible!=0;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                DtDis.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void MtFactu_Click(object sender, EventArgs e)
        {
            NFac.Visible = false;
            borr.Visible = false;
            button9.Visible = false;
            TextBusca.Visible = false;
            textBox1.Visible = true;
            Reis.Visible = false;
            MotFac.BringToFront();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT DISTINCT(idf) as Numero_Venta,Factura FROM `factura` where visible!=0  and idf!=0 ORDER by IdF;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Factur.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (textBox1.Text == "")
            {
                label1.Visible = false;
                Factur.Visible = true;
            }
            else
            if (textBox1.Text != "")
            {
                label1.Visible = false;
                Factur.Visible = true;
                string nombre2 = textBox1.Text;
                var checkInfo = new MySqlCommand($"SELECT DISTINCT(idf) as Numero_Venta,Factura FROM `factura` where idf!=0  and visible!=0 and idf LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"SELECT DISTINCT(idf) as Numero_Venta,Factura FROM `factura` where idf!=0  and visible!=0 and idf LIKE \"%{nombre2}%\" ", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    Factur.DataSource = tabla;

                }
                else
                {
                    Factur.Visible = false;
                    label1.Visible = true;
                    label1.BringToFront();
                }

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void borr_Click(object sender, EventArgs e)
        {
            String Datos = Factur.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            var registerQuery = new MySqlCommand($"UPDATE Factura SET visible=0 WHERE idf=\"{Datos}\";", connection);
            registerQuery.ExecuteNonQuery();
            MessageBox.Show("El Producto sea a Eliminado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT DISTINCT(idf) as Numero_Venta,Factura FROM `factura` where visible!=0  and idf!=0 ORDER by IdF;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Factur.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }

        }

        private void Factur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            borr.Visible = true;
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            NFac.Visible = false;
            button9.Visible = false;
            Factur.Visible = true;
            textBox1.Visible = true;
            mar.Visible = true;
            dc.Visible = true;

        }

        private void Factur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String Datos = Factur.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            mar.Visible = false;
            dc.Visible = false;
            borr.Visible = false;
            Factur.Visible = false;
            textBox1.Visible = false;
            NFac.Visible = true;
            button9.Visible = true;
            var checkInfo = new MySqlCommand($"SELECT Nombre_Producto,precio,cantidad,precio_total FROM `factura` where idf!=0  and visible!=0 and idf=\"{Datos}\"", connection);
            var reade = checkInfo.ExecuteReader();
            reade.Read();
            if (reade.HasRows)
            {
                reade.Close();


                var registerQuery = new MySqlCommand($"SELECT Nombre_Producto,precio,cantidad,precio_total FROM `factura` where idf!=0  and visible!=0 and idf=\"{Datos}\"", connection);
                registerQuery.ExecuteNonQuery();
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = registerQuery;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                NFac.DataSource = tabla;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtPre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtDevolucion.Text = (float.Parse(Pg.Text) - float.Parse(txtPre.Text)).ToString();


            }
            catch { }

            if (txtPre.Text == "")
            {
                TxtDevolucion.Text = "";
            }
        }

        private void Pg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtDevolucion.Text = (float.Parse(Pg.Text) - float.Parse(txtPre.Text)).ToString();


            }
            catch { }

            if (Pg.Text == "")
            {
                TxtDevolucion.Text = "";
            }
        }

        private void mar_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            borr.Visible = false;
            TextBusca.Visible = true;
            textBox1.Visible = false;
            Reis.Visible = true;
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT DISTINCT(idf) as Numero_Venta,Factura FROM `factura` where visible!=1  and idf!=0 ORDER by IdF;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Factur.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void TextBusca_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (TextBusca.Text == "")
            {
                label1.Visible = false;
                Factur.Visible = true;
            }
            else
            if (TextBusca.Text != "")
            {
                label1.Visible = false;
                Factur.Visible = true;
                string nombre2 = textBox1.Text;
                var checkInfo = new MySqlCommand($"SELECT DISTINCT(idf) as Numero_Venta,Factura FROM `factura` where idf!=1  and visible!=0 and idf LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"SELECT DISTINCT(idf) as Numero_Venta,Factura FROM `factura` where idf!=1  and visible!=0 and idf LIKE \"%{nombre2}%\" ", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    Factur.DataSource = tabla;

                }
                else
                {
                    Factur.Visible = false;
                    label1.Visible = true;
                    label1.BringToFront();
                }
            }
        }

        private void dc_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            TextBusca.Visible = false;
            textBox1.Visible = true;
            Reis.Visible = false;
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT DISTINCT(idf) as Numero_Venta,Factura FROM `factura` where visible!=0  and idf!=0 ORDER by IdF;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Factur.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void Reis_Click(object sender, EventArgs e)
        {
            String Datos = Factur.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            var registerQuery = new MySqlCommand($"UPDATE Factura SET visible=1 WHERE idf=\"{Datos}\";", connection);
            registerQuery.ExecuteNonQuery();
            MessageBox.Show("El Producto sea a Eliminado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT DISTINCT(idf) as Numero_Venta,Factura FROM `factura` where visible!=0  and idf!=1 ORDER by IdF;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Factur.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            string nombre = Nomdis.Text;
            string telefono = Telr.Text;
            string dir = dirr.Text;
            string rut = Rut.Text;
            var loginQuery = new MySqlCommand($"SELECT Rut FROM distribuidor WHERE rut=\"{rut}\"", connection);
            var reader = loginQuery.ExecuteReader();
            reader.Read();
            if ((reader.HasRows))
            {
                MessageBox.Show("Ya existe un usuario con ese numero rut", "Registro Fallido");
            }

            else
            {
                reader.Close();


                if (telefono.Length == 9)
                {

                    var registerQuery = new MySqlCommand($"INSERT INTO distribuidor (Nombre, Telefono , rut , direccion,visible) VALUES (\"{nombre}\", \"{telefono}\", \"{rut}\", \"{dir}\",1)", connection);
                    registerQuery.ExecuteNonQuery();
                    MessageBox.Show("El Producto se a registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {

                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = connection;
                        comando.CommandText = ("SELECT rut,nombre,telefono,direccion FROM `distribuidor` where visible!=0;");

                        MySqlDataAdapter adaptar = new MySqlDataAdapter();
                        adaptar.SelectCommand = comando;
                        DataTable tabla = new DataTable();
                        adaptar.Fill(tabla);
                        DtDis.DataSource = tabla;

                    }
                    catch (Exception b)
                    {

                        MessageBox.Show(b.Message + b.StackTrace);
                    }
                }
                else
                {
                    MessageBox.Show("El numero telefonico tiene la cantidad erronea de digitos", "Registro Fallido");
                }

            }
        }

        private void DtDis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ElimiDis.Visible = true;
            Modius.Visible = true;
            Nomdis.Text = DtDis.CurrentRow.Cells[1].Value.ToString();
        }

        private void DtDis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Modius.Visible = true;
            ElimiDis.Visible = true;
            Nomdis.Text = DtDis.CurrentRow.Cells[1].Value.ToString();
            dirr.Text = DtDis.CurrentRow.Cells[3].Value.ToString();
            Telr.Text = DtDis.CurrentRow.Cells[2].Value.ToString();
            Rut.Text = DtDis.CurrentRow.Cells[0].Value.ToString();
        }

        private void ElimiDis_Click(object sender, EventArgs e)
        {
            string rut = DtDis.CurrentRow.Cells[0].Value.ToString();
            string name = DtDis.CurrentRow.Cells[1].Value.ToString();
            DialogResult resultado = MessageBox.Show($"Estas seguro de que quieres eliminarlo  \"{name}\"", "Eliminacion de Distribuidor", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                MySqlConnection connection = new MySqlConnection(MainFunc.connString);
                connection.Open();

                var registerQuery = new MySqlCommand($"UPDATE distribuidor SET visible = 0 WHERE rut=\"{rut}\";", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show($"ELiminacion de distribuidor  \"{name}\"", "Distribuidor Eliminado");
                try
                {

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = connection;
                    comando.CommandText = ("SELECT rut,nombre,telefono,direccion FROM `distribuidor` where visible!=1;");

                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    Didi.DataSource = tabla;

                }
                catch (Exception b)
                {

                    MessageBox.Show(b.Message + b.StackTrace);
                }
            }
            else
            {
                MessageBox.Show($"El distribuidor no ah sido eliminado  \"{name}\"", "Se a cancelado la eliminacion");
            }

        }

        private void Modius_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            string Nombre = DtDis.CurrentRow.Cells[1].Value.ToString();
            string dir = DtDis.CurrentRow.Cells[3].Value.ToString();
            string tel = DtDis.CurrentRow.Cells[2].Value.ToString();
            string rut = DtDis.CurrentRow.Cells[0].Value.ToString();
            var loginQuery = new MySqlCommand($"SELECT Rut FROM distribuidor WHERE rut=\"{rut}\"", connection);
            var reader = loginQuery.ExecuteReader();
            reader.Read();
            if ((reader.HasRows))
            {
                reader.Close();
                var registerQuery = new MySqlCommand($"UPDATE distribuidor SET Nombre=\"{Nombre}\",direccion=\"{dir}\",telefono=\"{tel}\"  where rut=\"{rut}\";", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show("Se modifico el distribuidor con exito", "Registro Fallido");
                try
                {

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = connection;
                    comando.CommandText = ("SELECT rut,nombre,telefono,direccion FROM `distribuidor` where visible!=0;");

                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    DtDis.DataSource = tabla;

                }
                catch (Exception b)
                {

                    MessageBox.Show(b.Message + b.StackTrace);
                }
            }

            else
            {

                MessageBox.Show("No existe un rut con ese numero", "Registro Fallido");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (textBox3.Text == "")
            {
                label1.Visible = false;
                DtDis.Visible = true;
            }
            else
            if (textBox3.Text != "")
            {
                label1.Visible = false;
                DtDis.Visible = true;
                string nombre2 = textBox3.Text;
                var checkInfo = new MySqlCommand($"SELECT rut,nombre,telefono,direccion FROM `distribuidor` where visible!=0 and nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"SELECT rut,nombre,telefono,direccion FROM `distribuidor` where visible!=0  and nombre LIKE \"%{nombre2}%\" ", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    DtDis.DataSource = tabla;

                }
                else
                {
                    DtDis.Visible = false;
                    label1.Visible = true;
                    label1.BringToFront();
                }

            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            BDIS.Visible = true;
            textBox3.Visible = false;
            Didi.Visible = true;
            Modius.Visible = false;
            ElimiDis.Visible = false;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT rut,nombre,telefono,direccion FROM `distribuidor` where visible!=1;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Didi.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void Didi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Rdis.Visible = true;
        }

        private void BDIS_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (BDIS.Text == "")
            {
                label1.Visible = false;
                Didi.Visible = true;
            }
            else
            if (BDIS.Text != "")
            {
                label1.Visible = false;
                Didi.Visible = true;
                string nombre2 = BDIS.Text;
                var checkInfo = new MySqlCommand($"SELECT rut,nombre,telefono,direccion FROM `distribuidor` where visible!=1 and nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"SELECT rut,nombre,telefono,direccion FROM `distribuidor` where visible!=1  and nombre LIKE \"%{nombre2}%\" ", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    Didi.DataSource = tabla;

                }
                else
                {
                    Didi.Visible = false;
                    label1.Visible = true;
                    label1.BringToFront();
                }
            }
        }

        private void Rdis_Click(object sender, EventArgs e)
        {

            string rut = Didi.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            var registerQuery = new MySqlCommand($"UPDATE distribuidor SET visible=1 WHERE rut=\"{rut}\";", connection);
            registerQuery.ExecuteNonQuery();

            MessageBox.Show("Distribuidor Reintegrado", "Reintegro Exitoso");
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            Rdis.Visible = false;
            Didi.Visible = false;
            BDIS.Visible = false;
            Modius.Visible = false;
            ElimiDis.Visible = false;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT rut,nombre,telefono,direccion FROM `distribuidor` where visible!=0;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                DtDis.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void Usuario_Click(object sender, EventArgs e)
        {
            Reins.Visible = false;
            Modus.Visible = false;
            Elius.Visible = false;
            BusEli.Visible = false;
            Viewus.Visible = false;
            VUs.Visible = true;
            MtFactu.Visible = false;
            Panu.BringToFront();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();

            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT Nombre,email,cargo FROM `usuario` where visible=1;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Usview.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void Busque_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (Busque.Text == "")
            {
                label1.Visible = false;
                Usview.Visible = true;

                try
                {

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = connection;
                    comando.CommandText = ("SELECT Nombre,email,cargo FROM `usuario` where visible=1;");

                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    Usview.DataSource = tabla;

                }
                catch (Exception b)
                {

                    MessageBox.Show(b.Message + b.StackTrace);
                }
            }
            else
            if (Busque.Text != "")
            {
                label1.Visible = false;
                Usview.Visible = true;
                string nombre2 = Busque.Text;
                var checkInfo = new MySqlCommand($"SELECT Nombre,email,cargo FROM `usuario` where visible=1 and nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"SELECT Nombre,email,cargo FROM `usuario` where visible=1 and nombre LIKE \"%{nombre2}%\" ", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    Usview.DataSource = tabla;

                }
                else
                {
                    Usview.Visible = false;
                    label1.Visible = true;
                    label1.BringToFront();
                }
            }
        }

        private void Actu_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT Nombre,email,cargo FROM `usuario` where visible=1;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Usview.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void Usview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Elius.Visible = true;
            Modus.Visible = true;
        }

        private void Elius_Click(object sender, EventArgs e)
        {
            string Nombre = Usview.CurrentRow.Cells[0].Value.ToString();
            string Mail = Usview.CurrentRow.Cells[1].Value.ToString();
            DialogResult resultado = MessageBox.Show($"Estas seguro de que quieres eliminar el usuario:  \"{Nombre}\"  , con el mail \"{Mail}\"", "Eliminacion de Usuario", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                MySqlConnection connection = new MySqlConnection(MainFunc.connString);
                connection.Open();

                var registerQuery = new MySqlCommand($"UPDATE usuario SET visible = 0 WHERE email=\"{Mail}\";", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show($"ELiminacion de Usuario : \"{Nombre}\" se ah realizado con exito", "Usuario Eliminado");
                try
                {

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = connection;
                    comando.CommandText = ("SELECT Nombre,email,cargo FROM `usuario` where visible=1;");

                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    Usview.DataSource = tabla;

                }
                catch (Exception b)
                {

                    MessageBox.Show(b.Message + b.StackTrace);
                }
            }
            else
            {
                MessageBox.Show($"Se cancelo la eliminacion del usuario : \"{Nombre}\"", "Se a cancelado la eliminacion");
            }
        }

        private void DtComu_Click(object sender, EventArgs e)
        {
            Modus.Visible = false;
            Reins.Visible = false;
            Viewus.Visible = false;
            Busque.Visible = true;
            BusEli.Visible = false;
            Usview.Visible = true;
        }

        private void DtEli_Click(object sender, EventArgs e)
        {
            Modus.Visible = false;
            Busque.Visible = false;
            BusEli.Visible = true;
            Viewus.Visible = true;
            Usview.Visible = false;
            Elius.Visible = false;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT Nombre,email,cargo FROM `usuario` where visible!=1;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Viewus.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void BusEli_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            if (BusEli.Text == "")
            {
                label1.Visible = false;
                Viewus.Visible = true;

                try
                {

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = connection;
                    comando.CommandText = ("SELECT Nombre,email,cargo FROM `usuario` where visible!=1;");

                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    Viewus.DataSource = tabla;

                }
                catch (Exception b)
                {

                    MessageBox.Show(b.Message + b.StackTrace);
                }
            }
            else
            if (BusEli.Text != "")
            {
                label1.Visible = false;
                Viewus.Visible = true;
                string nombre2 = BusEli.Text;
                var checkInfo = new MySqlCommand($"SELECT Nombre,email,cargo FROM `usuario` where visible!=1 and nombre LIKE \"%{nombre2}%\"", connection);
                var reade = checkInfo.ExecuteReader();
                reade.Read();
                if (reade.HasRows)
                {
                    reade.Close();


                    var registerQuery = new MySqlCommand($"SELECT Nombre,email,cargo FROM `usuario` where visible!=1 and nombre LIKE \"%{nombre2}%\" ", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    Viewus.DataSource = tabla;

                }
                else
                {
                    Viewus.Visible = false;
                    label1.Visible = true;
                    label1.BringToFront();
                }
            }
        }

        private void Reins_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            string Nombre = Viewus.CurrentRow.Cells[0].Value.ToString();
            string Mail = Viewus.CurrentRow.Cells[1].Value.ToString();
            var registerQuery = new MySqlCommand($"UPDATE usuario SET visible = 1 WHERE email=\"{Mail}\";", connection);
            registerQuery.ExecuteNonQuery();
            MessageBox.Show($"Reintegro de Usuario : \"{Nombre}\" se ah realizado con exito", "Usuario Reintegrado");
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("SELECT Nombre,email,cargo FROM `usuario` where visible!=1;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Viewus.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void Modus_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            Modificar_Usuario ModUsu = new Modificar_Usuario();
            AddOwnedForm(ModUsu);
            ModUsu.Correo.Text = Usview.CurrentRow.Cells[1].Value.ToString();
            ModUsu.Nombre.Text = Usview.CurrentRow.Cells[0].Value.ToString();
            ModUsu.DandD = Usview.CurrentRow.Cells[0].Value.ToString();
            ModUsu.Show();

        }

        private void CargoC_CheckedChanged(object sender, EventArgs e)
        {
            CargoU = "Caja";
        }

        private void CargoP_CheckedChanged(object sender, EventArgs e)
        {
            CargoU = "Panadero";
        }

        private void AgUs_Click(object sender, EventArgs e)
        {
            string Cor = EmailUs.Text;
            string Nom = NomUs.Text;
            string contra1 = ContrUs.Text;
            string contra2 = ContrUs.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            var checkInfo = new MySqlCommand($"SELECT Nombre,email,cargo FROM `usuario` where Email=\"{Nom}\"", connection);
            var reade = checkInfo.ExecuteReader();
            reade.Read();
            if (reade.HasRows)
            {

                reade.Close();
                MessageBox.Show("Ya existe un usuario con ese email", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                reade.Close();
                if (contra1 == contra2)
                {
                    try
                    {
                        var registerQuery = new MySqlCommand($"INSERT INTO usuario (Nombre,Contraseña,Email,cargo,visible) VALUES (\"{Nom}\", \"{Class1.HashString(contra1)}\", \"{Cor}\", \"{CargoU}\",1)", connection);
                        registerQuery.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un error al intentar cargar el usuario intentelo nuevamente", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    Correo.Email(Cor, "Registro de Usuario - JO-NA Panaderia",
              $"Se ah registrado su Usuario<br>La contraseña de su usuario es \"{contra1}\"<br><br>Saludos cordiales,<br>TDP<br>Para alguna consulta inserte email de asesor");
                    MessageBox.Show("Registro de Usuario Exitoso", "JO-NA - Panaderia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Las contraseña no son compatibles ", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pb1.BringToFront();
            ContrUs.PasswordChar = '\0';
        }

        private void VUs_Click(object sender, EventArgs e)
        {
            Pancreu.BringToFront();
            ContrUs.PasswordChar = '*';
            ContrUs1.PasswordChar = '*';
        }

        private void Contravis1_Click(object sender, EventArgs e)
        {
            pb2.BringToFront();
            ContrUs1.PasswordChar = '\0';
        }

        private void Pb1_Click(object sender, EventArgs e)
        {
            Contravis.BringToFront();
            ContrUs.PasswordChar = '*';
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            Contravis1.BringToFront();
            ContrUs1.PasswordChar = '*';
        }

        private void Viewus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Reis.Visible = true;
        }
    }
}




