using CapaEntidades;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace CapaPresentacion
{
    /// <summary>
    /// Descripción breve de ListarPersonal
    /// </summary>
    public class ListarPersonal : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int iDisplayLength = int.Parse(context.Request["iDisplayLength"]);
            int iDisplayStart = int.Parse(context.Request["iDisplayStart"]);
            int iSortCol_0 = int.Parse(context.Request["iSortCol_0"]);
            string sSortDir_0 = context.Request["sSortDir_0"];
            string sSearch = context.Request["sSearch"];


            string Cip = context.Request["Cip"];
            string Paterno = context.Request["Paterno"];
            string Materno = context.Request["Materno"];
            string Nombres = context.Request["Nombres"];
            string Dni = context.Request["Dni"];


            List<Maspe> Lista = null;
            try
            {
                Lista = MaspeLN.getInstance().ListarPersonalDinamico(iDisplayLength, iDisplayStart, iSortCol_0, sSortDir_0, sSearch, Cip, Paterno, Materno, Nombres, Dni);
            }
            catch (Exception ex)
            {
                Lista = new List<Maspe>();
            }

            var result = new
            {
                iTotalRecords = (Lista.Count == 0) ? 0 : Lista[0].Total,
                iTotalDisplayRecords = (Lista.Count == 0) ? 0 : Lista[0].Filtro,
                aaData = Lista
            };
            JavaScriptSerializer js = new JavaScriptSerializer();
            context.Response.Write(js.Serialize(result));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}