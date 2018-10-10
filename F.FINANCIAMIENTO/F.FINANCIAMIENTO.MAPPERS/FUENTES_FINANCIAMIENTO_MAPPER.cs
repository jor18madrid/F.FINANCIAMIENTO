using F.FINANCIAMIENTO.DA;
using F.FINANCIAMIENTO.DTO;
using System.Collections.Generic;

namespace F.FINANCIAMIENTO.MAPPERS
{
    public static class FUENTES_FINANCIAMIENTO_MAPPER
    {
        public static FUENTES_FINANCIAMIENTO_DTO ToDto(this FUENTES_FINANCIAMIENTO Entity)
        {
            var dto = new FUENTES_FINANCIAMIENTO_DTO();

            dto.FUENTE = Entity.FUENTE;
            dto.GRUPO_FUENTE = Entity.GRUPO_FUENTE;
            dto.SUB_GRUPO_FUENTE = Entity.SUB_GRUPO_FUENTE;
            dto.DESC_FUENTE = Entity.DESC_FUENTE;
            dto.VIGENTE = Entity.VIGENTE;
            dto.API_ESTADO = Entity.API_ESTADO;
            dto.API_TRANSACCION = Entity.API_TRANSACCION;
            dto.USU_CRE = Entity.USU_CRE;
            dto.FEC_CRE = Entity.FEC_CRE;
            dto.USU_MOD = Entity.USU_MOD;
            dto.FEC_MOD = Entity.FEC_MOD;
            return dto;
        }

        public static List<FUENTES_FINANCIAMIENTO_DTO> ToDtoList(this List<FUENTES_FINANCIAMIENTO> ListEntity)
        {
            List<FUENTES_FINANCIAMIENTO_DTO> dtos = new List<FUENTES_FINANCIAMIENTO_DTO>();
            foreach (var item in ListEntity)
            {
                dtos.Add(item.ToDto());
            }
            return dtos;
        }
    }
}
