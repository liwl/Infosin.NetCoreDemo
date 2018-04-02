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
    public partial class SysStockMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InfosinOpenAuthDB.Repository.Domain.SysStock>
    {
        public SysStockMap()
        {
            // table
            ToTable("Sys_Stock", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(500)
                .IsRequired();
            Property(t => t.Number)
                .HasColumnName("Number")
                .IsRequired();
            Property(t => t.Price)
                .HasColumnName("Price")
                .HasPrecision(10, 1)
                .IsRequired();
            Property(t => t.Status)
                .HasColumnName("Status")
                .IsRequired();
            Property(t => t.Viewable)
                .HasColumnName("Viewable")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.SysUser)
                .HasColumnName("Sys_User")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Time)
                .HasColumnName("Time")
                .IsRequired();
            Property(t => t.OrgId)
                .HasColumnName("OrgId")
                .HasMaxLength(50)
                .IsOptional();

            // Relationships
        }
    }
}
