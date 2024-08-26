﻿// <auto-generated />
using System;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AkoAkademiDinamikSite.DataAccessLayer.Migrations
{
    [DbContext(typeof(AkoContext))]
    partial class AkoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Content", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContentId"), 1L, 1);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Template")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ContentId");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Layout", b =>
                {
                    b.Property<int>("LayoutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LayoutId"), 1L, 1);

                    b.Property<string>("FooterPartial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadPartial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderPartial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("ScriptPartial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LayoutId");

                    b.ToTable("Layouts");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Page", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PageId"), 1L, 1);

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MenuOrder")
                        .HasColumnType("int");

                    b.HasKey("PageId");

                    b.HasIndex("ContentId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Page", b =>
                {
                    b.HasOne("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId");

                    b.Navigation("Content");
                });
#pragma warning restore 612, 618
        }
    }
}
