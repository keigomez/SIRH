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
    
    public partial class MovimientoViaticoCorrido
    {
        public MovimientoViaticoCorrido()
        {
            this.DetalleDeduccionViaticoCorrido = new HashSet<DetalleDeduccionViaticoCorrido>();
            this.DetalleEliminacionViaticoCorridoGastoTransporte = new HashSet<DetalleEliminacionViaticoCorridoGastoTransporte>();
        }
    
        public int PK_MovimientoViaticoCorrido { get; set; }
        public int FK_ViaticoCorrido { get; set; }
        public System.DateTime FecMovimiento { get; set; }
        public string ObsObservacion { get; set; }
        public int NumTipo { get; set; }
        public int IndEstado { get; set; }
    
        public virtual ICollection<DetalleDeduccionViaticoCorrido> DetalleDeduccionViaticoCorrido { get; set; }
        public virtual ICollection<DetalleEliminacionViaticoCorridoGastoTransporte> DetalleEliminacionViaticoCorridoGastoTransporte { get; set; }
        public virtual ViaticoCorrido ViaticoCorrido { get; set; }
    }
}