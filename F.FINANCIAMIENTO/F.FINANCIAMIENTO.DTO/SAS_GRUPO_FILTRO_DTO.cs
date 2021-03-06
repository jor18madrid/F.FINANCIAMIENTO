﻿using System;

namespace F.FINANCIAMIENTO.DTO
{
    public class SAS_GRUPO_FILTRO_DTO
    {
        public int ID_GRUPO { get; set; }
        public int ID_SISTEMA { get; set; }
        public string NOMBRE_GRUPO { get; set; }
        public string DESC_GRUPO { get; set; }
        public string VIGENTE { get; set; }
        public string API_ESTADO { get; set; }
        public string API_TRANSACCION { get; set; }
        public string USU_CRE { get; set; }
        public System.DateTime FEC_CRE { get; set; }
        public string USU_MOD { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
    }
}
