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

        public IActionResult Deng(int XId)
        {
            ViewBag.XId = XId;
            return View();
        }

        public IActionResult EXPRESS()
        {
            return View();
        }

        public IActionResult Receiving()
        {
            return View();
        }

        public IActionResult Quick(int XId)
        {
            ViewBag.XId = XId;
            return View();
        }

        public IActionResult Modality()
        {
            return View();
        }

        public IActionResult Arrival()
        {
            return View();
        }

        public IActionResult Task()
        {
            return View();
        }

    }
}
