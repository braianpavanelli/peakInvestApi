using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PeakInvestApi.Controllers
{
    [AllowAnonymous]
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ConsultaUsuarioController : ApiController
    {
        // GET: api/ConsultaUsuario
        [HttpGet]
        public IEnumerable<KeyValuePair<int, string>> Get()
        {
            var lista = new List<KeyValuePair<int, string>>();
            lista.Add(new KeyValuePair<int, string>(1, "João"));
            lista.Add(new KeyValuePair<int, string>(2, "Maria"));
            lista.Add(new KeyValuePair<int, string>(3, "Ana"));

            return lista;
        }

        // GET: api/ConsultaUsuario/5
        [HttpGet]
        public string Get(int id)
        {
            var lista = new List<KeyValuePair<int, string>>();
            lista.Add(new KeyValuePair<int, string>(1, "João"));
            lista.Add(new KeyValuePair<int, string>(2, "Maria"));
            lista.Add(new KeyValuePair<int, string>(3, "Ana"));

            return lista.Where(l => l.Key == id).SingleOrDefault().Value;
        }
    }
}
