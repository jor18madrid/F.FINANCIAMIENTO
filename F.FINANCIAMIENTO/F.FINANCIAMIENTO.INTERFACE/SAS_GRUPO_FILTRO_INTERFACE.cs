
using F.FINANCIAMIENTO.DTO;
using System.Collections.Generic;
using System.ServiceModel;

namespace F.FINANCIAMIENTO.INTERFACES
{
    [ServiceContract(Namespace = "http://f.financiamiento.sefin.gob.hn")]

    public interface ISAS_GRUPO_FILTRO_INTERFACE
    {
        [OperationContract]
        List<SAS_GRUPO_FILTRO_DTO> qry_SAS_GRUPOS_Listado();
    }
}