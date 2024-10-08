﻿// <auto-generated />
using System;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AkoAkademiDinamikSite.DataAccessLayer.Migrations
{
    [DbContext(typeof(AkoContext))]
    [Migration("20240823063408_mig_newpropforform")]
    partial class mig_newpropforform
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Form", b =>
                {
                    b.Property<int>("FormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormId");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormField", b =>
                {
                    b.Property<int>("FormFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormFieldId"), 1L, 1);

                    b.Property<string>("FieldAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("bit");

                    b.HasKey("FormFieldId");

                    b.HasIndex("FormId");

                    b.ToTable("FormFields");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Media", b =>
                {
                    b.Property<int>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MediaId"), 1L, 1);

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UploadedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("MediaId");

                    b.ToTable("Medias");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Page", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PageId"), 1L, 1);

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<int?>("FormId")
                        .HasColumnType("int");

                    b.Property<int>("MenuOrder")
                        .HasColumnType("int");

                    b.HasKey("PageId");

                    b.HasIndex("ContentId");

                    b.HasIndex("FormId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormField", b =>
                {
                    b.HasOne("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Form", "Form")
                        .WithMany("Fields")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Page", b =>
                {
                    b.HasOne("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId");

                    b.HasOne("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Form", "Form")
                        .WithMany()
                        .HasForeignKey("FormId");

                    b.Navigation("Content");

                    b.Navigation("Form");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Form", b =>
                {
                    b.Navigation("Fields");
                });
#pragma warning restore 612, 618
        }
    }
}
