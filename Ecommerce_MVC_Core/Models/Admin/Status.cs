﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PROG7311_TASK2.Models.Admin
{
    public class Status:BaseEntity
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
        public  OrderStatus OrderStatus { get; set; }
    }

    public class StatusMap
    {
        public StatusMap(EntityTypeBuilder<Status> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Name).HasMaxLength(100);
            entityTypeBuilder.Property(x => x.Level).HasMaxLength(100);
            entityTypeBuilder.Property(x => x.Description).HasMaxLength(200);

        }
    }
}