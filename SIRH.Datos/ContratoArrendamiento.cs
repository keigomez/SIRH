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
    
    public partial class ContratoArrendamiento
    {
        public int PK_ContratoArrendamiento { get; set; }
        public Nullable<int> FK_ViaticoCorrido { get; set; }
        public Nullable<int> FK_Desarraigo { get; set; }
        public System.DateTime FecInicial { get; set; }
        public System.DateTime FecFinal { get; set; }
        public string EmisorContrato { get; set; }
        public decimal MonContrato { get; set; }
        public string CodContrato { get; set; }
    
        public virtual Desarraigo Desarraigo { get; set; }
        public virtual ViaticoCorrido ViaticoCorrido { get; set; }
    }
}