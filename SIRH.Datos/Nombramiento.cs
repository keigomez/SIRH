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
    
    public partial class Nombramiento
    {
        public Nombramiento()
        {
            this.AccionPersonal = new HashSet<AccionPersonal>();
            this.CalificacionNombramiento = new HashSet<CalificacionNombramiento>();
            this.CambioPorAccionPersonal = new HashSet<CambioPorAccionPersonal>();
            this.CartasPresentacion = new HashSet<CartasPresentacion>();
            this.Caucion = new HashSet<Caucion>();
            this.DeduccionTemporal = new HashSet<DeduccionTemporal>();
            this.Desarraigo = new HashSet<Desarraigo>();
            this.DesgloseSalarial = new HashSet<DesgloseSalarial>();
            this.DetalleBorradorAccionPersonal = new HashSet<DetalleBorradorAccionPersonal>();
            this.GastoTransporte = new HashSet<GastoTransporte>();
            this.ListaNombramientosActivos = new HashSet<ListaNombramientosActivos>();
            this.PeriodoVacaciones = new HashSet<PeriodoVacaciones>();
            this.PrestacionLegal = new HashSet<PrestacionLegal>();
            this.ViaticoCorrido = new HashSet<ViaticoCorrido>();
            this.RegistroIncapacidad = new HashSet<RegistroIncapacidad>();
        }
    
        public int PK_Nombramiento { get; set; }
        public int FK_EstadoNombramiento { get; set; }
        public int FK_Puesto { get; set; }
        public Nullable<int> FK_Funcionario { get; set; }
        public Nullable<System.DateTime> FecRige { get; set; }
        public Nullable<System.DateTime> FecVence { get; set; }
        public Nullable<System.DateTime> FecNombramiento { get; set; }
    
        public virtual ICollection<AccionPersonal> AccionPersonal { get; set; }
        public virtual ICollection<CalificacionNombramiento> CalificacionNombramiento { get; set; }
        public virtual ICollection<CambioPorAccionPersonal> CambioPorAccionPersonal { get; set; }
        public virtual ICollection<CartasPresentacion> CartasPresentacion { get; set; }
        public virtual ICollection<Caucion> Caucion { get; set; }
        public virtual ICollection<DeduccionTemporal> DeduccionTemporal { get; set; }
        public virtual ICollection<Desarraigo> Desarraigo { get; set; }
        public virtual ICollection<DesgloseSalarial> DesgloseSalarial { get; set; }
        public virtual ICollection<DetalleBorradorAccionPersonal> DetalleBorradorAccionPersonal { get; set; }
        public virtual EstadoNombramiento EstadoNombramiento { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual ICollection<GastoTransporte> GastoTransporte { get; set; }
        public virtual ICollection<ListaNombramientosActivos> ListaNombramientosActivos { get; set; }
        public virtual Puesto Puesto { get; set; }
        public virtual ICollection<PeriodoVacaciones> PeriodoVacaciones { get; set; }
        public virtual ICollection<PrestacionLegal> PrestacionLegal { get; set; }
        public virtual ICollection<ViaticoCorrido> ViaticoCorrido { get; set; }
        public virtual ICollection<RegistroIncapacidad> RegistroIncapacidad { get; set; }
    }
}
