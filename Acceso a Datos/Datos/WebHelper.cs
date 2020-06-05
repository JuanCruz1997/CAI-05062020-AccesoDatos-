using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class WebHelper
    {
        static WebClient client;
        static string rutaBase;
        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            rutaBase = "https://cai-api.azurewebsites.net/";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
        public static string Get(string url)
        {
            var urlCompleta = rutaBase + url;
            var responseString = client.DownloadString(urlCompleta);
            return responseString;
        }
        public static string Post(string url, NameValueCollection parametros)
        {
            var urlCompleta = rutaBase + url;
            var response = client.UploadValues(urlCompleta, parametros);
            var responseString = Encoding.Default.GetString(response);
            return responseString;
        }
    }
}
