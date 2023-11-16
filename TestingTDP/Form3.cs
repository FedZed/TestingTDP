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
            MtFactu.Visible = false;
            Txtbusq.Visible = false;
            ags.Visible = false;
            Elin.Visible = false;

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
            var checkInfo = new MySqlCommand($"select precio2 from producto WHERE nombre= \"{Nom}\"", connection);
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
                    int Precio = int.Parse(reade["precio2"].ToString());
                    int PrecioTotal = Precio * cant;
                    DtFactura.Rows[n].Cells[2].Value = reade["precio2"].ToString();
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
            MtFactu.Visible = false;
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
    }
}





