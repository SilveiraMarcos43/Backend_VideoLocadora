﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SVL.Infra.Data;

namespace SVL.Infra.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20181101180517_LocationStatus")]
    partial class LocationStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SVL.Domain.Base.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("StreetDescription")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("ID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("SVL.Domain.Base.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone");

                    b.HasKey("ID");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("SVL.Domain.Base.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("date");

                    b.Property<string>("Name");

                    b.Property<int>("Sexo");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("SVL.Domain.Base.Media", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Genero");

                    b.Property<bool>("IsRelease");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("SVL.Domain.Devolution.Devolution", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<int>("DevolutionStatus");

                    b.Property<bool>("IsFinished");

                    b.Property<int>("LocationId");

                    b.HasKey("ID");

                    b.ToTable("Devolution");
                });

            modelBuilder.Entity("SVL.Domain.Location.LocationAggregate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("LocationStatus");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("SVL.Domain.Location.Wallet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreditPoints")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID");

                    b.HasKey("ID");

                    b.ToTable("Credit");
                });

            modelBuilder.Entity("SVL.Infra.Entities.MediaLocation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<bool>("IsRewound");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int>("MediaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LocationID");

                    b.HasIndex("MediaID");

                    b.ToTable("MediaLocation");
                });

            modelBuilder.Entity("SVL.Domain.Base.Contact", b =>
                {
                    b.HasOne("SVL.Domain.Base.Customer", "Customer")
                        .WithMany("Contacts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SVL.Infra.Entities.MediaLocation", b =>
                {
                    b.HasOne("SVL.Domain.Location.LocationAggregate", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SVL.Domain.Base.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
