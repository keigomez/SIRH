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
    
    public partial class ObjetoGasto
    {
        public ObjetoGasto()
        {
            this.ComponentePresupuestario = new HashSet<ComponentePresupuestario>();
            this.ComponenteSalarial = new HashSet<ComponenteSalarial>();
        }
    
        public int PK_ObjetoGasto { get; set; }
        public Nullable<int> FK_Partida { get; set; }
        public Nullable<int> FK_SubPartida { get; set; }
        public string CodObjetoGasto { get; set; }
        public string DesObjetoGasto { get; set; }
    
        public virtual ICollection<ComponentePresupuestario> ComponentePresupuestario { get; set; }
        public virtual ICollection<ComponenteSalarial> ComponenteSalarial { get; set; }
        public virtual Partida Partida { get; set; }
        public virtual SubPartida SubPartida { get; set; }
    }
}
