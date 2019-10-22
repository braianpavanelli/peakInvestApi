using System.Web.Http;
using System.Web.Http.Cors;

namespace PeakInvestApi.Controllers
{
    [AllowAnonymous]
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CalculoController : ApiController
    {
        // GET: api/Calculo
        [HttpGet]
        public double Get(double valor, int numParcelas)
        {
            return (valor * numParcelas) * 1.05;
        }
    }
}
