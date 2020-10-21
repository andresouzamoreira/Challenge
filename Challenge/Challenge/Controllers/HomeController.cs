using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public Apresentacao Index()
        {
            return new Apresentacao();
        }
    }
}
