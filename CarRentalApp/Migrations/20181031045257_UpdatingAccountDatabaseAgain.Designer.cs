﻿// <auto-generated />
using System;
using CarRentalApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRentalApp.Migrations
{
    [DbContext(typeof(RentalModel))]
    [Migration("20181031045257_UpdatingAccountDatabaseAgain")]
    partial class UpdatingAccountDatabaseAgain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarRentalApp.CustomerAccounts", b =>
                {
                    b.Property<int>("CustomerAccountNumber")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CustomerAccountCreationDate");

                    b.Property<string>("CustomerAddress")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerCreditCardNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerDriversLicenseNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerEmailAddress")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerPhoneNumber")
                        .ValueGeneratedOnAdd();

                    b.HasKey("CustomerAccountNumber")
                        .HasName("PK_AccountNumber");

                    b.ToTable("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
