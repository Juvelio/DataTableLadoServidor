using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Maspe
    {
        public string MASPE_CARNE { get; set; }
        public string MASPE_PATER { get; set; }
        public string MASPE_MATER { get; set; }
        public string MASPE_NOMB { get; set; }

        public int Fila { get; set; }
        public int Total{ get; set; }
        public int Filtro { get; set; }


        public tGrad tGrad { get; set; }
        public tSitua tSitua { get; set; }


        public Maspe()
        {
            this.tGrad = new tGrad();
            this.tSitua = new tSitua();
        }

    }
}
