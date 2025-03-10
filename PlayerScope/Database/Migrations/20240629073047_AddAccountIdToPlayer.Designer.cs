﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayerScope.Database;

#nullable disable

namespace PlayerScope.Database.Migrations
{
    [DbContext(typeof(RetainerTrackContext))]
    [Migration("20240629073047_AddAccountIdToPlayer")]
    partial class AddAccountIdToPlayer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("RetainerTrack.Database.Player", b =>
                {
                    b.Property<ulong>("LocalContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("LocalContentId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("RetainerTrack.Database.Retainer", b =>
                {
                    b.Property<ulong>("LocalContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<ulong>("OwnerLocalContentId")
                        .HasColumnType("INTEGER");

                    b.Property<ushort>("WorldId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LocalContentId");

                    b.ToTable("Retainers");
                });
#pragma warning restore 612, 618
        }
    }
}
