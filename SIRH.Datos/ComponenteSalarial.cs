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
    
    public partial class ComponenteSalarial
    {
        public ComponenteSalarial()
        {
            this.CambioPorAccionPersonal = new HashSet<CambioPorAccionPersonal>();
            this.DetalleDesgloseSalarial = new HashSet<DetalleDesgloseSalarial>();
            this.DetallePuestoRubro = new HashSet<DetallePuestoRubro>();
        }
    
        public int PK_ComponenteSalarial { get; set; }
        public string DesComponenteSalarial { get; set; }
        public Nullable<int> TipComponenteSalarial { get; set; }
        public Nullable<int> FK_ObjetoGasto { get; set; }
    
        public virtual ICollection<CambioPorAccionPersonal> CambioPorAccionPersonal { get; set; }
        public virtual ObjetoGasto ObjetoGasto { get; set; }
        public virtual ICollection<DetalleDesgloseSalarial> DetalleDesgloseSalarial { get; set; }
        public virtual ICollection<DetallePuestoRubro> DetallePuestoRubro { get; set; }
    }
}
