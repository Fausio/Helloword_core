using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helloword_core.Test
{
    //[Controller]
    public class Test: Controller
    {

        public string Index()
        {
            return "Hello from HomeController TEST.CS";
        }

        public string About()
        {
            return "About";
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
