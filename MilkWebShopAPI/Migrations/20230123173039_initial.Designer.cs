// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MilkWebShopAPI.Data;

#nullable disable

namespace MilkWebShopAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230123173039_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MilkWebShopAPI.Models.MilkProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Storage")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MilkProducts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("301d5dcf-a2a8-4a34-b26b-efcaa103963c"),
                            Name = "Dillion's unequaled cashew milk",
                            Storage = 99,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            Id = new Guid("1277e861-b33b-485d-b86f-400769d25a82"),
                            Name = "Monet's powerful cashew milk",
                            Storage = 27,
                            Type = "Cashew milk"
                        },
                        new
                        {
                            Id = new Guid("210aeed2-413b-4e53-98e7-62c9f6fd31ba"),
                            Name = "Julianne's relevant pea milk",
                            Storage = 33,
                            Type = "Pea milk"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
