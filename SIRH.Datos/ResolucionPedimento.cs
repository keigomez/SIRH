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
    
    public partial class ResolucionPedimento
    {
        public int PK_ResolucionPedimento { get; set; }
        public string NumResolucion { get; set; }
        public Nullable<System.DateTime> FecResolucion { get; set; }
        public string ObsResolucion { get; set; }
        public int FK_PedimentoPuesto { get; set; }
        public int FK_TipoResolucionPedimento { get; set; }
    
        public virtual PedimentoPuesto PedimentoPuesto { get; set; }
        public virtual TipoResolucionPedimento TipoResolucionPedimento { get; set; }
    }
}
