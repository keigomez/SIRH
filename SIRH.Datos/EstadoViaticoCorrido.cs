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
    
    public partial class EstadoViaticoCorrido
    {
        public EstadoViaticoCorrido()
        {
            this.ViaticoCorrido = new HashSet<ViaticoCorrido>();
        }
    
        public int PK_EstadoViaticoCorrido { get; set; }
        public string NomEstado { get; set; }
    
        public virtual ICollection<ViaticoCorrido> ViaticoCorrido { get; set; }
    }
}
