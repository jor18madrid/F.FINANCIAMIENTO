using F.FINANCIAMIENTO.DA;
using F.FINANCIAMIENTO.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            var grupos = _fGrupoFiltro.qry_SAS_GRUPOS_Listado();
            var dicGrpsLst = new Dictionary<int, string>();
            foreach (var item in grupos)
            {
                var id = item;
                dicGrpsLst.Add(item.ID_GRUPO, item.NOMBRE_GRUPO.ToString());
            }
            ViewBag.Grupos = dicGrpsLst.Select(x => new SelectListItem { Value = x.Key.ToString(), Text = x.Value });
            return View();
        }
    }
}