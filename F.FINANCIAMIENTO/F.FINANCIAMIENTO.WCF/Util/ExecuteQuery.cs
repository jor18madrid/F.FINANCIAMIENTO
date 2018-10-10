using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace F.FINANCIAMIENTO.WCF.Util
{
    public static class ExecuteQuery
    {
        public static string result;

        public static string Execute(DTO.INSERTDTO lst)
        {
            int insCont = 0;
            string msj = "";
            string sqlStringCon = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=172.16.48.173)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DESA)));PASSWORD=taller018;USER ID=USER_TALLERAWS;";

            using (OracleConnection cn = new OracleConnection(sqlStringCon))
            {
                try
                {
                    cn.Open();
                }
                catch (OracleException e)
                {
                    msj = "Code: [" + e.ErrorCode + "] \n" +
                         "Mensaje: " + e.Message;
                }
                OracleCommand cmd = cn.CreateCommand();
                OracleTransaction transaction;

                transaction = cn.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.Transaction = transaction;
                try
                {
                    foreach (var item in lst.FuenteFin)
                    {
                        if (string.IsNullOrEmpty(item.VIGENTE))
                        {
                            item.VIGENTE = "N";
                        }
                        else
                        {
                            item.VIGENTE = "S";
                        }
                        cmd.CommandText = "insert into USER_TALLERAWS.FUENTES_FINANCIAMIENTO (FUENTE,GRUPO_FUENTE,SUB_GRUPO_FUENTE,DESC_FUENTE,VIGENTE,API_ESTADO,API_TRANSACCION,USU_CRE,FEC_CRE,USU_MOD,FEC_MOD) values " + "(" + item.FUENTE_FINANCIAMIENTO + "," + item.ID_GRUPO + "," + item.SUB_GRUPO_FUENTE + "," + "'" + item.DESC + "'" + "," + "'" + item.VIGENTE + "'" + "," + "'ELABORADO','CREAR',user,sysdate,NULL,NULL)";
                        cmd.ExecuteNonQuery();
                        insCont++;
                    }

                   /*Cambiar por el commit*/transaction.Rollback();
                    //transaction.Commit();
                    msj = "Query ejecutado con éxito!,      " +
                        "\n Se realizaron " + insCont + " acciones";
                    insCont = 0;
                    cmd.Dispose();
                    cn.Close();
                }
                catch (OracleException e)
                {
                    transaction.Rollback();
                    msj = "Code: [" + e.ErrorCode + "] \n" +
                          "Mensaje: " + e.Message;
                }
            }
            return msj;
        }

    }
}