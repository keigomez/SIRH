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
    
    public partial class RegistroTiempoExtra
    {
        public RegistroTiempoExtra()
        {
            this.DetalleTiempoExtra = new HashSet<DetalleTiempoExtra>();
        }
    
        public int PK_RegistroTiempoExtra { get; set; }
        public Nullable<System.DateTime> FecEmision { get; set; }
        public string IndPeriodo { get; set; }
        public Nullable<System.DateTime> FecPago { get; set; }
        public Nullable<int> FK_DesgloseSalarialQ1 { get; set; }
        public Nullable<int> FK_DesgloseSalarialQ2 { get; set; }
        public Nullable<int> FK_Clase { get; set; }
        public Nullable<int> FK_Presupuesto { get; set; }
        public Nullable<int> IndEstadoExtra { get; set; }
        public string NumOficioJustificacion { get; set; }
        public string Justificacion { get; set; }
        public byte[] ArchivoJustificacion { get; set; }
        public string ObsEstado { get; set; }
        public string IndArea { get; set; }
        public string IndActividad { get; set; }
        public string ObsEstadoDoble { get; set; }
    
        public virtual Clase Clase { get; set; }
        public virtual DesgloseSalarial DesgloseSalarial { get; set; }
        public virtual DesgloseSalarial DesgloseSalarial1 { get; set; }
        public virtual ICollection<DetalleTiempoExtra> DetalleTiempoExtra { get; set; }
        public virtual Presupuesto Presupuesto { get; set; }
    }
}
