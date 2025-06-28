using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JewelleryShop.Areas.UserAPI.Controllers
{
    public class SizeApiController : ApiController
    {
        // GET: api/SizeApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SizeApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SizeApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SizeApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SizeApi/5
        public void Delete(int id)
        {
        }
    }
}
