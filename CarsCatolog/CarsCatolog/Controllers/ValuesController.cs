using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarsCatolog.Controllers
{
    public class ValuesController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "SUV", "Celta", "Sedan" };
        }
        public ActionResult <string> Get(int id)
        {
            return "value";
        }
    }
}
