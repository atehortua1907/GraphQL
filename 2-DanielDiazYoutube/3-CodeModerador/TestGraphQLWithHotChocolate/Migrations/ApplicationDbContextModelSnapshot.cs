﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestGraphQLWithHotChocolate;

namespace TestGraphQLWithHotChocolate.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TestGraphQLWithHotChocolate.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("64553146-c836-49eb-ad87-a8c639a4f054"),
                            Name = "Microsoft"
                        },
                        new
                        {
                            Id = new Guid("00553146-c836-49eb-ad87-a8c639a4f054"),
                            Name = "Google"
                        });
                });

            modelBuilder.Entity("TestGraphQLWithHotChocolate.Opportunity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Opportunities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bab9706e-deb7-4b55-a145-79245fad3608"),
                            AccountId = new Guid("64553146-c836-49eb-ad87-a8c639a4f054"),
                            OwnerId = new Guid("f0c74a06-1849-4ad7-a28f-3981697c3e71"),
                            Subject = "Oportunidad 1"
                        },
                        new
                        {
                            Id = new Guid("47fb11ed-f63f-48a9-83d8-89cea36e4de3"),
                            AccountId = new Guid("64553146-c836-49eb-ad87-a8c639a4f054"),
                            OwnerId = new Guid("f0c74a06-1849-4ad7-a28f-3981697c3e71"),
                            Subject = "Oportunidad 2"
                        },
                        new
                        {
                            Id = new Guid("00fb11ed-f63f-48a9-83d8-89cea36e4de3"),
                            AccountId = new Guid("00553146-c836-49eb-ad87-a8c639a4f054"),
                            OwnerId = new Guid("f0c74a06-1849-4ad7-a28f-3981697c3e71"),
                            Subject = "Oportunidad 3"
                        });
                });

            modelBuilder.Entity("TestGraphQLWithHotChocolate.SystemUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f0c74a06-1849-4ad7-a28f-3981697c3e71"),
                            Email = "daniel@diaz.com",
                            Name = "Daniel Diaz"
                        });
                });

            modelBuilder.Entity("TestGraphQLWithHotChocolate.Opportunity", b =>
                {
                    b.HasOne("TestGraphQLWithHotChocolate.Account", "Account")
                        .WithMany("Opportunities")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestGraphQLWithHotChocolate.SystemUser", "Owner")
                        .WithMany("Opportunities")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("TestGraphQLWithHotChocolate.Account", b =>
                {
                    b.Navigation("Opportunities");
                });

            modelBuilder.Entity("TestGraphQLWithHotChocolate.SystemUser", b =>
                {
                    b.Navigation("Opportunities");
                });
#pragma warning restore 612, 618
        }
    }
}
