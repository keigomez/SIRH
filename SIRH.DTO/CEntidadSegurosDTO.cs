using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace SIRH.DTO
{
    [DataContract]
    public class CEntidadSegurosDTO : CBaseDTO
    {
        [DataMember]
        [DisplayName("Aseguradora")]
        public string NombreEntidad { get; set; }
    }
}
