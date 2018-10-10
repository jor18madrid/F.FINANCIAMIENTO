using System;

namespace F.FINANCIAMIENTO.DTO
{
    public class FUENTES_FINANCIAMIENTO_DTO
    {
        public short FUENTE { get; set; }
        public short GRUPO_FUENTE { get; set; }
        public short SUB_GRUPO_FUENTE { get; set; }
        public string DESC_FUENTE { get; set; }
        public string VIGENTE { get; set; }
        public string API_ESTADO { get; set; }
        public string API_TRANSACCION { get; set; }
        public string USU_CRE { get; set; }
        public Nullable<System.DateTime> FEC_CRE { get; set; }
        public string USU_MOD { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
    }
}
