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
    
    public partial class Desarraigo
    {
        public Desarraigo()
        {
            this.ContratoArrendamiento = new HashSet<ContratoArrendamiento>();
            this.DetalleDesarraigoEliminacion = new HashSet<DetalleDesarraigoEliminacion>();
            this.FacturaDesarraigo = new HashSet<FacturaDesarraigo>();
        }
    
        public int PK_Desarraigo { get; set; }
        public int FK_Nombramiento { get; set; }
        public int FK_EstadoDesarraigo { get; set; }
        public Nullable<int> FK_DistritoContrato { get; set; }
        public Nullable<int> FK_DistritoTrabajo { get; set; }
        public Nullable<int> FK_Seccion { get; set; }
        public Nullable<int> FK_Departamento { get; set; }
        public Nullable<int> FK_Presupuesto { get; set; }
        public string NumContrato { get; set; }
        public System.DateTime FecInicDesarraigo { get; set; }
        public System.DateTime FecFinDesarraigo { get; set; }
        public System.DateTime FecRegistro { get; set; }
        public decimal MonDesarraigo { get; set; }
        public decimal MonSalario { get; set; }
        public string ObsDesarraigo { get; set; }
        public string ObsEstado { get; set; }
        public byte[] ImgDocumento { get; set; }
        public int IdJefe { get; set; }
        public string DesNomProyecto { get; set; }
        public int FK_DistritoPernocte { get; set; }
        public string DesPernocte { get; set; }
        public int IdRegistradoPor { get; set; }
        public int IdAnalizadoPor { get; set; }
        public int IdRevisadoPor { get; set; }
        public int IdAprobadoPor { get; set; }
        public string NumAccionAprobado { get; set; }
        public string NumAccionEliminado { get; set; }
    
        public virtual ICollection<ContratoArrendamiento> ContratoArrendamiento { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual Distrito Distrito1 { get; set; }
        public virtual Distrito Distrito2 { get; set; }
        public virtual EstadoDesarraigo EstadoDesarraigo { get; set; }
        public virtual Presupuesto Presupuesto { get; set; }
        public virtual Seccion Seccion { get; set; }
        public virtual ICollection<DetalleDesarraigoEliminacion> DetalleDesarraigoEliminacion { get; set; }
        public virtual ICollection<FacturaDesarraigo> FacturaDesarraigo { get; set; }
        public virtual Nombramiento Nombramiento { get; set; }
    }
}
