using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMSwarehouse.Controllers
{
    public class AOGControllers : Controller
    {
        public IActionResult AOGShow()
        {
            return View();
        }

        public IActionResult Deng()
        {
            return View();
        }
    }
}
