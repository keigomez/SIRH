//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIRH.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleBorradorAccionPersonal
    {
        public int PK_Detalle { get; set; }
        public int FK_Borrador { get; set; }
        public int FK_TipoAccionPersonal { get; set; }
        public int FK_Nombramiento { get; set; }
        public Nullable<int> FK_Programa { get; set; }
        public Nullable<int> FK_Seccion { get; set; }
        public System.DateTime FecRige { get; set; }
        public System.DateTime FecVence { get; set; }
        public System.DateTime FecRigeIntegra { get; set; }
        public System.DateTime FecVenceIntegra { get; set; }
        public int CodClase { get; set; }
        public string CodPuesto { get; set; }
        public int NumHoras { get; set; }
        public string Disfrutado { get; set; }
        public string Autorizado { get; set; }
        public int IndCategoria { get; set; }
        public string Categoria { get; set; }
        public decimal MtoSalarioBase { get; set; }
        public decimal MtoAumentosAnuales { get; set; }
        public decimal MtoRecargo { get; set; }
        public decimal MtoGradoGrupo { get; set; }
        public decimal PorProhibicion { get; set; }
        public decimal MtoOtros { get; set; }
    
        public virtual BorradorAccionPersonal BorradorAccionPersonal { get; set; }
        public virtual Nombramiento Nombramiento { get; set; }
        public virtual Programa Programa { get; set; }
        public virtual Seccion Seccion { get; set; }
        public virtual TipoAccionPersonal TipoAccionPersonal { get; set; }
    }
}
