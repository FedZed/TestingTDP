using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace TestingTDP
{
    internal static class Program
    {

        public class MainFunc
        {
            public static MySqlConnection? connection;
            public static string connString = "server=localhost;database=tdp;uid=root;pwd=\"\"";
            

        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}