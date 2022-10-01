﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SIRH.DTO;
using SIRH.Logica;

namespace SIRH.Servicios
{
    // NOTE: If you change the class name "CComponentePresupuestarioService" here, you must also update the reference to "CComponentePresupuestarioService" in App.config.
    public class CComponentePresupuestarioService : ICComponentePresupuestarioService
    {
        public CBaseDTO GuardarComponentePresupuestario(CProgramaDTO programa, CObjetoGastoDTO objetoGasto,
                                                   CCatMovimientoPresupuestoDTO tipo, CComponentePresupuestarioDTO componente)
        {
            CComponentePresupuestarioL respuesta = new CComponentePresupuestarioL();
            return respuesta.GuardarComponentePresupuestario(programa, objetoGasto, tipo, componente);
        }

        public CBaseDTO EditarComponentePresupuestario(CComponentePresupuestarioDTO componente)
        {
            CComponentePresupuestarioL respuesta = new CComponentePresupuestarioL();
            return respuesta.EditarComponentePresupuestario(componente);
        }

        public List<CBaseDTO> ListarMovimientosPresupuesto(string anno)
        {
            CComponentePresupuestarioL respuesta = new CComponentePresupuestarioL();
            return respuesta.ListarMovimientosPresupuesto(anno);
        }

        public List<CBaseDTO> DescargarProgramas()
        {
            CComponentePresupuestarioL respuesta = new CComponentePresupuestarioL();
            return respuesta.DescargarProgramas();
        }

        public List<CBaseDTO> DescargarObjetosGasto()
        {
            CComponentePresupuestarioL respuesta = new CComponentePresupuestarioL();
            return respuesta.DescargarObjetosGasto();
        }

        public List<CBaseDTO> DescargarCatMovimientoPresupuesto()
        {
            CComponentePresupuestarioL respuesta = new CComponentePresupuestarioL();
            return respuesta.DescargarCatMovimientoPresupuesto();
        }
        public List<CBaseDTO> ObtenerMovimientoPresupuesto(int idMovimiento)
        {
            CComponentePresupuestarioL respuesta = new CComponentePresupuestarioL();
            return respuesta.ObtenerMovimientoPresupuesto(idMovimiento);
        }
    }
}