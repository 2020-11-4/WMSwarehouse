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
        //出库任务单
        public IActionResult CKout()
        {
            return View();
        }
        //产品出库任务单详情
        public IActionResult CPoutshow()
        {
            return View();
        }
        //产品出库任务单详情
        public IActionResult CKrecord()
        {
            return View();
        }
        //添加出库任务
        public IActionResult outtask()
        {
            return View();
        }
        //添加盘点任务
        public IActionResult PDAdd()
        {
            return View();
        }
        //盘点任务管理未盘点
        public IActionResult wpdshow()
        {
            return View();
        }
        //盘点任务管理已盘点
        public IActionResult ypdshow()
        {
            return View();
        }
        //未盘点详情
        public IActionResult xiangqing()
        {
            return View();
        }
    }
}
