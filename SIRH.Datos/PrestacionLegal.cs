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
    
    public partial class PrestacionLegal
    {
        public PrestacionLegal()
        {
            this.DetallePrestacion = new HashSet<DetallePrestacion>();
            this.DetallePrestacionAfiliacion = new HashSet<DetallePrestacionAfiliacion>();
            this.DetallePrestacionCuadro = new HashSet<DetallePrestacionCuadro>();
        }
    
        public int PK_PrestacionLegal { get; set; }
        public Nullable<int> FK_Nombramiento { get; set; }
        public Nullable<int> FK_TipoPrestacion { get; set; }
        public Nullable<System.DateTime> FecCreacion { get; set; }
        public Nullable<int> IndEstado { get; set; }
        public string NumPrestacion { get; set; }
    
        public virtual ICollection<DetallePrestacion> DetallePrestacion { get; set; }
        public virtual ICollection<DetallePrestacionAfiliacion> DetallePrestacionAfiliacion { get; set; }
        public virtual ICollection<DetallePrestacionCuadro> DetallePrestacionCuadro { get; set; }
        public virtual Nombramiento Nombramiento { get; set; }
        public virtual TipoPrestacion TipoPrestacion { get; set; }
    }
}
