using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.FINANCIAMIENTO.DTO
{
   public class GRUPOS_FUENTES_FIN_DTO
    {
        public short GRUPO_FUENTE { get; set; }
        public string DESC_GRUPO_FUENTE { get; set; }
        public string VIGENTE { get; set; }
        public string API_ESTADO { get; set; }
        public string API_TRANSACCION { get; set; }
        public string USU_CRE { get; set; }
        public Nullable<System.DateTime> FEC_CRE { get; set; }
        public string USU_MOD { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }

    }
}
