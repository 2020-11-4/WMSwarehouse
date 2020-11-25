using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMSwarehouse.Controllers
{
    public class ck : Controller
    {
        //出库明细
        public IActionResult Outbound()
        {
            return View();
        }
        //采购退货任务
        public IActionResult CGreturnedshow()
        {
            return View();
        }
        //采购退货详情
        public IActionResult particularsshow()
        {
            return View();
        }
    }
}
