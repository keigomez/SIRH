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
    
    public partial class ContenidoPresupuestario
    {
        public ContenidoPresupuestario()
        {
            this.DetallePuesto = new HashSet<DetallePuesto>();
        }
    
        public int PK_ContenidoPresupuestario { get; set; }
        public string NumResolucion { get; set; }
        public Nullable<System.DateTime> FecPago { get; set; }
        public Nullable<System.DateTime> FecRige { get; set; }
    
        public virtual ICollection<DetallePuesto> DetallePuesto { get; set; }
    }
}
