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
    public partial class Form4 : Form
    {
        String Tipo;
        public Form4()
        {
            InitializeComponent();
            Tipotxt.ReadOnly = true;
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




            connection.Open();

            var checkInfo1 = new MySqlCommand($"Select Rut From distribuidor where Rut=\"{IdD}\"", connection);
            var Reader = checkInfo1.ExecuteReader();
            Reader.Read();
            if (Reader.HasRows)
            {
                Reader.Close();
                var registerQuery = new MySqlCommand($"INSERT INTO producto (Nombre, tipo , precio2 , precio , cantidad , Id_Distribuidores,integrado) VALUES (\"{nombre}\", \"{Tipo}\", \"{precio}\", \"${precio}\", \"{cantidad}\", \"{IdD}\",\"I\")", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show("El Producto se a registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Reader.Close();
                MessageBox.Show("El Distribuidor no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Tipotxt.ReadOnly = true;
            Tipo = "Comestible";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Tipotxt.ReadOnly = true;
            Tipo = "Bebible";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Tipotxt.ReadOnly = false;
            Tipo = Tipotxt.Text;
        }

        private void Precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Precio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void iDd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
