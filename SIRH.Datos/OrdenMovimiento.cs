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
    
    public partial class OrdenMovimiento
    {
        public OrdenMovimiento()
        {
            this.OrdenMovimientoDeclaracion = new HashSet<OrdenMovimientoDeclaracion>();
        }
    
        public int PK_OrdenMovimiento { get; set; }
        public int FK_Funcionario { get; set; }
        public int FK_DetallePuesto { get; set; }
        public Nullable<int> FK_Pedimento { get; set; }
        public int FK_TipoMovimiento { get; set; }
        public int FK_Estado { get; set; }
        public string NumOrden { get; set; }
        public string CuentaCliente { get; set; }
        public int IdFuncionarioSustituido { get; set; }
        public System.DateTime FecRige { get; set; }
        public Nullable<System.DateTime> FecVence { get; set; }
        public int IdMotivoMovimiento { get; set; }
        public string DesObservaciones { get; set; }
        public string DesObservacionesEstado { get; set; }
        public string DesPartidaPresupuestaria { get; set; }
        public int IdFuncionarioResponsable { get; set; }
        public int IdFuncionarioRevision { get; set; }
        public int IdFuncionarioJefatura { get; set; }
    
        public virtual DetallePuesto DetallePuesto { get; set; }
        public virtual EstadoOrdenMovimiento EstadoOrdenMovimiento { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual MotivoMovimiento MotivoMovimiento { get; set; }
        public virtual PedimentoPuesto PedimentoPuesto { get; set; }
        public virtual ICollection<OrdenMovimientoDeclaracion> OrdenMovimientoDeclaracion { get; set; }
    }
}
