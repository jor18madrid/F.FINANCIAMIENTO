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
            //var grupos = _fGrupoFiltro.qry_GRUPOS_FUENTES_FIN_Listado();
            //var dicGrpsLst = new Dictionary<int, string>();
            //foreach (var item in grupos)
            //{
            //    var id = item;
            //    dicGrpsLst.Add(item.GRUPO_FUENTE, item.DESC_GRUPO_FUENTE.ToString());
            //}
            //ViewBag.Grupos = dicGrpsLst.Select(x => new SelectListItem { Value = x.Key.ToString(), Text = x.Value });
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            var dicGrpsLst = new List<SAS_GRUPO_FILTRO_DTO>();
            dicGrpsLst.Add(new SAS_GRUPO_FILTRO_DTO() { ID_GRUPO = 1, NOMBRE_GRUPO = "Grupo 1" });
            dicGrpsLst.Add(new SAS_GRUPO_FILTRO_DTO() { ID_GRUPO = 2, NOMBRE_GRUPO = "Grupo 2" });
            ViewBag.Grupos = dicGrpsLst.Select(x => new SelectListItem { Value = x.ID_GRUPO.ToString(), Text = x.NOMBRE_GRUPO });
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////
            ViewBag.Result = ExecuteQuery.result;
            ExecuteQuery.result = "";
            return View();
            //////////////////////////////////////
        }

        [HttpPost]
        public ActionResult GetData(INSERTDTO data/*,UPDATEDTO updData*/)
        {

            //var nUpd = updData.FuenteFinUpd.Where(x => x.FFNUPD == "S").OrderBy(y => y.FUENTEFUPD);
            //ExecuteQuery.result = ExecuteQuery.Execute(data);
            return Json("Retorna del controlador GUARDAR", JsonRequestBehavior.DenyGet);
        }

        [HttpPost]
        public ActionResult Update(UPDATEDTO updData)
        {
            //Update_FFinanciamiento.Execute(updData);
            return Json("Retorna del controlador UPDATE ", JsonRequestBehavior.DenyGet);
        }



        [HttpGet]
        public JsonResult getFFinanciamiento()
        {
            //var fsFinanciamiento = _fGrupoFiltro.qry_FUENTES_FINANCIAMIENTO_Listado();
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            List<FUENTES_FINANCIAMIENTO_DTO> fsFinanciamiento = new List<FUENTES_FINANCIAMIENTO_DTO>();
            fsFinanciamiento.Add(new FUENTES_FINANCIAMIENTO_DTO() { FUENTE = 12, VIGENTE = "S", DESC_FUENTE = "Mixto" });
            fsFinanciamiento.Add(new FUENTES_FINANCIAMIENTO_DTO() { FUENTE = 32, VIGENTE = "N", DESC_FUENTE = "Mixto2" });
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            return Json(fsFinanciamiento, JsonRequestBehavior.AllowGet);
        }




    }
}