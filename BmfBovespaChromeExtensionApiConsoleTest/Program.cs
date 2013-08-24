using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BmfBovespaChromeExtensionApiConsoleTest.Model;
using RestSharp;
using ServiceStack.ServiceClient.Web;
using ServiceStack.Text;

namespace BmfBovespaChromeExtensionApiConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseUri = "http://bmf.chromestudio.com.br/server/api/";
           
            var client = new RestClient(baseUri);
            var request = new RestRequest("acoes.php", Method.POST);
            request.AddParameter("e", "pontos");
            request.AddParameter("codigo", "PETRI14");

            var response = client.Execute<Wrapper>(request);
            var cotacao = JsonSerializer.DeserializeFromString<Wrapper>(response.Content).desc;

        }
    }
}
