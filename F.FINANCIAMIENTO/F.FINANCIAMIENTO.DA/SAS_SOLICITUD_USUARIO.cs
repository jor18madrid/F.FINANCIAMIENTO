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
    
    public partial class SAS_SOLICITUD_USUARIO
    {
        public SAS_SOLICITUD_USUARIO()
        {
            this.SAS_SOLUSR_PERFIL = new HashSet<SAS_SOLUSR_PERFIL>();
            this.SAS_SOLUSR_AUDITORIA = new HashSet<SAS_SOLUSR_AUDITORIA>();
        }
    
        public int NRO_DOCUMENTO { get; set; }
        public int ID_SISTEMA { get; set; }
        public string USUARIO { get; set; }
        public string TIPO_SOLICITUD { get; set; }
        public System.DateTime FECHA_ELABORACION { get; set; }
        public Nullable<System.DateTime> FECHA_DESHABILITACION { get; set; }
        public Nullable<System.DateTime> FECHA_HABILITACION { get; set; }
        public string API_ESTADO { get; set; }
        public string API_TRANSACCION { get; set; }
        public string USU_CRE { get; set; }
        public System.DateTime FEC_CRE { get; set; }
        public string USU_MOD { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
        public Nullable<int> ID_GRUPO { get; set; }
        public string RESUMEN_OPERACION { get; set; }
        public string USUARIO_SOLICITACION { get; set; }
        public Nullable<System.DateTime> FECHA_SOLICITACION { get; set; }
        public string USUARIO_APROBACION { get; set; }
        public Nullable<System.DateTime> FECHA_APROBACION { get; set; }
    
        public virtual ICollection<SAS_SOLUSR_PERFIL> SAS_SOLUSR_PERFIL { get; set; }
        public virtual ICollection<SAS_SOLUSR_AUDITORIA> SAS_SOLUSR_AUDITORIA { get; set; }
    }
}
