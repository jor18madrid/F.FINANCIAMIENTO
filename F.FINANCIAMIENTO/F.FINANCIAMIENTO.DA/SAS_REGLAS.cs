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
    
    public partial class SAS_REGLAS
    {
        public SAS_REGLAS()
        {
            this.SAS_FLUJOS_OPE_REGLA = new HashSet<SAS_FLUJOS_OPE_REGLA>();
            this.SAS_REGLAS_CONDICIONES = new HashSet<SAS_REGLAS_CONDICIONES>();
        }
    
        public int ID_REGLA { get; set; }
        public int ID_SISTEMA { get; set; }
        public string NOMBRE_REGLA { get; set; }
        public string DESC_REGLA { get; set; }
        public string VIGENTE { get; set; }
        public string API_ESTADO { get; set; }
        public string API_TRANSACCION { get; set; }
        public string USU_CRE { get; set; }
        public System.DateTime FEC_CRE { get; set; }
        public string USU_MOD { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
    
        public virtual ICollection<SAS_FLUJOS_OPE_REGLA> SAS_FLUJOS_OPE_REGLA { get; set; }
        public virtual SAS_SISTEMAS SAS_SISTEMAS { get; set; }
        public virtual ICollection<SAS_REGLAS_CONDICIONES> SAS_REGLAS_CONDICIONES { get; set; }
    }
}
