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
    
    public partial class C_AUX_DetallePagoGasto
    {
        public int PK_Detalle { get; set; }
        public int FK_GastoTransporte { get; set; }
        public System.DateTime FecDiaPago { get; set; }
        public int FK_TipoDetallePagoGasto { get; set; }
        public decimal MonPago { get; set; }
        public int CodEntidad { get; set; }
        public string DesMotivo { get; set; }
    }
}