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
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.BitacoraUsuario = new HashSet<BitacoraUsuario>();
            this.BoletaPrestamo = new HashSet<BoletaPrestamo>();
            this.DetalleAcceso = new HashSet<DetalleAcceso>();
            this.NotificacionUsuario = new HashSet<NotificacionUsuario>();
            this.NotificacionUsuario1 = new HashSet<NotificacionUsuario>();
            this.ReporteEstadistico = new HashSet<ReporteEstadistico>();
        }
    
        public int PK_Usuario { get; set; }
        public string NomUsuario { get; set; }
        public string TelOficial { get; set; }
        public string EmlOficial { get; set; }
        public Nullable<int> IndEstadoUsuario { get; set; }
        public string Observacion { get; set; }
    
        public virtual ICollection<BitacoraUsuario> BitacoraUsuario { get; set; }
        public virtual ICollection<BoletaPrestamo> BoletaPrestamo { get; set; }
        public virtual ICollection<DetalleAcceso> DetalleAcceso { get; set; }
        public virtual ICollection<NotificacionUsuario> NotificacionUsuario { get; set; }
        public virtual ICollection<NotificacionUsuario> NotificacionUsuario1 { get; set; }
        public virtual ICollection<ReporteEstadistico> ReporteEstadistico { get; set; }
    }
}
