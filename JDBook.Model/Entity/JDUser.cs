using System;
using System.Collections.Generic;
using System.Text;

namespace JDBook.Model.Entity
{
    /// <summary>
    /// 数据库映射对象（用户表）
    /// </summary>
    public class JDUser
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int JDUserID { get; set; } 

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
