//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIRH.DatosMarcasReloj
{
    using System;
    using System.Collections.Generic;
    
    public partial class CartasEmpleado
    {
        public int IdCartaEmpleado { get; set; }
        public string CodigoEmpleado { get; set; }
        public System.DateTime Fecha { get; set; }
        public short TipoCarta { get; set; }
        public int IdMachote { get; set; }
        public string NombreMachote { get; set; }
        public string Firma { get; set; }
        public short EstatusImpresion { get; set; }
    }
}