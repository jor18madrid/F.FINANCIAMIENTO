//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace F.FINANCIAMIENTO.DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class SAS_DOCPER_PERFIL_FLUOPE
    {
        public int NRO_DOCUMENTO { get; set; }
        public int ID_PERFIL { get; set; }
        public int ID_OPERACION { get; set; }
        public string VIGENTE { get; set; }
        public string API_ESTADO { get; set; }
        public string API_TRANSACCION { get; set; }
        public string USU_CRE { get; set; }
        public System.DateTime FEC_CRE { get; set; }
        public string USU_MOD { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
    
        public virtual SAS_DOCPER_PERFIL SAS_DOCPER_PERFIL { get; set; }
        public virtual SAS_FLUJOS_OPERACION SAS_FLUJOS_OPERACION { get; set; }
    }
}
