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
	/// 工作流流程实例表
	/// </summary>
    public partial class SysFlowInstance : Entity
    {
        public SysFlowInstance()
        {
          this.InstanceSchemeId= string.Empty;
          this.Code= string.Empty;
          this.CustomName= string.Empty;
          this.ActivityId= string.Empty;
          this.ActivityName= string.Empty;
          this.PreviousId= string.Empty;
          this.SchemeContent= string.Empty;
          this.SchemeId= string.Empty;
          this.DbName= string.Empty;
          this.FrmData= string.Empty;
          this.FrmType= 0;
          this.FrmContentData= string.Empty;
          this.FrmContentParse= string.Empty;
          this.FrmId= string.Empty;
          this.SchemeType= string.Empty;
          this.Disabled= 0;
          this.CreateDate= DateTime.Now;
          this.CreateSysUserId= string.Empty;
          this.CreateSysUserName= string.Empty;
          this.FlowLevel= 0;
          this.Description= string.Empty;
          this.IsFinish= 0;
          this.MakerList= string.Empty;
        }

        /// <summary>
	    /// 流程实例模板Id
	    /// </summary>
        public string InstanceSchemeId { get; set; }
        /// <summary>
	    /// 实例编号
	    /// </summary>
        public string Code { get; set; }
        /// <summary>
	    /// 自定义名称
	    /// </summary>
        public string CustomName { get; set; }
        /// <summary>
	    /// 当前节点ID
	    /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
	    /// 当前节点类型（0会签节点）
	    /// </summary>
        public int? ActivityType { get; set; }
        /// <summary>
	    /// 当前节点名称
	    /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
	    /// 前一个ID
	    /// </summary>
        public string PreviousId { get; set; }
        /// <summary>
	    /// 流程模板内容
	    /// </summary>
        public string SchemeContent { get; set; }
        /// <summary>
	    /// 流程模板ID
	    /// </summary>
        public string SchemeId { get; set; }
        /// <summary>
	    /// 数据库名称
	    /// </summary>
        public string DbName { get; set; }
        /// <summary>
	    /// 表单数据
	    /// </summary>
        public string FrmData { get; set; }
        /// <summary>
	    /// 表单类型
	    /// </summary>
        public int FrmType { get; set; }
        /// <summary>
	    /// 表单中的控件属性描述
	    /// </summary>
        public string FrmContentData { get; set; }
        /// <summary>
	    /// 表单控件位置模板
	    /// </summary>
        public string FrmContentParse { get; set; }
        /// <summary>
	    /// 表单ID
	    /// </summary>
        public string FrmId { get; set; }
        /// <summary>
	    /// 流程类型
	    /// </summary>
        public string SchemeType { get; set; }
        /// <summary>
	    /// 有效标志
	    /// </summary>
        public int Disabled { get; set; }
        /// <summary>
	    /// 创建时间
	    /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
	    /// 创建用户主键
	    /// </summary>
        public string CreateSysUserId { get; set; }
        /// <summary>
	    /// 创建用户
	    /// </summary>
        public string CreateSysUserName { get; set; }
        /// <summary>
	    /// 等级
	    /// </summary>
        public int FlowLevel { get; set; }
        /// <summary>
	    /// 实例备注
	    /// </summary>
        public string Description { get; set; }
        /// <summary>
	    /// 是否完成
	    /// </summary>
        public int IsFinish { get; set; }
        /// <summary>
	    /// 执行人
	    /// </summary>
        public string MakerList { get; set; }

    }
}