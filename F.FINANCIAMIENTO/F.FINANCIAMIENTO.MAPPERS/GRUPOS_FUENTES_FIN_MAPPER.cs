using F.FINANCIAMIENTO.DA;
using F.FINANCIAMIENTO.DTO;
using System.Collections.Generic;

namespace F.FINANCIAMIENTO.MAPPERS
{
    public static class GRUPOS_FUENTES_FIN_MAPPER
    {
        public static GRUPOS_FUENTES_FIN_DTO ToDto(this GRUPOS_FUENTES_FIN Entity)
        {

            var dto = new GRUPOS_FUENTES_FIN_DTO();
            dto.GRUPO_FUENTE = Entity.GRUPO_FUENTE;
            dto.DESC_GRUPO_FUENTE = Entity.DESC_GRUPO_FUENTE;
            dto.VIGENTE = Entity.VIGENTE;
            dto.API_ESTADO = Entity.API_ESTADO;
            dto.API_TRANSACCION = Entity.API_TRANSACCION;
            dto.USU_CRE = Entity.USU_CRE;
            dto.FEC_CRE = Entity.FEC_CRE;
            dto.USU_MOD = Entity.USU_MOD;
            dto.FEC_MOD = Entity.FEC_MOD;
            return dto;
        }

        public static List<GRUPOS_FUENTES_FIN_DTO> ToDtoList(this List<GRUPOS_FUENTES_FIN> ListEntity)
        {
            List<GRUPOS_FUENTES_FIN_DTO> dtos = new List<GRUPOS_FUENTES_FIN_DTO>();
            foreach (var item in ListEntity)
            {
                dtos.Add(item.ToDto());
            }
            return dtos;
        }
    }
}
