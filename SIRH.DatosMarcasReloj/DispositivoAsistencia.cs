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
    
    public partial class DispositivoAsistencia
    {
        public int IdDispositivo { get; set; }
        public int IdTagLectora { get; set; }
        public short asistencia { get; set; }
        public short acceso { get; set; }
        public short output1 { get; set; }
        public short output2 { get; set; }
        public short output3 { get; set; }
        public short output4 { get; set; }
        public short output5 { get; set; }
        public short output6 { get; set; }
        public short output7 { get; set; }
        public short output8 { get; set; }
    
        public virtual TagSoftware TagSoftware { get; set; }
    }
}
