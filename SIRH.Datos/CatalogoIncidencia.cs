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
    
    public partial class CatalogoIncidencia
    {
        public CatalogoIncidencia()
        {
            this.BotAccionIncidencia = new HashSet<BotAccionIncidencia>();
            this.Incidencia = new HashSet<Incidencia>();
        }
    
        public int PK_CatalogoIncidencia { get; set; }
        public int FK_Perfil { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Prioridad { get; set; }
    
        public virtual ICollection<BotAccionIncidencia> BotAccionIncidencia { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual ICollection<Incidencia> Incidencia { get; set; }
    }
}
