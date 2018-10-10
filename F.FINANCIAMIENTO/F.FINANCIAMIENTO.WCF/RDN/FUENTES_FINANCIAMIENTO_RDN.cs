using F.FINANCIAMIENTO.DA;
using F.FINANCIAMIENTO.DTO;
using F.FINANCIAMIENTO.MAPPERS;
using System.Collections.Generic;
using System.Linq;

namespace F.FINANCIAMIENTO.WCF.RDN
{
    public class FUENTES_FINANCIAMIENTO_RDN
    {
        public List<FUENTES_FINANCIAMIENTO_DTO> FUENTES_FINANCIAMIENTO_Listado()
        {
            List<FUENTES_FINANCIAMIENTO_DTO> lstDescGrupo = new List<FUENTES_FINANCIAMIENTO_DTO>();
            using (var context = new EntitiesFF())
            {
                lstDescGrupo = (from r in context.FUENTES_FINANCIAMIENTO select r).OrderBy(x => x.FUENTE).ToList().ToDtoList();
            }
            return lstDescGrupo;
        }
    }
}