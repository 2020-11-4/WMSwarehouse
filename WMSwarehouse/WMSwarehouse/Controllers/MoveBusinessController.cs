using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMSwarehouse.Controllers
{
    public class MoveBusinessController : Controller
    {
        //调拨单列表
        public IActionResult PayableOrder()
        {
            return View();
        }
        //调拨详情信息
        public IActionResult Particulars()
        {
            return View();
        }
    }
}
