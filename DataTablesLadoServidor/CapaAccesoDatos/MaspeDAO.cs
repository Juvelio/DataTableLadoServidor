using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{

  public  class MaspeDAO
    {

        #region "PATRON SINGLETON"
        private static MaspeDAO daoMaspe = null;
        private MaspeDAO() { }
        public static MaspeDAO getInstance()
        {
            if (daoMaspe == null)
            {
                daoMaspe = new MaspeDAO();
            }
            return daoMaspe;
        }
        #endregion

        public List<Maspe> ListarPersonalDinamico(int iDisplayLength, int iDisplayStart, int iSortCol_0, string sSortDir_0, string sSearch, string Cip, string Paterno, string Materno, string Nombres, string Dni)
        {
            List<Maspe> Lista = new List<Maspe>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("Generico_BuscarPersonal", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DisplayLength", iDisplayLength);
                cmd.Parameters.AddWithValue("@DisplayStart", iDisplayStart);
                cmd.Parameters.AddWithValue("@SortCol", iSortCol_0);
                cmd.Parameters.AddWithValue("@SortDir", sSortDir_0);
                cmd.Parameters.AddWithValue("@Search", sSearch);

                cmd.Parameters.AddWithValue("@Cip", Cip);
                cmd.Parameters.AddWithValue("@ApPaterno", Paterno);
                cmd.Parameters.AddWithValue("@ApMaterno", Materno);
                cmd.Parameters.AddWithValue("@Nombres", Nombres);
                cmd.Parameters.AddWithValue("@Dni", Dni);

                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Maspe objPersonal = new Maspe();
                    objPersonal.Fila = Convert.ToInt32(dr["RowNum"].ToString());
                    objPersonal.MASPE_CARNE = dr["MASPE_CARNE"].ToString();
                    objPersonal.tGrad.TGRAD_DES = dr["TGRAD_DES"].ToString();
                    objPersonal.tSitua.TSITUA_DESL = dr["TSITUA_DESL"].ToString();
                    objPersonal.MASPE_PATER = dr["MASPE_PATER"].ToString();
                    objPersonal.MASPE_PATER = dr["MASPE_PATER"].ToString();
                    objPersonal.MASPE_MATER = dr["MASPE_MATER"].ToString();
                    objPersonal.MASPE_NOMB = dr["MASPE_NOMB"].ToString();
                    objPersonal.Total = Convert.ToInt32(dr["Total"].ToString());
                    objPersonal.Filtro = Convert.ToInt32(dr["TotalCount"].ToString());

                    Lista.Add(objPersonal);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return Lista;
        }


    }
}
