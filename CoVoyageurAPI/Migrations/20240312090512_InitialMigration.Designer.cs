﻿// <auto-generated />
using System;
using CoVoyageurAPI.Datas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoVoyageurAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240312090512_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CoVoyageurCore.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("brand");

                    b.Property<int>("Color")
                        .HasColumnType("int")
                        .HasColumnName("color");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("license_plate");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("model");

                    b.Property<int?>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("UserId");

                    b.ToTable("car");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Ford",
                            Color = 3,
                            LicensePlate = "OG-666-OG",
                            Model = "Fiesta",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Ford",
                            Color = 3,
                            LicensePlate = "AB-123-RT",
                            Model = "Fiesta",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Ford",
                            Color = 3,
                            LicensePlate = "AB-123-RT",
                            Model = "Fiesta",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Ford",
                            Color = 3,
                            LicensePlate = "AB-123-RT",
                            Model = "Fiesta",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("CoVoyageurCore.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("review");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("profile");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Rating = 5,
                            Review = "Parfait",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Rating = 4,
                            Review = "Bien",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Rating = 3,
                            Review = "Moyen",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Rating = 2,
                            Review = "Mauvais",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("CoVoyageurCore.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("comment");

                    b.Property<int>("RatedUserId")
                        .HasColumnType("int")
                        .HasColumnName("rateduserid");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ratingdate");

                    b.Property<int>("RatingUserId")
                        .HasColumnType("int")
                        .HasColumnName("ratinguserid");

                    b.Property<int>("RideId")
                        .HasColumnType("int")
                        .HasColumnName("rideid");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("score");

                    b.HasKey("Id");

                    b.HasIndex("RatedUserId");

                    b.HasIndex("RatingUserId");

                    b.HasIndex("RideId");

                    b.ToTable("rating");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Good",
                            RatedUserId = 1,
                            RatingDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RatingUserId = 1,
                            RideId = 1,
                            Score = 5m
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Bad",
                            RatedUserId = 2,
                            RatingDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RatingUserId = 2,
                            RideId = 2,
                            Score = 2m
                        });
                });

            modelBuilder.Entity("CoVoyageurCore.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("reservationDate");

                    b.Property<int>("RideId")
                        .HasColumnType("int")
                        .HasColumnName("rideId");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    b.HasKey("Id");

                    b.HasIndex("RideId");

                    b.HasIndex("UserId");

                    b.ToTable("reservation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ReservationDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RideId = 2,
                            Status = 0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ReservationDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RideId = 4,
                            Status = 0,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("CoVoyageurCore.Models.Ride", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Arrival")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("arrival");

                    b.Property<int>("AvailableSeats")
                        .HasColumnType("int")
                        .HasColumnName("availableSeats");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("creationDate");

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("departure");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("price");

                    b.Property<DateTime>("RideDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("rideDate");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ride");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Arrival = "10h00",
                            AvailableSeats = 4,
                            CreationDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Departure = "9h00",
                            Price = 20.00m,
                            RideDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Arrival = "10h00",
                            AvailableSeats = 4,
                            CreationDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Departure = "9h00",
                            Price = 20.00m,
                            RideDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Arrival = "10h00",
                            AvailableSeats = 4,
                            CreationDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Departure = "9h00",
                            Price = 20.00m,
                            RideDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Arrival = "10h00",
                            AvailableSeats = 4,
                            CreationDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Departure = "9h00",
                            Price = 20.00m,
                            RideDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        });
                });

            modelBuilder.Entity("CoVoyageurCore.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("birth_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("firstname");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("gender");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lastname");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone");

                    b.Property<int?>("UserRatingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserRatingId");

                    b.ToTable("user");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kevin@mail.com",
                            FirstName = "Kevin",
                            Gender = "M",
                            IsAdmin = true,
                            LastName = "Callet",
                            PassWord = "cHN3ZGNsw6kgc3VwZXIgc2VjcsOodGU=",
                            Phone = "0102030405"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "massimo@mail.com",
                            FirstName = "Massima",
                            Gender = "M",
                            IsAdmin = false,
                            LastName = "Mao",
                            PassWord = "cHN3ZGNsw6kgc3VwZXIgc2VjcsOodGU=",
                            Phone = "0102030405"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "remi@mail.com",
                            FirstName = "Rémi",
                            Gender = "M",
                            IsAdmin = false,
                            LastName = "Debruyne",
                            PassWord = "cHN3ZGNsw6kgc3VwZXIgc2VjcsOodGU=",
                            Phone = "0102030405"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "aguit@mail.com",
                            FirstName = "Aguit",
                            Gender = "M",
                            IsAdmin = true,
                            LastName = "Inan",
                            PassWord = "cHN3ZGNsw6kgc3VwZXIgc2VjcsOodGU=",
                            Phone = "0102030405"
                        });
                });

            modelBuilder.Entity("CoVoyageurCore.Models.Car", b =>
                {
                    b.HasOne("CoVoyageurCore.Models.Profile", null)
                        .WithMany("Cars")
                        .HasForeignKey("ProfileId");

                    b.HasOne("CoVoyageurCore.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoVoyageurCore.Models.Profile", b =>
                {
                    b.HasOne("CoVoyageurCore.Models.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("CoVoyageurCore.Models.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoVoyageurCore.Models.Rating", b =>
                {
                    b.HasOne("CoVoyageurCore.Models.User", "RatedUser")
                        .WithMany("RatedRatings")
                        .HasForeignKey("RatedUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CoVoyageurCore.Models.User", "RatingUser")
                        .WithMany("RatingRatings")
                        .HasForeignKey("RatingUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CoVoyageurCore.Models.Ride", "Ride")
                        .WithMany("Ratings")
                        .HasForeignKey("RideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RatedUser");

                    b.Navigation("RatingUser");

                    b.Navigation("Ride");
                });

            modelBuilder.Entity("CoVoyageurCore.Models.Reservation", b =>
                {
                    b.HasOne("CoVoyageurCore.Models.Ride", "Ride")
                        .WithMany()
                        .HasForeignKey("RideId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CoVoyageurCore.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Ride");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoVoyageurCore.Models.Ride", b =>
                {
                    b.HasOne("CoVoyageurCore.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoVoyageurCore.Models.User", b =>
                {
                    b.HasOne("CoVoyageurCore.Models.Rating", "UserRating")
                        .WithMany()
                        .HasForeignKey("UserRatingId");

                    b.Navigation("UserRating");
                });

            modelBuilder.Entity("CoVoyageurCore.Models.Profile", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CoVoyageurCore.Models.Ride", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("CoVoyageurCore.Models.User", b =>
                {
                    b.Navigation("Profile");

                    b.Navigation("RatedRatings");

                    b.Navigation("RatingRatings");
                });
#pragma warning restore 612, 618
        }
    }
}
