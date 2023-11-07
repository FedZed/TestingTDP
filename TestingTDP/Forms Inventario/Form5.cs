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
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            InitializeComponent();
            var checkInfo = new MySqlCommand($"select Id_producto,Nombre from producto WHERE integrado !=\"X\"", connection);
            connection.Open();
            MySqlDataReader reade;
            reade = checkInfo.ExecuteReader();
            if (reade.Read())
            {
                while (reade.Read())
                {
                    comboBox1.Items.Add(reade.GetString("Nombre"));
                }
                comboBox1.SelectedIndex = 0;
            }
            reade.Read();
        }
        public class MainFunc
        {
            public static MySqlConnection? connection;
            public static string connString = "server=localhost;database=tdp;uid=root;pwd=\"\"";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string edit = comboBox1.SelectedItem.ToString();
            string edit1 = txtCant.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"UPDATE producto SET Cantidad=Cantidad + \"{edit1}\" WHERE Nombre=\"{edit}\";", connection);
            registerQuery.ExecuteNonQuery();
            MessageBox.Show("Se agrego el stock de forma correcta", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
