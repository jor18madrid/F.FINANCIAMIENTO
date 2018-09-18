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
    
    public partial class SAS_SISTEMAS
    {
        public SAS_SISTEMAS()
        {
            this.SAS_ACCESOS_PERFILES = new HashSet<SAS_ACCESOS_PERFILES>();
            this.SAS_ACCIONES = new HashSet<SAS_ACCIONES>();
            this.SAS_CONDICIONES = new HashSet<SAS_CONDICIONES>();
            this.SAS_CORREO_FORMATO = new HashSet<SAS_CORREO_FORMATO>();
            this.SAS_DICCIONARIO_ETAPAS = new HashSet<SAS_DICCIONARIO_ETAPAS>();
            this.SAS_DICCIONARIO_FILTROS = new HashSet<SAS_DICCIONARIO_FILTROS>();
            this.SAS_DICCIONARIO_OPERADORES = new HashSet<SAS_DICCIONARIO_OPERADORES>();
            this.SAS_FLUJOS = new HashSet<SAS_FLUJOS>();
            this.SAS_GRUPO_FILTRO = new HashSet<SAS_GRUPO_FILTRO>();
            this.SAS_MENUS = new HashSet<SAS_MENUS>();
            this.SAS_PERFILES = new HashSet<SAS_PERFILES>();
            this.SAS_REGLAS = new HashSet<SAS_REGLAS>();
            this.SAS_SOLUSR_PERFIL = new HashSet<SAS_SOLUSR_PERFIL>();
            this.SAS_TABLAS = new HashSet<SAS_TABLAS>();
            this.SAS_USUARIOS = new HashSet<SAS_USUARIOS>();
            this.SAS_TABLAS_FILTROS = new HashSet<SAS_TABLAS_FILTROS>();
        }
    
        public int ID_SISTEMA { get; set; }
        public string DESCRIPCION_SISTEMA { get; set; }
        public string SIGLA { get; set; }
        public string VIGENTE { get; set; }
        public string API_ESTADO { get; set; }
        public string API_TRANSACCION { get; set; }
        public string USU_CRE { get; set; }
        public System.DateTime FEC_CRE { get; set; }
        public string USU_MOD { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
        public string URL { get; set; }
        public string COLOR { get; set; }
        public string ICONO { get; set; }
    
        public virtual ICollection<SAS_ACCESOS_PERFILES> SAS_ACCESOS_PERFILES { get; set; }
        public virtual ICollection<SAS_ACCIONES> SAS_ACCIONES { get; set; }
        public virtual ICollection<SAS_CONDICIONES> SAS_CONDICIONES { get; set; }
        public virtual ICollection<SAS_CORREO_FORMATO> SAS_CORREO_FORMATO { get; set; }
        public virtual ICollection<SAS_DICCIONARIO_ETAPAS> SAS_DICCIONARIO_ETAPAS { get; set; }
        public virtual ICollection<SAS_DICCIONARIO_FILTROS> SAS_DICCIONARIO_FILTROS { get; set; }
        public virtual ICollection<SAS_DICCIONARIO_OPERADORES> SAS_DICCIONARIO_OPERADORES { get; set; }
        public virtual ICollection<SAS_FLUJOS> SAS_FLUJOS { get; set; }
        public virtual ICollection<SAS_GRUPO_FILTRO> SAS_GRUPO_FILTRO { get; set; }
        public virtual ICollection<SAS_MENUS> SAS_MENUS { get; set; }
        public virtual ICollection<SAS_PERFILES> SAS_PERFILES { get; set; }
        public virtual ICollection<SAS_REGLAS> SAS_REGLAS { get; set; }
        public virtual ICollection<SAS_SOLUSR_PERFIL> SAS_SOLUSR_PERFIL { get; set; }
        public virtual ICollection<SAS_TABLAS> SAS_TABLAS { get; set; }
        public virtual ICollection<SAS_USUARIOS> SAS_USUARIOS { get; set; }
        public virtual ICollection<SAS_TABLAS_FILTROS> SAS_TABLAS_FILTROS { get; set; }
    }
}