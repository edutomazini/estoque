using System.Configuration;
using System.Web.Mvc;
using WebEstoque;
using Newtonsoft.Json;
using System.Net;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace WebEstoqueFramework.Controllers
{
    public class HomeController : Controller
    {
        private string UrlApi = ConfigurationManager.AppSettings["UrlApi"];
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            LstProdutos lstProdutos = new LstProdutos();       // => assim nao funciona o JsonConvert
            //List<Produto> lstProdutos = new List<Produto>(); // => Assim nao faz bind com o Model

            var client = new RestClient(UrlApi);

            var request = new RestRequest("/api/produto", Method.GET);

            IRestResponse RestResponseProduto = client.Execute<LstProdutos>(request);
            //IRestResponse RestResponseProduto = client.Execute<List<Produto>>(request);

            if (RestResponseProduto.StatusCode == HttpStatusCode.OK)
            {
                lstProdutos = JsonConvert.DeserializeObject<LstProdutos>(RestResponseProduto.Content);
                //lstProdutos = JsonConvert.DeserializeObject<List<Produto>>(RestResponseProduto.Content);
                return View(lstProdutos);
            }
            else
            {
                return View(RestResponseProduto.Content);
            }
        }

    }
}