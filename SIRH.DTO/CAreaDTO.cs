using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace SIRH.DTO
{
    [DataContract]
    public class CAreaDTO : CBaseDTO
    {
        [DataMember]
        [DisplayName("Descripción de Área")]
        public string DesArea { get; set; }
    }
}

