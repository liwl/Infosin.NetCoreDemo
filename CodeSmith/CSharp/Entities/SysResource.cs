﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace InfosinOpenAuthDB.Repository.Domain
{
    /// <summary>
	/// 资源表
	/// </summary>
    public partial class SysResource : Entity
    {
        public SysResource()
        {
          this.CascadeId= string.Empty;
          this.Key= string.Empty;
          this.Name= string.Empty;
          this.Status= 0;
          this.SortNo= 0;
          this.Description= string.Empty;
          this.ParentId= string.Empty;
          this.AppId= string.Empty;
          this.TypeName= string.Empty;
          this.TypeId= string.Empty;
        }

        /// <summary>
	    /// 节点语义ID
	    /// </summary>
        public string CascadeId { get; set; }
        /// <summary>
	    /// 资源英文唯一标识
	    /// </summary>
        public string Key { get; set; }
        /// <summary>
	    /// 名称
	    /// </summary>
        public string Name { get; set; }
        /// <summary>
	    /// 当前状态
	    /// </summary>
        public int Status { get; set; }
        /// <summary>
	    /// 排序号
	    /// </summary>
        public int SortNo { get; set; }
        /// <summary>
	    /// 描述
	    /// </summary>
        public string Description { get; set; }
        /// <summary>
	    /// 父节点流水号
	    /// </summary>
        public string ParentId { get; set; }
        /// <summary>
	    /// 资源所属应用
	    /// </summary>
        public string AppId { get; set; }
        /// <summary>
	    /// 分类名称
	    /// </summary>
        public string TypeName { get; set; }
        /// <summary>
	    /// 分类ID
	    /// </summary>
        public string TypeId { get; set; }

    }
}