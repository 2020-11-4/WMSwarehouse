using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMSwarehouse.Controllers
{
    public class MoveBusinessController : Controller
    {
        public IActionResult PayableOrder()
        {
            return View();
        }
    }
}
