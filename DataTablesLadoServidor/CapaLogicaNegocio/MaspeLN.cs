using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
  public  class MaspeLN
    {
        #region "PATRON SINGLETON"
        private static MaspeLN objMaspe = null;
        private MaspeLN() { }
        public static MaspeLN getInstance()
        {
            if (objMaspe == null)
            {
                objMaspe = new MaspeLN();
            }
            return objMaspe;
        }
        #endregion

        public List<Maspe> ListarPersonalDinamico(int iDisplayLength, int iDisplayStart, int iSortCol_0, string sSortDir_0, string sSearch, string Cip, string Paterno, string Materno, string Nombres, string Dni)
        {
            try
            {
                return MaspeDAO.getInstance().ListarPersonalDinamico(iDisplayLength, iDisplayStart, iSortCol_0, sSortDir_0, sSearch, Cip, Paterno, Materno, Nombres, Dni);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
