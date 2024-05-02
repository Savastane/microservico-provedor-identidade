﻿// <auto-generated />
using System;
using Academico.System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Security.API.Migrations
{
    [DbContext(typeof(SystemContext))]
    partial class SystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("system")
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("systemsecurity.domain.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Description");

                    b.Property<Guid>("GuidPlataform")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("GuidPlataform");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("Scope")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Scope");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Application", "system");
                });

            modelBuilder.Entity("systemsecurity.domain.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Command")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Command");

                    b.Property<string>("DataObject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DataObject");

                    b.Property<DateTime>("DateEvent")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateEvent");

                    b.Property<DateTime>("DateProcess")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GuidUser")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("GuidUser");

                    b.Property<int>("IsBlock")
                        .HasColumnType("int");

                    b.Property<int>("IsRemove")
                        .HasColumnType("int");

                    b.Property<int>("ProcessCount")
                        .HasColumnType("int")
                        .HasColumnName("ProcessCount");

                    b.Property<string>("Queue")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Queue");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Status");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Topic");

                    b.HasKey("Id");

                    b.ToTable("Event", "system");
                });

            modelBuilder.Entity("systemsecurity.domain.Platform", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Description");

                    b.Property<int>("IsBlock")
                        .HasColumnType("int");

                    b.Property<int>("IsRemove")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Scope")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Scope");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Slug");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Platform", "system");
                });

            modelBuilder.Entity("systemsecurity.domain.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("ActionUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Description");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GuidApplication")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("GuidApplication");

                    b.Property<string>("IconeOffUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconeOnUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsBlock")
                        .HasColumnType("int");

                    b.Property<int>("IsRemove")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<int?>("Notification")
                        .HasColumnType("int")
                        .HasColumnName("Notification");

                    b.Property<int>("Order")
                        .HasColumnType("int")
                        .HasColumnName("Order");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.ToTable("Resource", "system");
                });

            modelBuilder.Entity("systemsecurity.domain.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GuidApplication")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("GuidApplication");

                    b.Property<int>("IsBlock")
                        .HasColumnType("int");

                    b.Property<int>("IsRemove")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scope")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role", "system");
                });

            modelBuilder.Entity("systemsecurity.domain.Route", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Action");

                    b.Property<string>("CssClass")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("CssClass");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Description");

                    b.Property<Guid>("GuidApplication")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("GuidApplication");

                    b.Property<Guid>("GuidResource")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("GuidResource");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Icon");

                    b.Property<int>("IsAccessOnlyRole")
                        .HasColumnType("int")
                        .HasColumnName("IsAccessOnlyRole");

                    b.Property<int>("IsBlock")
                        .HasColumnType("int");

                    b.Property<int>("IsRemove")
                        .HasColumnType("int");

                    b.Property<int>("Notification")
                        .HasColumnType("int")
                        .HasColumnName("Notification");

                    b.Property<string>("Order")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Order");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Title");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.ToTable("Route", "system");
                });

            modelBuilder.Entity("systemsecurity.domain.Routing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Description");

                    b.Property<Guid>("GuidApplication")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("GuidApplication");

                    b.Property<int>("IsBlock")
                        .HasColumnType("int");

                    b.Property<int>("IsRemove")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Routing", "system");
                });

            modelBuilder.Entity("systemsecurity.domain.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsBlock")
                        .HasColumnType("int");

                    b.Property<int>("IsRemove")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Service", "system");
                });

            modelBuilder.Entity("systemsecurity.domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Document");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Email");

                    b.Property<Guid>("GuidPlataform")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IsBlock")
                        .HasColumnType("int");

                    b.Property<int>("IsRemove")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Password");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Photo");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.HasIndex("GuidPlataform", "Email")
                        .IsUnique();

                    b.ToTable("User", "system");
                });

            modelBuilder.Entity("systemsecurity.domain.Event", b =>
                {
                    b.OwnsOne("system.Security.Entity.Collection.ErroCollection", "ErroCollection", b1 =>
                        {
                            b1.Property<Guid>("EventId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("EventId");

                            b1.ToTable("Event", "system");

                            b1.ToJson("ErroCollection");

                            b1.WithOwner()
                                .HasForeignKey("EventId");

                            b1.OwnsMany("system.Security.Entity.Collection.ErroDocument", "Erros", b2 =>
                                {
                                    b2.Property<Guid>("ErroCollectionEventId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int");

                                    b2.Property<string>("Erro")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<Guid>("Guid")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<DateTime>("Process")
                                        .HasColumnType("datetime2");

                                    b2.HasKey("ErroCollectionEventId", "Id");

                                    b2.ToTable("Event", "system");

                                    b2.WithOwner()
                                        .HasForeignKey("ErroCollectionEventId");
                                });

                            b1.Navigation("Erros");
                        });

                    b.OwnsOne("system.Security.Entity.Collection.LocationDocument", "Location", b1 =>
                        {
                            b1.Property<Guid>("EventId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Cidade")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("GPS")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<Guid>("Guid")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("GuidApplicatoin")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("IP")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Pais")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("EventId");

                            b1.ToTable("Event", "system");

                            b1.ToJson("Location");

                            b1.WithOwner()
                                .HasForeignKey("EventId");
                        });

                    b.Navigation("ErroCollection")
                        .IsRequired();

                    b.Navigation("Location")
                        .IsRequired();
                });

            modelBuilder.Entity("systemsecurity.domain.Platform", b =>
                {
                    b.OwnsOne("system.Security.Entity.Collection.ApplicationCollection", "ApplicationCollection", b1 =>
                        {
                            b1.Property<Guid>("PlatformId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("PlatformId");

                            b1.ToTable("Platform", "system");

                            b1.ToJson("ApplicationCollection");

                            b1.WithOwner()
                                .HasForeignKey("PlatformId");

                            b1.OwnsMany("system.Security.Entity.Collection.ApplicationDocument", "Applications", b2 =>
                                {
                                    b2.Property<Guid>("ApplicationCollectionPlatformId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int");

                                    b2.Property<Guid>("Guid")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Slug")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("ApplicationCollectionPlatformId", "Id");

                                    b2.ToTable("Platform", "system");

                                    b2.WithOwner()
                                        .HasForeignKey("ApplicationCollectionPlatformId");

                                    b2.OwnsMany("system.Security.Entity.Collection.RoleDocument", "Roles", b3 =>
                                        {
                                            b3.Property<Guid>("ApplicationDocumentApplicationCollectionPlatformId")
                                                .HasColumnType("uniqueidentifier");

                                            b3.Property<int>("ApplicationDocumentId")
                                                .HasColumnType("int");

                                            b3.Property<int>("Id")
                                                .ValueGeneratedOnAdd()
                                                .HasColumnType("int");

                                            b3.Property<Guid>("Guid")
                                                .HasColumnType("uniqueidentifier");

                                            b3.Property<string>("Name")
                                                .IsRequired()
                                                .HasColumnType("nvarchar(max)");

                                            b3.HasKey("ApplicationDocumentApplicationCollectionPlatformId", "ApplicationDocumentId", "Id");

                                            b3.ToTable("Platform", "system");

                                            b3.WithOwner()
                                                .HasForeignKey("ApplicationDocumentApplicationCollectionPlatformId", "ApplicationDocumentId");
                                        });

                                    b2.Navigation("Roles");
                                });

                            b1.Navigation("Applications");
                        });

                    b.Navigation("ApplicationCollection");
                });

            modelBuilder.Entity("systemsecurity.domain.Role", b =>
                {
                    b.OwnsOne("system.Security.Entity.Collection.RouteCollection", "RouteCollection", b1 =>
                        {
                            b1.Property<Guid>("RoleId")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("RoleId");

                            b1.ToTable("Role", "system");

                            b1.ToJson("RouteCollection");

                            b1.WithOwner()
                                .HasForeignKey("RoleId");

                            b1.OwnsMany("system.Security.Entity.Collection.RouteDocument", "Routes", b2 =>
                                {
                                    b2.Property<Guid>("RouteCollectionRoleId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int");

                                    b2.Property<Guid>("Guid")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Title")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("RouteCollectionRoleId", "Id");

                                    b2.ToTable("Role", "system");

                                    b2.WithOwner()
                                        .HasForeignKey("RouteCollectionRoleId");
                                });

                            b1.Navigation("Routes");
                        });

                    b.Navigation("RouteCollection");
                });

            modelBuilder.Entity("systemsecurity.domain.Routing", b =>
                {
                    b.OwnsOne("system.Security.Entity.Collection.RouteCollection", "RouterCollection", b1 =>
                        {
                            b1.Property<Guid>("RoutingId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("RoutingId");

                            b1.ToTable("Routing", "system");

                            b1.ToJson("RouterCollection");

                            b1.WithOwner()
                                .HasForeignKey("RoutingId");

                            b1.OwnsMany("system.Security.Entity.Collection.RouteDocument", "Routes", b2 =>
                                {
                                    b2.Property<Guid>("RouteCollectionRoutingId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int");

                                    b2.Property<Guid>("Guid")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Title")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("RouteCollectionRoutingId", "Id");

                                    b2.ToTable("Routing", "system");

                                    b2.WithOwner()
                                        .HasForeignKey("RouteCollectionRoutingId");
                                });

                            b1.Navigation("Routes");
                        });

                    b.Navigation("RouterCollection");
                });

            modelBuilder.Entity("systemsecurity.domain.User", b =>
                {
                    b.OwnsOne("system.Security.Entity.Collection.OrganizationCollection", "OrganizationCollection", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("UserId");

                            b1.ToTable("User", "system");

                            b1.ToJson("OrganizationCollection");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.OwnsMany("system.Security.Entity.Collection.OrganizationDocument", "Organizations", b2 =>
                                {
                                    b2.Property<Guid>("OrganizationCollectionUserId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int");

                                    b2.Property<Guid>("Guid")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Slug")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.HasKey("OrganizationCollectionUserId", "Id");

                                    b2.ToTable("User", "system");

                                    b2.WithOwner()
                                        .HasForeignKey("OrganizationCollectionUserId");

                                    b2.OwnsMany("system.Security.Entity.Collection.ApplicationDocument", "Applications", b3 =>
                                        {
                                            b3.Property<Guid>("OrganizationDocumentOrganizationCollectionUserId")
                                                .HasColumnType("uniqueidentifier");

                                            b3.Property<int>("OrganizationDocumentId")
                                                .HasColumnType("int");

                                            b3.Property<int>("Id")
                                                .ValueGeneratedOnAdd()
                                                .HasColumnType("int");

                                            b3.Property<Guid>("Guid")
                                                .HasColumnType("uniqueidentifier");

                                            b3.Property<string>("Slug")
                                                .IsRequired()
                                                .HasColumnType("nvarchar(max)");

                                            b3.HasKey("OrganizationDocumentOrganizationCollectionUserId", "OrganizationDocumentId", "Id");

                                            b3.ToTable("User", "system");

                                            b3.WithOwner()
                                                .HasForeignKey("OrganizationDocumentOrganizationCollectionUserId", "OrganizationDocumentId");

                                            b3.OwnsMany("system.Security.Entity.Collection.RoleDocument", "Roles", b4 =>
                                                {
                                                    b4.Property<Guid>("ApplicationDocumentOrganizationDocumentOrganizationCollectionUserId")
                                                        .HasColumnType("uniqueidentifier");

                                                    b4.Property<int>("ApplicationDocumentOrganizationDocumentId")
                                                        .HasColumnType("int");

                                                    b4.Property<int>("ApplicationDocumentId")
                                                        .HasColumnType("int");

                                                    b4.Property<int>("Id")
                                                        .ValueGeneratedOnAdd()
                                                        .HasColumnType("int");

                                                    b4.Property<Guid>("Guid")
                                                        .HasColumnType("uniqueidentifier");

                                                    b4.Property<string>("Name")
                                                        .IsRequired()
                                                        .HasColumnType("nvarchar(max)");

                                                    b4.HasKey("ApplicationDocumentOrganizationDocumentOrganizationCollectionUserId", "ApplicationDocumentOrganizationDocumentId", "ApplicationDocumentId", "Id");

                                                    b4.ToTable("User", "system");

                                                    b4.WithOwner()
                                                        .HasForeignKey("ApplicationDocumentOrganizationDocumentOrganizationCollectionUserId", "ApplicationDocumentOrganizationDocumentId", "ApplicationDocumentId");
                                                });

                                            b3.Navigation("Roles");
                                        });

                                    b2.Navigation("Applications");
                                });

                            b1.Navigation("Organizations");
                        });

                    b.OwnsOne("system.Security.Entity.Collection.ResourceCollection", "Allow", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("UserId");

                            b1.ToTable("User", "system");

                            b1.ToJson("Allow");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.OwnsMany("system.Security.Entity.Collection.ResourceDocument", "Resources", b2 =>
                                {
                                    b2.Property<Guid>("ResourceCollectionUserId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int");

                                    b2.Property<Guid>("Guid")
                                        .HasColumnType("uniqueidentifier");

                                    b2.HasKey("ResourceCollectionUserId", "Id");

                                    b2.ToTable("User", "system");

                                    b2.WithOwner()
                                        .HasForeignKey("ResourceCollectionUserId");
                                });

                            b1.Navigation("Resources");
                        });

                    b.OwnsOne("system.Security.Entity.Collection.ResourceCollection", "Deny", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("UserId");

                            b1.ToTable("User", "system");

                            b1.ToJson("Deny");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.OwnsMany("system.Security.Entity.Collection.ResourceDocument", "Resources", b2 =>
                                {
                                    b2.Property<Guid>("ResourceCollectionUserId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int");

                                    b2.Property<Guid>("Guid")
                                        .HasColumnType("uniqueidentifier");

                                    b2.HasKey("ResourceCollectionUserId", "Id");

                                    b2.ToTable("User", "system");

                                    b2.WithOwner()
                                        .HasForeignKey("ResourceCollectionUserId");
                                });

                            b1.Navigation("Resources");
                        });

                    b.Navigation("Allow");

                    b.Navigation("Deny");

                    b.Navigation("OrganizationCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
