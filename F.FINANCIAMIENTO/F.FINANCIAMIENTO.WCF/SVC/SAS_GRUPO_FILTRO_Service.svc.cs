using System.Collections.Generic;
using F.FINANCIAMIENTO.DTO;
using F.FINANCIAMIENTO.WCF.RDN;
using F.FINANCIAMIENTO.INTERFACES;
using System;

namespace F.FINANCIAMIENTO.WCF.SVC
{
    public class SAS_GRUPO_FILTRO_Service : ISAS_GRUPO_FILTRO_INTERFACE
    {
        public List<FUENTES_FINANCIAMIENTO_DTO> qry_FUENTES_FINANCIAMIENTO_Listado()
        {
            return new FUENTES_FINANCIAMIENTO_RDN().FUENTES_FINANCIAMIENTO_Listado();
        }

        public List<GRUPOS_FUENTES_FIN_DTO> qry_GRUPOS_FUENTES_FIN_Listado()
        {
            return new GRUPOS_FUENTES_FIN_RDN().GRUPOS_FUENTES_FIN_Listado();
        }

        public List<SAS_GRUPO_FILTRO_DTO> qry_SAS_GRUPOS_Listado()
        {
            return new SAS_GRUPO_FILTRO_RDN().SAS_GRUPOS_Listado();
        }
    }
    }
