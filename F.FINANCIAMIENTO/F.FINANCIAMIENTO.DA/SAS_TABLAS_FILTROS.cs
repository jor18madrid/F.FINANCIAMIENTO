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
    
    public partial class SAS_TABLAS_FILTROS
    {
        public int ID_SISTEMA { get; set; }
        public int ID_COLUMNA { get; set; }
        public int ID_FILTRO { get; set; }
        public string VIGENTE { get; set; }
        public string API_ESTADO { get; set; }
        public string API_TRANSACCION { get; set; }
        public string USU_CRE { get; set; }
        public System.DateTime FEC_CRE { get; set; }
        public string USU_MOD { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
    
        public virtual SAS_DICCIONARIO_FILTROS SAS_DICCIONARIO_FILTROS { get; set; }
        public virtual SAS_SISTEMAS SAS_SISTEMAS { get; set; }
        public virtual SAS_TABLAS_COLUMNAS SAS_TABLAS_COLUMNAS { get; set; }
    }
}
