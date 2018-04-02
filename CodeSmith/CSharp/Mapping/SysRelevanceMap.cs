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
    public partial class SysRelevanceMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InfosinOpenAuthDB.Repository.Domain.SysRelevance>
    {
        public SysRelevanceMap()
        {
            // table
            ToTable("Sys_Relevance", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Description)
                .HasColumnName("Description")
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.Key)
                .HasColumnName("Key")
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.Status)
                .HasColumnName("Status")
                .IsRequired();
            Property(t => t.OperateTime)
                .HasColumnName("OperateTime")
                .IsRequired();
            Property(t => t.OperatorId)
                .HasColumnName("OperatorId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.FirstId)
                .HasColumnName("FirstId")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.SecondId)
                .HasColumnName("SecondId")
                .HasMaxLength(50)
                .IsRequired();

            // Relationships
        }
    }
}
