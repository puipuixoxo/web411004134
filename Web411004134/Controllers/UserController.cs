using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411004134.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(string name,string account,string password)
        {
            if (name.IsNullOrWhiteSpace())
            {
                ViewBag.Namemessage = "請輸入姓名";
            }

            if (account.IsNullOrWhiteSpace())
            {
                ViewBag.Accountmessage = "請輸入帳號";
            }

            if (password.IsNullOrWhiteSpace())
            {
                ViewBag.Passwordmessage = "請輸入密碼";
            }

            if (!name.IsNullOrWhiteSpace() && !account.IsNullOrWhiteSpace() && !password.IsNullOrWhiteSpace())
            {
                ViewBag.Message = "註冊成功";
            }

            return View();
        }
    }
}