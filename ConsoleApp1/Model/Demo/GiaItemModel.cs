using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    public class GiaItemModel
    {
        /// <summary>
		/// 主键
		/// </summary>
        public virtual System.Int64 PhId
        {
            get;
            set;
        }

        /// <summary>
        /// 父级 默认0
        /// </summary>
        public virtual System.Int64 Parentid
        {
            get;
            set;
        }

        /// <summary>
        /// 组织id
        /// </summary>
        public virtual System.Int64 Orgid
        {
            get;
            set;
        }

        /// <summary>
        /// 类型
        /// </summary>
        public virtual System.String Type
        {
            get;
            set;
        }

        /// <summary>
        /// 编码
        /// </summary>       
        public virtual System.String Encode
        {
            get;
            set;
        }

        /// <summary>
        /// 名称
        /// </summary>        
        public virtual System.String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 层次
        /// </summary>       
        public virtual System.Int32 Levels
        {
            get;
            set;
        }

        /// <summary>
        /// 排序码
        /// </summary>        
        public virtual System.Int32 SortOrder
        {
            get;
            set;
        }

        /// <summary>
        /// 系统内置
        /// </summary>        
        public virtual System.Byte IsSystem
        {
            get;
            set;
        }

        /// <summary>
        /// 删除标志
        /// </summary>       
        public virtual System.Byte DelFlag
        {
            get;
            set;
        }

        /// <summary>
        /// 有效标志
        /// </summary>       
        public virtual System.Byte Enabledmark
        {
            get;
            set;
        }

        /// <summary>
        /// 描述
        /// </summary>        
        public virtual System.String Description
        {
            get;
            set;
        }
    }
}
