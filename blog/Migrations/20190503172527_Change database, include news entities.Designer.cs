﻿// <auto-generated />
using blog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace blog.Migrations
{
    [DbContext(typeof(CrossBlogDbContext))]
    [Migration("20190503172527_Change database, include news entities")]
    partial class Changedatabaseincludenewsentities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("blog.Domain.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("Created_At");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Published");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("blog.Domain.ArticleTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleId");

                    b.Property<DateTime>("Created_At");

                    b.Property<int>("TagId");

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("TagId");

                    b.ToTable("ArticleTag");
                });

            modelBuilder.Entity("blog.Domain.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created_At");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<int?>("MediaId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("Id");

                    b.HasIndex("MediaId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("blog.Domain.AuthorArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleId");

                    b.Property<int>("AuthorId");

                    b.Property<DateTime>("Created_At");

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("AuthorId");

                    b.ToTable("AuthorArticle");
                });

            modelBuilder.Entity("blog.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created_At");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("blog.Domain.CategoryArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleId");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("Created_At");

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryArticle");
                });

            modelBuilder.Entity("blog.Domain.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArticleId");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("Created_At");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("Published");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("blog.Domain.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("Created_At");

                    b.Property<string>("Footer");

                    b.Property<string>("Head");

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("blog.Domain.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created_At");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Path")
                        .IsRequired();

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("Id");

                    b.ToTable("Medias");
                });

            modelBuilder.Entity("blog.Domain.MediaArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleId");

                    b.Property<DateTime>("Created_At");

                    b.Property<int>("MediaId");

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("MediaId");

                    b.ToTable("MediaArticle");
                });

            modelBuilder.Entity("blog.Domain.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created_At");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("Updated_At");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("blog.Domain.ArticleTag", b =>
                {
                    b.HasOne("blog.Domain.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("blog.Domain.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("blog.Domain.Author", b =>
                {
                    b.HasOne("blog.Domain.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaId");
                });

            modelBuilder.Entity("blog.Domain.AuthorArticle", b =>
                {
                    b.HasOne("blog.Domain.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("blog.Domain.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("blog.Domain.CategoryArticle", b =>
                {
                    b.HasOne("blog.Domain.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("blog.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("blog.Domain.Comment", b =>
                {
                    b.HasOne("blog.Domain.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("blog.Domain.MediaArticle", b =>
                {
                    b.HasOne("blog.Domain.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("blog.Domain.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
