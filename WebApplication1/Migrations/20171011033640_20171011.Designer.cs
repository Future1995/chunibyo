﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication1.DAL;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20171011033640_20171011")]
    partial class _20171011
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("WebApplication1.Models.PlayList", b =>
                {
                    b.Property<int>("PlayListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoverImgUrl")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId");

                    b.HasKey("PlayListId");

                    b.HasIndex("UserId");

                    b.ToTable("PlayList");
                });

            modelBuilder.Entity("WebApplication1.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Album")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AlbumId")
                        .HasMaxLength(30);

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ArtistId")
                        .HasMaxLength(30);

                    b.Property<string>("ImgUrl")
                        .HasMaxLength(200);

                    b.Property<int>("PlayListId");

                    b.Property<string>("Source")
                        .HasMaxLength(20);

                    b.Property<string>("SourceUrl")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .HasMaxLength(200);

                    b.HasKey("TrackId");

                    b.HasIndex("PlayListId");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dt");

                    b.Property<DateTime>("LoginDt");

                    b.Property<string>("PassWord")
                        .HasMaxLength(32);

                    b.Property<string>("UserName")
                        .HasMaxLength(20);

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebApplication1.Models.PlayList", b =>
                {
                    b.HasOne("WebApplication1.Models.User", "User")
                        .WithMany("PlayLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Track", b =>
                {
                    b.HasOne("WebApplication1.Models.PlayList", "PlayList")
                        .WithMany("Tracks")
                        .HasForeignKey("PlayListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
