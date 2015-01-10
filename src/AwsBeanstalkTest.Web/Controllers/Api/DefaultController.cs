using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AwsBeanstalkTest.Web.Controllers.Api
{
    public class DefaultController : ApiController
    {
        public string Get()
        {
            return "PETER CTO DEPLOY HALLØJ";
        }
    }
}
