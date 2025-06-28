using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JewelleryShop.Areas.UserAPI.Controllers
{
    public class RoleApiController : ApiController
    {
        // GET: api/RoleApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RoleApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RoleApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RoleApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RoleApi/5
        public void Delete(int id)
        {
        }
    }
}
