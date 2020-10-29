using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 响应模型
/// </summary>
namespace JDBook.Model.Response
{
    /// <summary>
    /// 统一响应模型
    /// </summary>
    public class ResponseModel
    {
        /// <summary>
        /// 响应状态码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 响应结果
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 响应数据
        /// </summary>
        public dynamic Data { get; set; }
    }
}
