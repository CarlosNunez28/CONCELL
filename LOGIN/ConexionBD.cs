﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CONCELL
{
    class ConexionBD
    {
        public static MySqlConnection conexion()
        {
            string servidor = "127.0.0.1";
            string bd = "concell";
            string usuario = "root";
            string password = "";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id= " + usuario + "; Password=" + password + "";

            try
            {
                MySqlConnection conectarbase = new MySqlConnection(cadenaConexion);
                return conectarbase;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
            
    }
}
