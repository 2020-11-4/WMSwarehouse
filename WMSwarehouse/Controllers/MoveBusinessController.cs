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
        //调拨物品详情
<<<<<<< HEAD:WMSwarehouse/WMSwarehouse/Controllers/MoveBusinessController.cs
        public IActionResult Particulars(int MId1)
=======
        public IActionResult Particulars()
>>>>>>> 70fb654258a83fbcfe18432f663d27ce3269e551:WMSwarehouse/Controllers/MoveBusinessController.cs
        {
            ViewBag.MId1 = MId1;
            return View();
        }
        //补货需求列表
        public IActionResult Replenishment()
        {
            return View();
        }
        //补货需求详情
        public IActionResult Itemdetails()
        {
            return View();
        }
        //调拨审核
        public IActionResult Audit()
        {
            return View();
        }

<<<<<<< HEAD:WMSwarehouse/WMSwarehouse/Controllers/MoveBusinessController.cs
        //查看
        public IActionResult Examine()
        {
            return View();
        }
        //调拨发配区
        public IActionResult Banish()
        {
            return View();
        }

=======
>>>>>>> 70fb654258a83fbcfe18432f663d27ce3269e551:WMSwarehouse/Controllers/MoveBusinessController.cs
    }
}
