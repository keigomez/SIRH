//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIRH.DatosMarcasReloj
{
    using System;
    using System.Collections.Generic;
    
    public partial class AutorizaAusencias
    {
        public int IdAusencias { get; set; }
        public string CodigoEmpleado { get; set; }
        public int IdJustificacion { get; set; }
        public string CodigoEmpleadoAutoriza { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFinal { get; set; }
        public int Dia { get; set; }
        public System.DateTime Hora { get; set; }
        public System.DateTime Minuto { get; set; }
        public int Tipo { get; set; }
        public int Congoce { get; set; }
        public System.DateTime HoraSalida { get; set; }
        public System.DateTime HoraEntrada { get; set; }
        public string CodigoEmpleadoAutoriza2 { get; set; }
    }
}
