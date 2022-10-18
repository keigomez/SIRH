using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using SIRH.DTO;
using SIRH.Web.ComponentePresupuestarioLocal;
using SIRH.Web.Helpers;
using SIRH.Web.UserValidation;
using SIRH.Web.ViewModels;

namespace SIRH.Web.Controllers
{
    public class ComponentePresupuestarioController : Controller
    {
        CComponentePresupuestarioServiceClient componentePresupuestarioService = new CComponentePresupuestarioServiceClient();
        CAccesoWeb context = new CAccesoWeb();
        WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());

        public ActionResult Index()
        {
            context.IniciarSesionModulo(Session, principal.Identity.Name, Convert.ToInt32(EModulosHelper.Cauciones), 0);

            if (Session["Perfil_" + Convert.ToInt32(EModulosHelper.Cauciones)].ToString().StartsWith("Error"))
            {
                return RedirectToAction("Index", "Error", new { modulo = Convert.ToInt32(EModulosHelper.Cauciones) });
            }
            else
            {
                context.GuardarBitacora(principal.Identity.Name, Convert.ToInt32(EModulosHelper.Cauciones), Convert.ToInt32(EAccionesBitacora.Login), 0,
                    CAccesoWeb.ListarEntidades(typeof(CCaucionDTO).Name));
                return View();
            }
        }



        // GET: /ComponentePresupuestario/Create

        public ActionResult Create()
        {
            context.IniciarSesionModulo(Session, principal.Identity.Name, Convert.ToInt32(EModulosHelper.ComponentePresupuestario), 0);

            if (Session["Perfil_" + Convert.ToInt32(EModulosHelper.ComponentePresupuestario)].ToString().StartsWith("Error"))
            {
                return RedirectToAction("Index", "Error", new { modulo = Convert.ToInt32(EModulosHelper.ComponentePresupuestario) });
            }
            else
            {
                if (Convert.ToBoolean(Session["Administrador_Global"]) ||
                    Convert.ToBoolean(Session["Administrador_" + Convert.ToInt32(EModulosHelper.ComponentePresupuestario)]) ||
                    Session[CAccesoWeb.GenerarCadenaPermiso(EModulosHelper.Cauciones, Convert.ToInt32(ENivelesCaucion.Operativo))] != null)
                {
                    ComponentePresupuestarioVM model = new ComponentePresupuestarioVM();
                    return View(model);
                }
                else
                {
                    CAccesoWeb.CargarErrorAcceso(Session);
                    return RedirectToAction("Index", "Error", new { modulo = Convert.ToInt32(EModulosHelper.Cauciones) });
                }
            }
        }


        // POST: /ComponentePresupuestario/Create

        [HttpPost]
        public ActionResult Create(ComponentePresupuestarioVM model, string SubmitButton)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    //model.ComponentePresupuestario.TipoMovimiento = model.TipoMovimiento == "Decreto" ? 3 : 1;
                    //var resultado = caucionService.AgregarMontoCaucion(model.MontoCaucion);

                    var resultado = componentePresupuestarioService.AgregarDecretoComponentePresupuestario(model.ComponentePresupuestario.Programa, model.ComponentePresupuestario.ObjetoGasto, model.ComponentePresupuestario.TipoMovimiento, model.ComponentePresupuestario);

                    if (resultado.GetType() != typeof(CErrorDTO))
                    {
                        context.GuardarBitacora(principal.Identity.Name, Convert.ToInt32(EModulosHelper.ComponentePresupuestario),
                            Convert.ToInt32(EAccionesBitacora.Guardar), resultado.IdEntidad,
                            CAccesoWeb.ListarEntidades(typeof(CComponentePresupuestarioDTO).Name));
                        // return RedirectToAction("Details", new { id = resultado.IdEntidad, accion = "guardar" });
                        return JavaScript("Se Guardo Correctamente");
                        
                       
                    }
                    else
                    {
                        throw new Exception(((CErrorDTO)resultado).MensajeError);
                    }
                }
                else
                {
                    throw new Exception("Validacion");
                }
            }
            catch (Exception error)
            {
                //List<string> estadosPage = new List<string>();
                //estadosPage.Add("Seleccionar Estado");
                //estadosPage.Add("Activo");
                //estadosPage.Add("Inactivo");
                //model.Estados = new SelectList(estadosPage);

                if (error.Message != "Validacion")
                {
                    ModelState.AddModelError("BDError", error.Message);
                }

                return View(model);
            }



        }
    }



    
}

        
                