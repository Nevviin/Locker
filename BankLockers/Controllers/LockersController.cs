using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankLockers.Models;

namespace BankLockers.Controllers
{
    public class LockersController : Controller
    {
        // GET: Lockers
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetLockerList()
        {
            var lockerRepository = new LockerRepository();
            var lockerRepositoryList = lockerRepository.GetLockerList();

            return Json(new { lockerRepositoryList });

        }
    }
}