﻿// <auto-generated />
using System;
using HWMvcPartThree.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HWMvcPartThree.Migrations
{
    [DbContext(typeof(MvcContextPThree))]
    [Migration("20211103054817_addCom")]
    partial class addCom
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("HWMvcPartThree.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneCompanyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PhoneCompanyId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("HWMvcPartThree.Models.PhoneCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PhoneCompanies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Xiaomi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Huawei"
                        });
                });

            modelBuilder.Entity("HWMvcPartThree.Models.Phone", b =>
                {
                    b.HasOne("HWMvcPartThree.Models.PhoneCompany", "PhoneCompany")
                        .WithMany("Phones")
                        .HasForeignKey("PhoneCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhoneCompany");
                });

            modelBuilder.Entity("HWMvcPartThree.Models.PhoneCompany", b =>
                {
                    b.Navigation("Phones");
                });
#pragma warning restore 612, 618
        }
    }
}
