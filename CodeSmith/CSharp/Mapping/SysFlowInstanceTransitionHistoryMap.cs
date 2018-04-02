﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InfosinOpenAuthDB.Repository.Mapping
{
    public partial class SysFlowInstanceTransitionHistoryMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InfosinOpenAuthDB.Repository.Domain.SysFlowInstanceTransitionHistory>
    {
        public SysFlowInstanceTransitionHistoryMap()
        {
            // table
            ToTable("Sys_FlowInstanceTransitionHistory", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.InstanceId)
                .HasColumnName("InstanceId")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.FromNodeId)
                .HasColumnName("FromNodeId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.FromNodeType)
                .HasColumnName("FromNodeType")
                .IsOptional();
            Property(t => t.FromNodeName)
                .HasColumnName("FromNodeName")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.ToNodeId)
                .HasColumnName("ToNodeId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.ToNodeType)
                .HasColumnName("ToNodeType")
                .IsOptional();
            Property(t => t.ToNodeName)
                .HasColumnName("ToNodeName")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.TransitionSate)
                .HasColumnName("TransitionSate")
                .IsRequired();
            Property(t => t.IsFinish)
                .HasColumnName("IsFinish")
                .IsRequired();
            Property(t => t.CreateDate)
                .HasColumnName("CreateDate")
                .IsRequired();
            Property(t => t.CreateSysUserId)
                .HasColumnName("CreateSys_UserId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.CreateSysUserName)
                .HasColumnName("CreateSys_UserName")
                .HasMaxLength(50)
                .IsOptional();

            // Relationships
        }
    }
}
