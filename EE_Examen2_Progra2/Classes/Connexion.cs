using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EE_Examen2_Progra2.Classes
{
    public class Connexion
    {
        public static SqlConnection getConnection()
        {
            string cnxStr = ConfigurationManager.ConnectionStrings["cnxExamen"].ConnectionString;
            SqlConnection cnx = new SqlConnection(cnxStr);
            cnx.Open();

            return cnx;
        }

        public static void closeConnection(SqlConnection cnx)
        {
            cnx.Close();
        }
    }
}