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
    
    public partial class EstadoPedimento
    {
        public EstadoPedimento()
        {
            this.DetalleCambioPedimento = new HashSet<DetalleCambioPedimento>();
        }
    
        public int PK_EstadoPedimento { get; set; }
        public string DesEstadoPedimento { get; set; }
    
        public virtual ICollection<DetalleCambioPedimento> DetalleCambioPedimento { get; set; }
    }
}