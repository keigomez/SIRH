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
    
    public partial class ReintegroVacaciones
    {
        public int PK_ReintegroVacaciones { get; set; }
        public Nullable<int> FK_RegistroVacaciones { get; set; }
        public Nullable<System.DateTime> FecInicio { get; set; }
        public Nullable<System.DateTime> FecFin { get; set; }
        public Nullable<int> IndMotivo { get; set; }
        public string ObsReintegro { get; set; }
        public string NumSolicitudReintegro { get; set; }
        public Nullable<decimal> CntDias { get; set; }
        public Nullable<System.DateTime> FecActualizacion { get; set; }
    
        public virtual RegistroVacaciones RegistroVacaciones { get; set; }
    }
}
