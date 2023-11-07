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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestingTDP
{
    public partial class agstock : Form
    {
        public agstock()
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            InitializeComponent();
            var checkInfo = new MySqlCommand($"select IdM,Nombre from materia_prima WHERE visible !=\"1\"", connection);
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
        private void agstock_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato = comboBox1.SelectedItem.ToString();

            string edit1 = txtCant.Text;
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);

            connection.Open();
            var registerQuery = new MySqlCommand($"UPDATE materia_prima SET Cantidad=Cantidad + \"{edit1}\" WHERE Nombre=\"{dato}\";", connection);
            registerQuery.ExecuteNonQuery();
            MessageBox.Show("Se agrego el stock de forma correcta", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
