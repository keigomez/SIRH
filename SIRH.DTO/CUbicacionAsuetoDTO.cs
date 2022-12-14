using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace SIRH.DTO
{
    [DataContract]
    public class CUbicacionAsuetoDTO : CBaseDTO
    {
        [DataMember]
        public CCantonDTO Canton { get; set; }
        [DataMember]
        public CCatalogoDiaDTO Dia { get; set; }
    }
}
