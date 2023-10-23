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
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
