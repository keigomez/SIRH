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
    
    public partial class MovimientoPuesto
    {
        public int PK_MovimientoPuesto { get; set; }
        public string CodOficio { get; set; }
        public Nullable<System.DateTime> FecMovimiento { get; set; }
        public Nullable<int> FK_MotivoMovimiento { get; set; }
        public Nullable<int> FK_Puesto { get; set; }
        public Nullable<int> FK_EstadoMovimientoPuesto { get; set; }
        public Nullable<System.DateTime> FecVence { get; set; }
        public string ObsMovimientoPuesto { get; set; }
    
        public virtual EstadoMovimientoPuesto EstadoMovimientoPuesto { get; set; }
        public virtual MotivoMovimiento MotivoMovimiento { get; set; }
        public virtual Puesto Puesto { get; set; }
    }
}
