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
    
    public partial class Canton
    {
        public Canton()
        {
            this.Distrito = new HashSet<Distrito>();
            this.UbicacionAsueto = new HashSet<UbicacionAsueto>();
        }
    
        public int PK_Canton { get; set; }
        public int FK_Provincia { get; set; }
        public string NomCanton { get; set; }
        public string CodPostalCanton { get; set; }
    
        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<Distrito> Distrito { get; set; }
        public virtual ICollection<UbicacionAsueto> UbicacionAsueto { get; set; }
    }
}
