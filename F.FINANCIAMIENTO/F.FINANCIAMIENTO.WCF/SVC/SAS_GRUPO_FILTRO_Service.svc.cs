using System.Collections.Generic;
using F.FINANCIAMIENTO.DTO;
using F.FINANCIAMIENTO.WCF.RDN;
using F.FINANCIAMIENTO.INTERFACES;

namespace F.FINANCIAMIENTO.WCF.SVC
{
    public class SAS_GRUPO_FILTRO_Service : ISAS_GRUPO_FILTRO_INTERFACE
    {
        public List<SAS_GRUPO_FILTRO_DTO> qry_SAS_GRUPOS_Listado()
        {
            return new SAS_GRUPO_FILTRO_RDN().SAS_GRUPOS_Listado();
        }
    }
    }
