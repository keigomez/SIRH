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
    
    public partial class ComportamientoTransversal
    {
        public ComportamientoTransversal()
        {
            this.EvidenciaComportamientoTransversal = new HashSet<EvidenciaComportamientoTransversal>();
        }
    
        public int PK_ComportamientoTransversal { get; set; }
        public string DesComportamientoTransversal { get; set; }
        public Nullable<int> FK_CompetenciaTransversalCargo { get; set; }
    
        public virtual CompetenciaTransversalCargo CompetenciaTransversalCargo { get; set; }
        public virtual ICollection<EvidenciaComportamientoTransversal> EvidenciaComportamientoTransversal { get; set; }
    }
}
