using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SHeDSchedule.Repository;

namespace SHeDSchedule.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("SHeDSchedule.Models.Friday", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<char>("eight");

                    b.Property<char>("eightthirty");

                    b.Property<char>("eleven");

                    b.Property<char>("eleventhirty");

                    b.Property<char>("five");

                    b.Property<char>("fivethirty");

                    b.Property<char>("four");

                    b.Property<char>("fourthirty");

                    b.Property<char>("nine");

                    b.Property<char>("ninethirty");

                    b.Property<char>("one");

                    b.Property<char>("onethirty");

                    b.Property<char>("seventhirty");

                    b.Property<char>("six");

                    b.Property<char>("sixthirty");

                    b.Property<int>("staffId");

                    b.Property<char>("ten");

                    b.Property<char>("tenthirty");

                    b.Property<char>("three");

                    b.Property<char>("threethirty");

                    b.Property<char>("twelve");

                    b.Property<char>("twelvethirty");

                    b.Property<char>("two");

                    b.Property<char>("twothirty");

                    b.HasKey("id");

                    b.HasIndex("staffId");

                    b.ToTable("Friday");
                });

            modelBuilder.Entity("SHeDSchedule.Models.Monday", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<char>("eight");

                    b.Property<char>("eightthirty");

                    b.Property<char>("eleven");

                    b.Property<char>("eleventhirty");

                    b.Property<char>("five");

                    b.Property<char>("fivethirty");

                    b.Property<char>("four");

                    b.Property<char>("fourthirty");

                    b.Property<char>("nine");

                    b.Property<char>("ninethirty");

                    b.Property<char>("one");

                    b.Property<char>("onethirty");

                    b.Property<char>("seventhirty");

                    b.Property<char>("six");

                    b.Property<char>("sixthirty");

                    b.Property<int>("staffId");

                    b.Property<char>("ten");

                    b.Property<char>("tenthirty");

                    b.Property<char>("three");

                    b.Property<char>("threethirty");

                    b.Property<char>("twelve");

                    b.Property<char>("twelvethirty");

                    b.Property<char>("two");

                    b.Property<char>("twothirty");

                    b.HasKey("id");

                    b.HasIndex("staffId");

                    b.ToTable("Monday");
                });

            modelBuilder.Entity("SHeDSchedule.Models.Staff", b =>
                {
                    b.Property<int>("staffId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ATC");

                    b.Property<string>("initials");

                    b.Property<int>("term");

                    b.HasKey("staffId");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("SHeDSchedule.Models.Thursday", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<char>("eight");

                    b.Property<char>("eightthirty");

                    b.Property<char>("eleven");

                    b.Property<char>("eleventhirty");

                    b.Property<char>("five");

                    b.Property<char>("fivethirty");

                    b.Property<char>("four");

                    b.Property<char>("fourthirty");

                    b.Property<char>("nine");

                    b.Property<char>("ninethirty");

                    b.Property<char>("one");

                    b.Property<char>("onethirty");

                    b.Property<char>("seventhirty");

                    b.Property<char>("six");

                    b.Property<char>("sixthirty");

                    b.Property<int>("staffId");

                    b.Property<char>("ten");

                    b.Property<char>("tenthirty");

                    b.Property<char>("three");

                    b.Property<char>("threethirty");

                    b.Property<char>("twelve");

                    b.Property<char>("twelvethirty");

                    b.Property<char>("two");

                    b.Property<char>("twothirty");

                    b.HasKey("id");

                    b.HasIndex("staffId");

                    b.ToTable("Thursday");
                });

            modelBuilder.Entity("SHeDSchedule.Models.Tuesday", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<char>("eight");

                    b.Property<char>("eightthirty");

                    b.Property<char>("eleven");

                    b.Property<char>("eleventhirty");

                    b.Property<char>("five");

                    b.Property<char>("fivethirty");

                    b.Property<char>("four");

                    b.Property<char>("fourthirty");

                    b.Property<char>("nine");

                    b.Property<char>("ninethirty");

                    b.Property<char>("one");

                    b.Property<char>("onethirty");

                    b.Property<char>("seventhirty");

                    b.Property<char>("six");

                    b.Property<char>("sixthirty");

                    b.Property<int>("staffId");

                    b.Property<char>("ten");

                    b.Property<char>("tenthirty");

                    b.Property<char>("three");

                    b.Property<char>("threethirty");

                    b.Property<char>("twelve");

                    b.Property<char>("twelvethirty");

                    b.Property<char>("two");

                    b.Property<char>("twothirty");

                    b.HasKey("id");

                    b.HasIndex("staffId");

                    b.ToTable("Tuesday");
                });

            modelBuilder.Entity("SHeDSchedule.Models.Wednesday", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<char>("eight");

                    b.Property<char>("eightthirty");

                    b.Property<char>("eleven");

                    b.Property<char>("eleventhirty");

                    b.Property<char>("five");

                    b.Property<char>("fivethirty");

                    b.Property<char>("four");

                    b.Property<char>("fourthirty");

                    b.Property<char>("nine");

                    b.Property<char>("ninethirty");

                    b.Property<char>("one");

                    b.Property<char>("onethirty");

                    b.Property<char>("seventhirty");

                    b.Property<char>("six");

                    b.Property<char>("sixthirty");

                    b.Property<int>("staffId");

                    b.Property<char>("ten");

                    b.Property<char>("tenthirty");

                    b.Property<char>("three");

                    b.Property<char>("threethirty");

                    b.Property<char>("twelve");

                    b.Property<char>("twelvethirty");

                    b.Property<char>("two");

                    b.Property<char>("twothirty");

                    b.HasKey("id");

                    b.HasIndex("staffId");

                    b.ToTable("Wednesday");
                });

            modelBuilder.Entity("SHeDSchedule.Models.Friday", b =>
                {
                    b.HasOne("SHeDSchedule.Models.Staff", "s")
                        .WithMany()
                        .HasForeignKey("staffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SHeDSchedule.Models.Monday", b =>
                {
                    b.HasOne("SHeDSchedule.Models.Staff", "s")
                        .WithMany()
                        .HasForeignKey("staffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SHeDSchedule.Models.Thursday", b =>
                {
                    b.HasOne("SHeDSchedule.Models.Staff", "s")
                        .WithMany()
                        .HasForeignKey("staffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SHeDSchedule.Models.Tuesday", b =>
                {
                    b.HasOne("SHeDSchedule.Models.Staff", "s")
                        .WithMany()
                        .HasForeignKey("staffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SHeDSchedule.Models.Wednesday", b =>
                {
                    b.HasOne("SHeDSchedule.Models.Staff", "s")
                        .WithMany()
                        .HasForeignKey("staffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
