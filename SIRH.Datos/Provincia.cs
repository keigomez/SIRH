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
    
    public partial class Provincia
    {
        public Provincia()
        {
            this.Canton = new HashSet<Canton>();
        }
    
        public int PK_Provincia { get; set; }
        public string NomProvincia { get; set; }
    
        public virtual ICollection<Canton> Canton { get; set; }
    }
}