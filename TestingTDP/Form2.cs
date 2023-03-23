﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestingTDP
{

    public partial class Form2 : Form
    {
        string Tipo;
        public Form2()
        {
            InitializeComponent();
            p3.BringToFront();
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);


            try
            {
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
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre = Nombre.Text;
            string id_producto = Id_producto.Text;

            string precio = Precio.Text;
            string cantidad = Cantidad.Text;



            connection.Open();
            var checkInfo = new MySqlCommand($"SELECT id_producto FROM producto WHERE id_producto =\"{id_producto}\"", connection);
            var reade = checkInfo.ExecuteReader();
            reade.Read();
            if (reade.HasRows)
            {
                reade.Close();
                MessageBox.Show("El Producto ya existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                reade.Close();

                var registerQuery = new MySqlCommand($"INSERT INTO producto (Nombre, id_producto , tipo , precio , cantidad) VALUES (\"{nombre}\", \"{id_producto}\", \"{Tipo}\", \"{precio}\", \"{cantidad}\")", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show("El Producto se a registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainFunc.connString);
            string nombre2 = Named.Text;

            try
            {



                connection.Open();
                var registerQuery = new MySqlCommand($"select * from producto WHERE Nombre =\"{nombre2}\"", connection);
                registerQuery.ExecuteNonQuery();
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = registerQuery;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dt1.DataSource = tabla;

            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
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

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Tipo = "Otro";
        }
    }
}