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
    
    public partial class ExperienciaProfesional
    {
        public int PK_ExperienciaProfesional { get; set; }
        public Nullable<System.DateTime> FecRegistro { get; set; }
        public Nullable<decimal> IndPuntosAsignados { get; set; }
        public Nullable<int> TipExperiencia { get; set; }
        public string ObsExperienciaProfesional { get; set; }
        public Nullable<int> FK_FormacionAcademica { get; set; }
        public string NumResolucion { get; set; }
    
        public virtual FormacionAcademica FormacionAcademica { get; set; }
    }
}
