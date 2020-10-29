using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 请求模型
/// </summary>
namespace JDBook.Model.Request
{
    /// <summary>
    /// 请求登录模型
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
    }
}
