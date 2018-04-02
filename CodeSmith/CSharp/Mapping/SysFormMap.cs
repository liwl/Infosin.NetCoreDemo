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
    public partial class SysFormMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InfosinOpenAuthDB.Repository.Domain.SysForm>
    {
        public SysFormMap()
        {
            // table
            ToTable("Sys_Form", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.Fields)
                .HasColumnName("Fields")
                .IsRequired();
            Property(t => t.ContentData)
                .HasColumnName("ContentData")
                .HasMaxLength(16)
                .IsOptional();
            Property(t => t.ContentParse)
                .HasColumnName("ContentParse")
                .HasMaxLength(16)
                .IsOptional();
            Property(t => t.Content)
                .HasColumnName("Content")
                .HasMaxLength(16)
                .IsOptional();
            Property(t => t.SortCode)
                .HasColumnName("SortCode")
                .IsRequired();
            Property(t => t.Delete)
                .HasColumnName("Delete")
                .IsRequired();
            Property(t => t.DbName)
                .HasColumnName("DbName")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Enabled)
                .HasColumnName("Enabled")
                .IsRequired();
            Property(t => t.Description)
                .HasColumnName("Description")
                .HasMaxLength(200)
                .IsOptional();
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
            Property(t => t.ModifyDate)
                .HasColumnName("ModifyDate")
                .IsOptional();
            Property(t => t.ModifySysUserId)
                .HasColumnName("ModifySys_UserId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.ModifySysUserName)
                .HasColumnName("ModifySys_UserName")
                .HasMaxLength(50)
                .IsOptional();

            // Relationships
        }
    }
}
