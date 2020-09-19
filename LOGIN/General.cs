using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using CONCELL.Datos;
namespace CONCELL
{
    class General
    {
        private static string DBSERVER = "127.0.0.1";
        private static string DBNAME = "concell";
        private static string DBUSER = "root";
        private static string DBPASSWORD = "toor";
        private static MySqlConnection CurrConnection = null;
        public static cUsuario CurrUsuario = null;

         ~General()
        {
            General.CloseConnection();
        }
         public static void OpenConnection()
         {
             try
             {
                 if (General.CurrConnection == null)
                 {
                     General.CurrConnection = new MySqlConnection("Database=" + General.DBNAME + "; Data Source=" + General.DBSERVER + "; User Id= " + General.DBUSER + "; Password=" + General.DBPASSWORD + "");
                 }
                 if (General.CurrConnection.State == ConnectionState.Closed)
                 {
                     General.CurrConnection.Open();
                 }
             }
             catch (Exception exp)
             {
                 MessageBox.Show("Error al conectarse a la base de datos. " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
         public static MySqlConnection GetConnection()
         {
             return General.CurrConnection;
         }
         public static void CloseConnection()
         {
             try
             {
                 if (General.CurrConnection != null && General.CurrConnection.State == ConnectionState.Open)
                     General.CurrConnection.Close();
             }
             catch (Exception exp)
             {
                 MessageBox.Show("Error al cerrar la conexión. " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
    }
}
