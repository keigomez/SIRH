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
    
    public partial class ActividadFuncionario
    {
        public int PK_Actividad { get; set; }
        public int FK_Funcionario { get; set; }
        public string DesActividad { get; set; }
        public int IndEstado { get; set; }
        public System.DateTime FecDesde { get; set; }
        public System.DateTime FecHasta { get; set; }
        public System.DateTime FecRegistro { get; set; }
        public string DesEvidencia { get; set; }
        public string DesObservacion { get; set; }
        public int IndTeletrabajo { get; set; }
    
        public virtual Funcionario Funcionario { get; set; }
    }
}
