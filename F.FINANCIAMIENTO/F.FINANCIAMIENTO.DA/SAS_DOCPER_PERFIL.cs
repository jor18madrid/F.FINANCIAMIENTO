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
    
    public partial class SAS_DOCPER_PERFIL
    {
        public SAS_DOCPER_PERFIL()
        {
            this.SAS_DOCPER_PERFIL_FLUOPE = new HashSet<SAS_DOCPER_PERFIL_FLUOPE>();
            this.SAS_DOCPER_PERFIL_MENU = new HashSet<SAS_DOCPER_PERFIL_MENU>();
        }
    
        public int NRO_DOCUMENTO { get; set; }
        public int ID_PERFIL { get; set; }
        public int ID_SISTEMA { get; set; }
        public string NOMBRE_PERFIL { get; set; }
        public string DESC_PERFIL { get; set; }
        public string TIPO_PERFIL { get; set; }
        public string VIGENTE { get; set; }
        public string API_ESTADO { get; set; }
        public string API_TRANSACCION { get; set; }
        public string USU_CRE { get; set; }
        public System.DateTime FEC_CRE { get; set; }
        public string USU_MOD { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
    
        public virtual SAS_DOC_CABECERA SAS_DOC_CABECERA { get; set; }
        public virtual ICollection<SAS_DOCPER_PERFIL_FLUOPE> SAS_DOCPER_PERFIL_FLUOPE { get; set; }
        public virtual ICollection<SAS_DOCPER_PERFIL_MENU> SAS_DOCPER_PERFIL_MENU { get; set; }
    }
}