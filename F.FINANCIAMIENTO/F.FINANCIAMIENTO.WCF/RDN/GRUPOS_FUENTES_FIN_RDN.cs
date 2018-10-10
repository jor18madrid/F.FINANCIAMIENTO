using F.FINANCIAMIENTO.DA;
using F.FINANCIAMIENTO.DTO;
using F.FINANCIAMIENTO.MAPPERS;
using System.Collections.Generic;
using System.Linq;

namespace F.FINANCIAMIENTO.WCF.RDN
{
    public class GRUPOS_FUENTES_FIN_RDN
    {
        public List<GRUPOS_FUENTES_FIN_DTO> GRUPOS_FUENTES_FIN_Listado()
        {
            List<GRUPOS_FUENTES_FIN_DTO> lstDescGrupo = new List<GRUPOS_FUENTES_FIN_DTO>();
            using (var context = new EntitiesFF())
            {
                lstDescGrupo = (from r in context.GRUPOS_FUENTES_FIN select r).OrderBy(x => x.GRUPO_FUENTE).ToList().ToDtoList();
            }
            return lstDescGrupo;
        }
    }
}