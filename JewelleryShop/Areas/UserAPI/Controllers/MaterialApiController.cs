using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JewelleryShop.Areas.UserAPI.Controllers
{
    public class MaterialApiController : ApiController
    {
        // GET: api/MaterialApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MaterialApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MaterialApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MaterialApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MaterialApi/5
        public void Delete(int id)
        {
        }
    }
}
