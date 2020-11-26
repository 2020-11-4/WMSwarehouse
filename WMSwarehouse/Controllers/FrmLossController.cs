using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMSwarehouse.Controllers
{
    public class FrmLossController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }
    }
}
