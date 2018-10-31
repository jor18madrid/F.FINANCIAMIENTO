using F.FINANCIAMIENTO.DTO;
using F.FINANCIAMIENTO.INTERFACES;
using F.FINANCIAMIENTO.WCF.Util;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace F.FINANCIAMIENTO.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ISAS_GRUPO_FILTRO_INTERFACE _fGrupoFiltro{get; set;} 

        public HomeController(ISAS_GRUPO_FILTRO_INTERFACE fGrupoFiltro)
        {
            _fGrupoFiltro = fGrupoFiltro;
        }


        [HttpGet]
        public ActionResult Index()
        {
            var grupos = _fGrupoFiltro.qry_GRUPOS_FUENTES_FIN_Listado();
            var dicGrpsLst = new Dictionary<int, string>();
            foreach (var item in grupos)
            {
                var id = item;
                dicGrpsLst.Add(item.GRUPO_FUENTE, item.DESC_GRUPO_FUENTE.ToString());
            }
            ViewBag.Grupos = dicGrpsLst.Select(x => new SelectListItem { Value = x.Key.ToString(), Text = x.Value });
            
            return View();
        }

        [HttpPost]
        public ActionResult GetData(INSERTDTO data)
        {
            return Json(ExecuteQuery.Execute(data), JsonRequestBehavior.DenyGet);
        }

        [HttpPost]
        public ActionResult Update(UPDATEDTO updData)
        {
            return Json(Update_FFinanciamiento.Execute(updData), JsonRequestBehavior.DenyGet);
        }



        [HttpGet]
        public JsonResult getFFinanciamiento()
        {
            var fsFinanciamiento = _fGrupoFiltro.qry_FUENTES_FINANCIAMIENTO_Listado();
           
            return Json(fsFinanciamiento, JsonRequestBehavior.AllowGet);
        }




    }
}