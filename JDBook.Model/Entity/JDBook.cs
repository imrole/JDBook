using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 数据库-模型映射
/// </summary>
namespace JDBook.Model.Entity
{
    /// <summary>
    /// 数据库映射对象（图书表）
    /// </summary>
    public class JDBook
    {
        /// <summary>
        /// 图书ID
        /// </summary>
        public int JDBookID { get; set; } 

        /// <summary>
        /// 图书
        /// </summary>
        public string BookName { get; set; } 

        /// <summary>
        /// 图书种类
        /// </summary>
        public int BookType { get; set; }

        /// <summary>
        /// 图书图片
        /// </summary>
        public string BookImage { get; set; }

        /// <summary>
        /// 图书价格
        /// </summary>
        public float BookMoney { get; set; }
    }
}
