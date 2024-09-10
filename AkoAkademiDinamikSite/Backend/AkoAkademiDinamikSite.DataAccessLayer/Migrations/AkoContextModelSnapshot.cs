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

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Form", b =>
                {
                    b.Property<int>("FormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowTitle")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormId");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormElement", b =>
                {
                    b.Property<int>("FormElementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormElementId"), 1L, 1);

                    b.Property<string>("ControlType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormElementId");

                    b.HasIndex("FormId");

                    b.ToTable("FormElements");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormElementResponse", b =>
                {
                    b.Property<int>("FormElementResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormElementResponseId"), 1L, 1);

                    b.Property<int>("FormElementId")
                        .HasColumnType("int");

                    b.Property<int?>("FormResponseId")
                        .HasColumnType("int");

                    b.Property<string>("ResponseValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormElementResponseId");

                    b.HasIndex("FormElementId");

                    b.HasIndex("FormResponseId");

                    b.ToTable("ForElementResponses");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormOption", b =>
                {
                    b.Property<int>("FormOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormOptionId"), 1L, 1);

                    b.Property<int>("FormElementId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsSelected")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormOptionId");

                    b.HasIndex("FormElementId");

                    b.ToTable("FormOptions");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormResponse", b =>
                {
                    b.Property<int>("FormResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormResponseId"), 1L, 1);

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.HasKey("FormResponseId");

                    b.HasIndex("FormId");

                    b.ToTable("FormResponses");
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

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormElement", b =>
                {
                    b.HasOne("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Form", "Form")
                        .WithMany("FormElements")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormElementResponse", b =>
                {
                    b.HasOne("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormElement", "FormElement")
                        .WithMany()
                        .HasForeignKey("FormElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormResponse", null)
                        .WithMany("FormElementResponses")
                        .HasForeignKey("FormResponseId");

                    b.Navigation("FormElement");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormOption", b =>
                {
                    b.HasOne("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormElement", "FormElement")
                        .WithMany("FormOptions")
                        .HasForeignKey("FormElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormElement");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormResponse", b =>
                {
                    b.HasOne("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Form", "Form")
                        .WithMany()
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

                    b.Navigation("Content");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.Form", b =>
                {
                    b.Navigation("FormElements");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormElement", b =>
                {
                    b.Navigation("FormOptions");
                });

            modelBuilder.Entity("AkoAkademiDinamikSite.EntityLayer.ReelConcrete.FormResponse", b =>
                {
                    b.Navigation("FormElementResponses");
                });
#pragma warning restore 612, 618
        }
    }
}
