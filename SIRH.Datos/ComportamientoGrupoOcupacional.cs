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
    
    public partial class ComportamientoGrupoOcupacional
    {
        public ComportamientoGrupoOcupacional()
        {
            this.EvidenciaGrupoOcupacional = new HashSet<EvidenciaGrupoOcupacional>();
        }
    
        public int PK_ComportamientoGrupoOcupacional { get; set; }
        public string DesComportamiento { get; set; }
        public Nullable<int> FK_CompetenciaGrupoOcupacional { get; set; }
    
        public virtual CompetenciaGrupoOcupacional CompetenciaGrupoOcupacional { get; set; }
        public virtual ICollection<EvidenciaGrupoOcupacional> EvidenciaGrupoOcupacional { get; set; }
    }
}
