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
    
    public partial class CatPermisoEvidencia
    {
        public int PK_Permiso { get; set; }
        public int FK_Funcionario { get; set; }
        public int IndArchivo { get; set; }
    
        public virtual Funcionario Funcionario { get; set; }
    }
}
