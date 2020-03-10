using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        #region "PATRON SINGLETON"
        private static Conexion conexion = null;
        private Conexion() { }
        public static Conexion getInstance()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
        #endregion

        //CONEXION DB PRINCIAL
        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = ObtenerCadenaConexion();
            return conexion;
        }
        public String ObtenerCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["ConexionBaseDatos"].ConnectionString;
        }                       
    }
}
