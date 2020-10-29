using JDBook.Model.Request;
using JDBook.Model.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDBook.IBLL
{
    /// <summary>
    /// 用户业务逻辑接口
    /// </summary>
    public interface IUserBLL
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="loginModel">登录模型</param>
        /// <returns></returns>
        public ResponseModel Login(LoginModel loginModel);

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="registerModel">注册模型</param>
        /// <returns></returns>
        public ResponseModel Register(RegisterModel registerModel);
    }
}
