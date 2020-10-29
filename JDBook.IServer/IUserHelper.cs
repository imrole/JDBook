using JDBook.Model.Response;
using JDBook.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDBook.IServer
{
    /// <summary>
    /// 用户帮助类接口
    /// </summary>
    public interface IUserHelper
    {
        /// <summary>
        /// 查询用户是否有效
        /// </summary>
        /// <param name="loginModel">登录模型</param>
        /// <returns></returns>
        public bool SelectUserIsTrue(LoginModel loginModel);

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="registerModel">注册模型</param>
        /// <returns></returns>
        public bool InsertUser(RegisterModel registerModel);

        /// <summary>
        /// 查询用户名是否可用
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        public bool SelectUserNameIsTrue(string userName);
    }
}
