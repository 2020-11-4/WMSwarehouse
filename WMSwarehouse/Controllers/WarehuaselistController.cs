using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMSwarehouse.Controllers
{
    public class WarehuaselistController : Controller
    {
        //添加
        public IActionResult Add()
        {
            return View();
        }
        //显示库区管理
        public IActionResult GoodsShow() 
        {
            return View();
        }
        //显示货位管理
        public IActionResult GetGoodsallocation() 
        {
            return View();
        }
        //显示库员管理
        public IActionResult Administrators()
        {
            return View();
        }
        //显示仓库权限
        public IActionResult Controllerships() 
        {
            return View();
        }

    }
}
