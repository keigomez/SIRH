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
    
    public partial class FacturaDesarraigo
    {
        public int PK_FacturaDesarraigo { get; set; }
        public Nullable<int> FK_Desarraigo { get; set; }
        public Nullable<int> FK_ViaticoCorrido { get; set; }
        public System.DateTime FecFacturacion { get; set; }
        public string EmisorFactura { get; set; }
        public decimal MonFactura { get; set; }
        public string CodFactura { get; set; }
        public string ObsConcepto { get; set; }
    
        public virtual Desarraigo Desarraigo { get; set; }
        public virtual ViaticoCorrido ViaticoCorrido { get; set; }
    }
}
