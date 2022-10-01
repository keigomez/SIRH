using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SIRH.DTO
{
    [DataContract]
    public class CComponentePresupuestarioDTO : CBaseDTO
    {
        [DataMember]
        public CObjetoGastoDTO ObjetoGasto { get; set; }

        [DataMember]
        public CProgramaDTO Programa { get; set; }

        [DataMember]
        [DisplayName("Año Presupuestario")]
        public string AnioPresupuesto { get; set; }

        [DataMember]
        [DisplayName("Monto")]
        [DisplayFormat(DataFormatString = "{0:N2")]
        public decimal MontoComponente { get; set; }

        [DataMember]
        public CCatMovimientoPresupuestoDTO TipoMovimiento { get; set; }

        [DataMember]
        [DisplayName("Detalle")]
        public string Detalle { get; set; }


    }
}

