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
    
    public partial class Caucion
    {
        public int PK_Caucion { get; set; }
        public Nullable<int> FK_Nombramiento { get; set; }
        public Nullable<int> FK_EntidadSeguros { get; set; }
        public Nullable<int> FK_MontoCaucion { get; set; }
        public Nullable<System.DateTime> FecEmision { get; set; }
        public Nullable<System.DateTime> FecVence { get; set; }
        public Nullable<int> IndEstadoPoliza { get; set; }
        public byte[] ImgCopiaRecibo { get; set; }
        public string ObsPoliza { get; set; }
        public string NumPoliza { get; set; }
        public Nullable<bool> IndCopiaCertificada { get; set; }
        public string NumOficioEntrega { get; set; }
    
        public virtual EntidadSeguros EntidadSeguros { get; set; }
        public virtual MontoCaucion MontoCaucion { get; set; }
        public virtual Nombramiento Nombramiento { get; set; }
    }
}
