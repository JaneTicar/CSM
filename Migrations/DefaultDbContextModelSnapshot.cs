﻿using Jane.Csm.Web.Infrastructure.Data.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jane.Csm.Web.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GoshenJimenez.MercadiaII.Web.Infrastructure.Data.Models.User", b =>
            {
                b.Property<Guid?>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("EmailAddress");

                b.Property<string>("FirstName");

                b.Property<int>("Gender");

                b.Property<string>("LastName");

                b.Property<int>("LoginStatus");

                b.Property<int>("LoginTrials");

                b.Property<string>("Password");

                b.Property<string>("RegistrationCode");

                b.Property<DateTime>("Timestamp");

                b.HasKey("Id");

                b.ToTable("Users");
            });
#pragma warning restore 612, 618
        }
    }
}

