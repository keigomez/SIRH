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
    
    public partial class RemuneracionEfectuadaPF
    {
        public int PK_RemuneracionEfectuadaPF { get; set; }
        public int FK_PagoFeriado { get; set; }
        public int FK_CatalogoRemuneracion { get; set; }
        public decimal PorEfectuado { get; set; }
    
        public virtual CatalogoRemuneracion CatalogoRemuneracion { get; set; }
        public virtual PagoFeriado PagoFeriado { get; set; }
    }
}