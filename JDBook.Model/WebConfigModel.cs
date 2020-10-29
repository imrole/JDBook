using System;
using System.Collections.Generic;
using System.Text;

namespace JDBook.Model
{
    /// <summary>
    /// 服务器配置模型
    /// </summary>
    public class WebConfigModel
    {
        /// <summary>
        /// 微信小程序appid
        /// </summary>
        public string WXAppletAppID { get; set; }

        /// <summary>
        /// 微信小程序密钥
        /// </summary>
        public string WXAppletAppSecret { get; set; }

        /// <summary>
        /// 微信公众号appid
        /// </summary>
        public string WXAppID { get; set; }

        /// <summary>
        /// 微信公众号密钥
        /// </summary>
        public string WXAppSecret { get; set; }

        /// <summary>
        /// sql数据库连接字符串
        /// </summary>
        public string SqlConnStr { get; set; }
    }
}
