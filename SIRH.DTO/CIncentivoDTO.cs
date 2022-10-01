﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace SIRH.DTO
{
    [DataContract]
    public class CIncentivoDTO : CBaseDTO
    {
        [DataMember]
        public CTipoIncentivoDTO TipoIncentivo { get; set; }
        [DataMember]
        [DisplayName("Observaciones")]
        public string ObsIncentivo { get; set; }
        [DataMember]
        public CDetalleNombramientoDTO DetalleNombramiento { get; set; }
        [DataMember]
        [DisplayName("Estado")]
        public int IndEstIncentivo { get; set; }
    }
}
