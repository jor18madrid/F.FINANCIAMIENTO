using F.FINANCIAMIENTO.DTO;
using F.FINANCIAMIENTO.INTERFACES;
using F.FINANCIAMIENTO.WCF.RDN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace F.FINANCIAMIENTO.WCF.SVC
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : ISAS_GRUPO_FILTRO_INTERFACE
    {
        public List<SAS_GRUPO_FILTRO_DTO> qry_SAS_GRUPOS_Listado()
        {
            return new SAS_GRUPO_FILTRO_RDN().SAS_GRUPOS_Listado();
        }
    }
}

