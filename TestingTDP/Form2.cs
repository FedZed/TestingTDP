using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestingTDP
{

    public partial class Form2 : Form
    {
        string Tipo2;
        string Tipo;
        string Tipo1;
        String Cargo;
        public Form2()
        {
            InitializeComponent();
            p3.BringToFront();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = connection;
            comando.CommandText = ("select nombre,cantidad,precio from producto;");

            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            adaptar.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            Produ.DataSource = tabla;


        }
        public class MainFunc
        {
            public static MySqlConnection? connection;
            public static string connString = "server=localhost;database=tdp;uid=root;pwd=\"\"";




        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void C1_Click(object sender, EventArgs e)
        {

            p3.BringToFront();
        }

        private void c2_Click(object sender, EventArgs e)
        {
            p4.BringToFront();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = connection;
            comando.CommandText = ("select * from producto;");

            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            adaptar.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            dt1.DataSource = tabla;


        }

        private void dt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);


            try
            {
                connection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select Nombre, id_producto , tipo , precio , cantidad , Id_Distribuidores from producto;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dt1.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p4.BringToFront();
            panel3.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre = Nombre.Text;

            string precio = Precio.Text;
            string cantidad = Cantidad.Text;
            string IdD = txtidd.Text;




            connection.Open();

            var checkInfo1 = new MySqlCommand($"Select Rut From distribuidor where Rut=\"{IdD}\"", connection);
            var Reader = checkInfo1.ExecuteReader();
            Reader.Read();
            if (Reader.HasRows)
            {
                Reader.Close();
                var registerQuery = new MySqlCommand($"INSERT INTO producto (Nombre, tipo , precio2 , precio , cantidad , Id_Distribuidores) VALUES (\"{nombre}\", \"{Tipo}\", \"{precio}\", \"${precio}\", \"{cantidad}\", \"{IdD}\")", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show("El Producto se a registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                p4.BringToFront();
            }
            else
            {
                Reader.Close();
                MessageBox.Show("El Distribuidor no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void button4_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            string nombre2 = Named.Text;
            var checkInfo = new MySqlCommand($"select Nombre, id_producto , tipo , precio , cantidad , Id_Distribuidores  from producto WHERE Nombre =\"{nombre2}\"", connection);
            var reade = checkInfo.ExecuteReader();
            reade.Read();
            if (reade.HasRows)
            {
                reade.Close();


                var registerQuery = new MySqlCommand($"select Nombre, id_producto , tipo , precio , cantidad , Id_Distribuidores  from producto WHERE Nombre =\"{nombre2}\"", connection);
                registerQuery.ExecuteNonQuery();
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = registerQuery;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dt1.DataSource = tabla;

            }
            else
            {
                reade.Close();
                var checkInfo1 = new MySqlCommand($"select Nombre, id_producto , tipo , precio , cantidad , Id_Distribuidores  from producto WHERE id_producto =\"{nombre2}\"", connection);
                var reader = checkInfo1.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    reader.Close();

                    var registerQuery = new MySqlCommand($"select Nombre, id_producto , tipo , precio , cantidad , Id_Distribuidores  from producto WHERE id_producto =\"{nombre2}\"", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    dt1.DataSource = tabla;



                }
                else
                {
                    reader.Close();
                    var checkInfo2 = new MySqlCommand($"select Nombre, id_producto , tipo , precio , cantidad , Id_Distribuidores  from producto WHERE id_Distribuidores =\"{nombre2}\"", connection);
                    var reader1 = checkInfo2.ExecuteReader();
                    reader1.Read();
                    if (reader1.HasRows)
                    {
                        reader1.Close();



                        var registerQuery = new MySqlCommand($"select Nombre, id_producto , tipo , precio , cantidad , Id_Distribuidores  from producto WHERE id_Distribuidores =\"{nombre2}\"", connection);
                        registerQuery.ExecuteNonQuery();
                        MySqlDataAdapter adaptar = new MySqlDataAdapter();
                        adaptar.SelectCommand = registerQuery;
                        DataTable tabla = new DataTable();
                        adaptar.Fill(tabla);
                        dt1.DataSource = tabla;



                    }
                    else
                    {
                        reader1.Close();
                        var checkInfo3 = new MySqlCommand($"select Nombre, id_producto , tipo , precio , cantidad , Id_Distribuidores  from producto WHERE Tipo =\"{nombre2}\"", connection);
                        var reader2 = checkInfo3.ExecuteReader();
                        reader2.Read();
                        if (reader2.HasRows)
                        {
                            reader2.Close();
                            var registerQuery = new MySqlCommand($"select Nombre, id_producto , tipo , precio , cantidad , Id_Distribuidores  from producto WHERE Tipo =\"{nombre2}\"", connection);
                            registerQuery.ExecuteNonQuery();
                            MySqlDataAdapter adaptar = new MySqlDataAdapter();
                            adaptar.SelectCommand = registerQuery;
                            DataTable tabla = new DataTable();
                            adaptar.Fill(tabla);
                            dt1.DataSource = tabla;

                        }
                        else
                        {
                            reader2.Close();
                            MessageBox.Show("No existe un Producto con esas caracterizticas", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }


                }

            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Tipo = "Comida";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Tipo = "Bebida";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nombre1 = Named.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"DELETE from producto WHERE Nombre =\"{nombre1}\"", connection);
            registerQuery.ExecuteNonQuery();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select * from producto;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dt1.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Tipo = "Otro";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);


            try
            {
                connection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select Nombre,Cargo,Cedula from usuario;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                DtUser.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            {
                MySqlConnection connection = new MySqlConnection(MainFunc.connString);
                string nombre = TextName.Text;
                string passwd = TextPass.Text;
                string c1 = textCedula.Text;
                int Cedula;
                Cedula = int.Parse(c1);


                connection.Open();
                var checkInfo = new MySqlCommand($"SELECT Cedula FROM usuario WHERE Cedula =\"{Cedula}\"", connection);
                var reader = checkInfo.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("El Usuario ya existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    reader.Close();
                    var registerQuery = new MySqlCommand($"INSERT INTO usuario (Nombre, Cargo, Contraseña, Cedula) VALUES (\"{nombre}\",\"{Cargo}\",SHA(\"{passwd}\"),\"{Cedula}\")", connection);
                    registerQuery.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {

                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = connection;
                        comando.CommandText = ("select Nombre,Cargo,Cedula from usuario;");

                        MySqlDataAdapter adaptar = new MySqlDataAdapter();
                        adaptar.SelectCommand = comando;
                        DataTable tabla = new DataTable();
                        adaptar.Fill(tabla);
                        DtUser.DataSource = tabla;

                    }
                    catch (Exception b)
                    {

                        MessageBox.Show(b.Message + b.StackTrace);
                    }

                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Cargo = "Panadero";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Cargo = "Caja";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Cargo = "Encargado_Inventario";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string Busca = textBus.Text;

            try
            {



                connection.Open();
                var registerQuery = new MySqlCommand($"select Nombre,Cargo,Cedula from Usuario WHERE Cedula =\"{Busca}\"", connection);
                registerQuery.ExecuteNonQuery();
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = registerQuery;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                DtUser.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Cedula = textBus.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"DELETE from usuario WHERE cedula =\"{Cedula}\"", connection);
            registerQuery.ExecuteNonQuery();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select Nombre,Cargo,Cedula from usuario;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                DtUser.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            try
            {
                connection.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select Nombre,Cargo,Cedula from usuario;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                DtUser.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string edit = TxtEditar.Text;
            string edit1 = txtnom.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"UPDATE producto SET Nombre=\"{edit1}\" WHERE id_producto=\"{edit}\";", connection);
            registerQuery.ExecuteNonQuery();
            p4.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string edit = TxtEditar.Text;

            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"UPDATE producto SET Tipo=\"{Tipo1}\" WHERE id_producto=\"{edit}\";", connection);
            registerQuery.ExecuteNonQuery();
            p4.BringToFront();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Tipo1 = "Comestible";
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            Tipo1 = "Panaderia";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            Tipo1 = "Bebida";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Tipo1 = "Otro";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string edit = TxtEditar.Text;
            string edit1 = txtpre.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"UPDATE producto SET precio=\"{edit1}\" WHERE id_producto=\"{edit}\";", connection);
            registerQuery.ExecuteNonQuery();

            p4.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Pan1.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Pan2.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pan3.BringToFront();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string edit = TxtEditar.Text;
            string edit1 = txtcan.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"UPDATE producto SET cantidad=\"{edit1}\" WHERE id_producto=\"{edit}\";", connection);
            registerQuery.ExecuteNonQuery();

            p4.BringToFront();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string edit = TxtEditar.Text;
            string Editar = IdDis.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            var checkInfo1 = new MySqlCommand($"Select Rut From distribuidor where Rut=\"{Editar}\"", connection);
            var Reader = checkInfo1.ExecuteReader();
            Reader.Read();
            if (Reader.HasRows)
            {
                var registerQuery = new MySqlCommand($"UPDATE producto SET id_Distribuidores=\"{Editar}\" WHERE id_producto=\"{edit}\";", connection);
                registerQuery.ExecuteNonQuery();

                p4.BringToFront();
            }
            else
            {
                Reader.Close();
                MessageBox.Show("El Distribuidor no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            pan4.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pan5.BringToFront();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            p4.BringToFront();
            Pan.BringToFront();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = connection;
            comando.CommandText = ("select * from distribuidor;");

            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            adaptar.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            DatDis.DataSource = tabla;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = connection;
            comando.CommandText = ("select * from distribuidor;");

            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            adaptar.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            DatDis.DataSource = tabla;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            string Buscar = txtbusca.Text;
            var checkInfo = new MySqlCommand($"select * from distribuidor WHERE Nombre =\"{Buscar}\"", connection);
            var reade = checkInfo.ExecuteReader();
            reade.Read();
            if (reade.HasRows)
            {
                reade.Close();


                var registerQuery = new MySqlCommand($"select * from distribuidor WHERE Nombre =\"{Buscar}\"", connection);
                registerQuery.ExecuteNonQuery();
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = registerQuery;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                DatDis.DataSource = tabla;

            }
            else
            {
                reade.Close();
                var checkInfo1 = new MySqlCommand($"select * from distribuidor WHERE Rut =\"{Buscar}\"", connection);
                var reader = checkInfo1.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    reader.Close();

                    var registerQuery = new MySqlCommand($"select * from distribuidor WHERE Rut =\"{Buscar}\"", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    DatDis.DataSource = tabla;



                }
                else
                {
                    reader.Close();
                    var checkInfo2 = new MySqlCommand($"select * from distribuidor WHERE Telefono =\"{Buscar}\"", connection);
                    var reader1 = checkInfo2.ExecuteReader();
                    reader1.Read();
                    if (reader1.HasRows)
                    {
                        reader1.Close();



                        var registerQuery = new MySqlCommand($"select * from distribuidor WHERE Telefono =\"{Buscar}\"", connection);
                        registerQuery.ExecuteNonQuery();
                        MySqlDataAdapter adaptar = new MySqlDataAdapter();
                        adaptar.SelectCommand = registerQuery;
                        DataTable tabla = new DataTable();
                        adaptar.Fill(tabla);
                        DatDis.DataSource = tabla;



                    }
                    else
                    {
                        reader1.Close();
                        var checkInfo3 = new MySqlCommand($"select * from distribuidor WHERE Direccion =\"{Buscar}\"", connection);
                        var reader2 = checkInfo3.ExecuteReader();
                        reader2.Read();
                        if (reader2.HasRows)
                        {
                            reader2.Close();
                            var registerQuery = new MySqlCommand($"select * from distribuidor WHERE Direccion =\"{Buscar}\"", connection);
                            registerQuery.ExecuteNonQuery();
                            MySqlDataAdapter adaptar = new MySqlDataAdapter();
                            adaptar.SelectCommand = registerQuery;
                            DataTable tabla = new DataTable();
                            adaptar.Fill(tabla);
                            DatDis.DataSource = tabla;

                        }
                        else
                        {
                            reader2.Close();
                            MessageBox.Show("No existe un Distribuidor con esos Datos", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }


                }

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MatPan.BringToFront();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = connection;
            comando.CommandText = ("select * from materia_prima;");

            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            adaptar.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            DtMatPri.DataSource = tabla;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = connection;
            comando.CommandText = ("select * from materia_prima;");

            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            adaptar.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptar.Fill(tabla);
            DtMatPri.DataSource = tabla;
        }

        private void buss_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            string Buscar = textbusca.Text;
            var checkInfo = new MySqlCommand($"select * from materia_prima WHERE Nombre =\"{Buscar}\"", connection);
            var reade = checkInfo.ExecuteReader();
            reade.Read();
            if (reade.HasRows)
            {
                reade.Close();


                var registerQuery = new MySqlCommand($"select * from materia_prima WHERE Nombre =\"{Buscar}\"", connection);
                registerQuery.ExecuteNonQuery();
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = registerQuery;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                DtMatPri.DataSource = tabla;

            }
            else
            {
                reade.Close();
                var checkInfo1 = new MySqlCommand($"select * from materia_prima WHERE IdM =\"{Buscar}\"", connection);
                var reader = checkInfo1.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    reader.Close();

                    var registerQuery = new MySqlCommand($"select * from materia_prima WHERE IdM =\"{Buscar}\"", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    DtMatPri.DataSource = tabla;



                }
                else
                {
                    reader.Close();
                    var checkInfo2 = new MySqlCommand($"select * from materia_prima WHERE tipo =\"{Buscar}\"", connection);
                    var reader1 = checkInfo2.ExecuteReader();
                    reader1.Read();
                    if (reader1.HasRows)
                    {
                        reader1.Close();



                        var registerQuery = new MySqlCommand($"select * from materia_prima WHERE tipo =\"{Buscar}\"", connection);
                        registerQuery.ExecuteNonQuery();
                        MySqlDataAdapter adaptar = new MySqlDataAdapter();
                        adaptar.SelectCommand = registerQuery;
                        DataTable tabla = new DataTable();
                        adaptar.Fill(tabla);
                        DtMatPri.DataSource = tabla;



                    }
                    else
                    {
                        reader1.Close();
                        var checkInfo3 = new MySqlCommand($"select * from distribuidor WHERE IdD =\"{Buscar}\"", connection);
                        var reader2 = checkInfo3.ExecuteReader();
                        reader2.Read();
                        if (reader2.HasRows)
                        {
                            reader2.Close();
                            var registerQuery = new MySqlCommand($"select * from distribuidor WHERE IdD =\"{Buscar}\"", connection);
                            registerQuery.ExecuteNonQuery();
                            MySqlDataAdapter adaptar = new MySqlDataAdapter();
                            adaptar.SelectCommand = registerQuery;
                            DataTable tabla = new DataTable();
                            adaptar.Fill(tabla);
                            DtMatPri.DataSource = tabla;

                        }
                        else
                        {
                            reader2.Close();
                            MessageBox.Show("No existe una Materia Prima con esos Datos", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }


                }

            }
        }

        private void btnañadira_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {


            PanNC.BringToFront();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string edit = UserName.Text;
            string edit1 = NewCotraseña.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"UPDATE usuario SET Contraseña=SHA(\"{edit1}\") WHERE Nombre=\"{edit}\";", connection);
            registerQuery.ExecuteNonQuery();
            panel4.BringToFront();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string nombre1 = textbusca.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"DELETE from materia_prima WHERE Nombre =\"{nombre1}\"", connection);
            registerQuery.ExecuteNonQuery();
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select * from materia_prima;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                DtMatPri.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Harina";
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Levadura";
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Sal";
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Grasa";
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Azucar";
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Gas";
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Masa";
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Mejorador de Harina";
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Crema Pastelera";
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Fondan";

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Chocolate";
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Coco Rallado";
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Dulce de Leche";
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Margarina de Hogaldre";
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Dulce de Membrillo";
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Fecula de Maiz";
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Huevo";
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Polvo De Hornear";
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Margarina De Masa";
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            Tipo2 = "Otros";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre = TextNomMat.Text;
            string cantidad = textCanti.Text;
            string IdD = TextIdDIS.Text;




            connection.Open();

            var checkInfo1 = new MySqlCommand($"Select Rut From distribuidor where Rut=\"{IdD}\"", connection);
            var Reader = checkInfo1.ExecuteReader();
            Reader.Read();
            if (Reader.HasRows)
            {
                Reader.Close();
                var registerQuery = new MySqlCommand($"INSERT INTO materia_prima (Nombre,tipo,Cantidad,IdD) VALUES (\"{nombre}\", \"{Tipo2}\", \"{cantidad}\", \"{IdD}\")", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show("El Producto se a registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MatPan.BringToFront();
                try
                {

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = connection;
                    comando.CommandText = ("select * from materia_prima;");

                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    DtMatPri.DataSource = tabla;

                }
                catch (Exception b)
                {

                    MessageBox.Show(b.Message + b.StackTrace);
                }
            }
            else
            {
                Reader.Close();
                MessageBox.Show("El Distribuidor no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel6.BringToFront();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = ("select nombre,cantidad,precio from producto;");

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

        private void button33_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            connection.Open();
            string nombre2 = Idpro.Text;
            var checkInfo = new MySqlCommand($"select nombre,cantidad,precio from producto WHERE Nombre =\"{nombre2}\"", connection);
            var reade = checkInfo.ExecuteReader();
            reade.Read();
            if (reade.HasRows)
            {
                reade.Close();


                var registerQuery = new MySqlCommand($"select nombre,cantidad,precio from producto WHERE Nombre =\"{nombre2}\"", connection);
                registerQuery.ExecuteNonQuery();
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = registerQuery;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                Produ.DataSource = tabla;

            }
            else
            {
                reade.Close();
                var checkInfo1 = new MySqlCommand($"select nombre,cantidad,precio from producto WHERE id_producto =\"{nombre2}\"", connection);
                var reader = checkInfo1.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    reader.Close();

                    var registerQuery = new MySqlCommand($"select nombre,cantidad,precio from producto WHERE id_producto =\"{nombre2}\"", connection);
                    registerQuery.ExecuteNonQuery();
                    MySqlDataAdapter adaptar = new MySqlDataAdapter();
                    adaptar.SelectCommand = registerQuery;
                    DataTable tabla = new DataTable();
                    adaptar.Fill(tabla);
                    Produ.DataSource = tabla;



                }
                else
                {
                    reader.Close();
                    var checkInfo2 = new MySqlCommand($"select nombre,cantidad,precio from producto WHERE id_Distribuidores =\"{nombre2}\"", connection);
                    var reader1 = checkInfo2.ExecuteReader();
                    reader1.Read();
                    if (reader1.HasRows)
                    {
                        reader1.Close();



                        var registerQuery = new MySqlCommand($"select nombre,cantidad,precio from producto WHERE id_Distribuidores =\"{nombre2}\"", connection);
                        registerQuery.ExecuteNonQuery();
                        MySqlDataAdapter adaptar = new MySqlDataAdapter();
                        adaptar.SelectCommand = registerQuery;
                        DataTable tabla = new DataTable();
                        adaptar.Fill(tabla);
                        Produ.DataSource = tabla;



                    }
                    else
                    {
                        reader1.Close();
                        var checkInfo3 = new MySqlCommand($"select nombre,cantidad,precio from producto WHERE Tipo =\"{nombre2}\"", connection);
                        var reader2 = checkInfo3.ExecuteReader();
                        reader2.Read();
                        if (reader2.HasRows)
                        {
                            reader2.Close();
                            var registerQuery = new MySqlCommand($"select nombre,cantidad,precio from producto WHERE Tipo =\"{nombre2}\"", connection);
                            registerQuery.ExecuteNonQuery();
                            MySqlDataAdapter adaptar = new MySqlDataAdapter();
                            adaptar.SelectCommand = registerQuery;
                            DataTable tabla = new DataTable();
                            adaptar.Fill(tabla);
                            Produ.DataSource = tabla;

                        }
                        else
                        {
                            reader2.Close();
                            MessageBox.Show("No existe un Producto con esas caracterizticas", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }


                }

            }

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre = Idpro.Text;
            string precio = Preci.Text;
            string cantidad = Cant.Text;




            connection.Open();

            var checkInfo = new MySqlCommand($"SELECT nombre FROM producto WHERE nombre =\"{nombre}\"", connection);
            var reade = checkInfo.ExecuteReader();
            reade.Read();

            if (reade.HasRows)
            {
                reade.Close();
                var checkInfo1 = new MySqlCommand($"Select cantidad From producto where cantidad>=\"{cantidad}\"", connection);
                var Reader = checkInfo1.ExecuteReader();
                Reader.Read();


                if (Reader.HasRows)
                {
                    Reader.Close();
                    reade.Close();
                    var checkInfo2 = new MySqlCommand($"Select precio From producto where precio2=\"{precio}\"", connection);
                    var Reader1 = checkInfo2.ExecuteReader();
                    Reader1.Read();


                    if (Reader1.HasRows)
                    {
                        int n = DtFactu.Rows.Add();

                        DtFactu.Rows[n].Cells[0].Value = Idpro.Text;
                        DtFactu.Rows[n].Cells[1].Value = Cant.Text;
                        DtFactu.Rows[n].Cells[2].Value = Preci.Text;

                        Idpro.Text = "";
                        Cant.Text = "";
                        Preci.Text = "";
                        int Pre = Int32.Parse(cantidad);
                        int Pre2 = Int32.Parse(precio);
                        int res = Pre * Pre2;
                        double res2 = res * 0.22;
                        double res3 = res + res2;
                        Lbls.Text = "Subtotal: $" + res;
                        lbls2.Text = "Total: $" + res3;

                    }
                    else
                    {
                        reade.Close();
                        MessageBox.Show("El precio asignado no es el mismo que el de su respectiva tabla", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    reade.Close();
                    MessageBox.Show("La cantidad del producto es mayor a la cantidad en stock", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                reade.Close();
                MessageBox.Show("El Nombre del producto es incorrecto", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void DtFactu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void p3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbls_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"UPDATE `producto` SET cantidad=cantidad-23  WHERE nombre=azul", connection);
        }
    }
}

