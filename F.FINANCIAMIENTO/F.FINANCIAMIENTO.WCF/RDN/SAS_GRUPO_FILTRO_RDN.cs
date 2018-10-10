using F.FINANCIAMIENTO.DA;
using F.FINANCIAMIENTO.DTO;
using F.FINANCIAMIENTO.MAPPERS;
using System.Collections.Generic;
using System.Linq;

namespace F.FINANCIAMIENTO.WCF.RDN
{
    public class SAS_GRUPO_FILTRO_RDN
    {
        public List<SAS_GRUPO_FILTRO_DTO> SAS_GRUPOS_Listado()
        {
            List<SAS_GRUPO_FILTRO_DTO> lstDescGrupo = new List<SAS_GRUPO_FILTRO_DTO>();
            using (var context = new Entities())
            {
                lstDescGrupo = (from r in context.SAS_GRUPO_FILTRO select r).OrderBy(x => x.ID_GRUPO).ToList().ToDtoList();
            }
            return lstDescGrupo;
        }
    }
}