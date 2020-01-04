using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Helloword_core.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Index")]
        // GET: /<controller>/
        public string Index()
        {
            return "Hello from HomeController";
        }
         
        [Route("About")]
        public string About()
        {
            return "About";
        }
    }
}
