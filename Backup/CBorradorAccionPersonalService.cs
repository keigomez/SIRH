using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SIRH.DTO;
using SIRH.Logica;

namespace SIRH.Servicios
{
    // NOTE: If you change the class name "CBorradorAccionPersonalService" here, you must also update the reference to "CBorradorAccionPersonalService" in App.config.
    public class CBorradorAccionPersonalService : ICBorradorAccionPersonalService
    {
        public CBaseDTO GuardarBorrador(CFuncionarioDTO funcionario, CEstadoBorradorDTO estado,
                                        CTipoAccionPersonalDTO tipo, CBorradorAccionPersonalDTO registro,
                                        CDetalleBorradorAccionPersonalDTO detalle,
                                        string codUsuarioEnvia, string codUsuarioRecibe)
        {
            CBorradorAccionPersonalL respuesta = new CBorradorAccionPersonalL();
            return respuesta.AgregarBorrador(funcionario, estado, tipo, registro, detalle, codUsuarioEnvia, codUsuarioRecibe);
        }


        public CBaseDTO EditarBorrador(CBorradorAccionPersonalDTO registro)
        {
            CBorradorAccionPersonalL respuesta = new CBorradorAccionPersonalL();
            return respuesta.EditarBorrador(registro);
        }


        public List<CBaseDTO> ObtenerBorrador(int codigo)
        {
            CBorradorAccionPersonalL respuesta = new CBorradorAccionPersonalL();
            return respuesta.ObtenerBorrador(codigo);
        }


        public List<List<CBaseDTO>> BuscarBorrador(CFuncionarioDTO funcionario,
                                                    CBorradorAccionPersonalDTO registro,
                                                    List<DateTime> fechasRige,
                                                    List<DateTime> fechasVence)
        {
            CBorradorAccionPersonalL respuesta = new CBorradorAccionPersonalL();
            return respuesta.BuscarBorrador(funcionario, registro, fechasRige, fechasVence);
        }


        public CBaseDTO ActualizarEstado(CBorradorAccionPersonalDTO registro, CMovimientoBorradorAccionPersonalDTO movimiento)
        {
            CBorradorAccionPersonalL respuesta = new CBorradorAccionPersonalL();
            return respuesta.ActualizarEstado(registro, movimiento);
        }


        public List<List<CBaseDTO>> FuncionariosConBorradores()
        {
            CBorradorAccionPersonalL respuesta = new CBorradorAccionPersonalL();
            return respuesta.FuncionariosConBorradores();
        }

    }
}