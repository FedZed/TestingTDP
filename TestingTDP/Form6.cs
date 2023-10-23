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
                var registerQuery = new MySqlCommand($"UPDATE producto SET Nombre=\"{nombre}\",tipo=\"{Tipo}\",precio2=\"{precio}\",Precio=\"${precio}\",cantidad=\"{cantidad}\",id_Distribuidores=\"{IdD}\" WHERE id_producto=\"{datos}\"", connection);

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

    }
}
