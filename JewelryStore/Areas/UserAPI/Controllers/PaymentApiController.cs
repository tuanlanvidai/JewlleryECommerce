﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JewelleryShop.Areas.UserAPI.Controllers
{
    public class PaymentApiController : ApiController
    {
        // GET: api/PaymentApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PaymentApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PaymentApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PaymentApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PaymentApi/5
        public void Delete(int id)
        {
        }
    }
}
