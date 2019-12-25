using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model.Demo
{

    /// <summary>
    /// 用户
    /// </summary>
    public class TestUserModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 删除标志
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
