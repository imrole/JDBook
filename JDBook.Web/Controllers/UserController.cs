using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JDBook.IBLL;
using JDBook.Model.Request;
using JDBook.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace JDBook.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserBLL userBLL;

        public UserController(IUserBLL _userBLL)
        {
            this.userBLL = _userBLL;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LoginByPwd(LoginModel loginModel)
        {
            //LoginModel loginModel = new LoginModel
            //{
            //    UserName = userName,
            //    PassWord = passWord
            //};
            ResponseModel response = userBLL.Login(loginModel);
            return Json(response);
        }

        [HttpPost]
        public JsonResult Register(RegisterModel register)
        {
            return Json(userBLL.Register(register));
        }
    }
}
