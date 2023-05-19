﻿// <auto-generated />
using System;
using Equb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Equb.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230516201427_AddMemberInviteModel")]
    partial class AddMemberInviteModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Equb.Models.EqubInfo", b =>
                {
                    b.Property<int>("EqubInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AdminId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("EqubName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FrequencyDays")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("EqubInfoId");

                    b.ToTable("EqubInfo");
                });

            modelBuilder.Entity("Equb.Models.MemberInvite", b =>
                {
                    b.Property<int>("MemberInviteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Accepted")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Declined")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EqubId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("InviteDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("InviteeUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InviterUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ReplyDate")
                        .HasColumnType("TEXT");

                    b.HasKey("MemberInviteId");

                    b.ToTable("MemberInvites");
                });

            modelBuilder.Entity("Equb.Models.Users", b =>
                {
                    b.Property<int>("UsersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("SignUpDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("UsersId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
