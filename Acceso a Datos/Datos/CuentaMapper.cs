using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace Datos
{
    public class CuentaMapper
    {
        public Cuenta Traer(int idCliente)
        {
            string json2 = WebHelper.Get("/api/v1/cuenta/" + idCliente.ToString());
            Cuenta resultado = Map(json2);
            return resultado;
        }
        private Cuenta Map(string json2)
        {
            Cuenta lst = JsonConvert.DeserializeObject<Cuenta>(json2);
            return lst;
        }
        public TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta, "insert");
            string result = WebHelper.Post("/api/v1/cuenta", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }
        private NameValueCollection ReverseMap(Cuenta cuenta,string tipo)
        {
            NameValueCollection n = new NameValueCollection();
            if (tipo == "insert")
            {
                n.Add("idCliente", cuenta.idCliente.ToString());
                n.Add("Descripcion", cuenta.Descripcion);
            }
            else if (tipo == "update")
            {
                n.Add("id", cuenta.Id.ToString());
                n.Add("Saldo", cuenta.Saldo.ToString());
            }
            return n;
        }
        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
        public TransactionResult Update(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta, "update");
            string result = WebHelper.Post("/api/v1/cuenta", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }
    }
}
