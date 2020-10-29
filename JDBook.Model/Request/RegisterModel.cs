using System;
using System.Collections.Generic;
using System.Text;

namespace JDBook.Model.Request
{
    /// <summary>
    /// 请求注册模型
    /// </summary>
    public class RegisterModel
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
