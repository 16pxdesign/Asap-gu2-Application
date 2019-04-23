﻿// <auto-generated />
using System;
using Application.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Application.Data.Migrations
{
    [DbContext(typeof(DatabaseModel))]
    [Migration("20190423022019_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Application.Data.Models.Activities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("TrainingId");

                    b.HasKey("Id");

                    b.HasIndex("TrainingId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Application.Data.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Flat");

                    b.Property<string>("Postcode");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Application.Data.Models.Attendance", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PlayerSRU")
                        .IsRequired();

                    b.Property<string>("PlayerSRU1");

                    b.Property<int>("TrainingId");

                    b.HasKey("Id");

                    b.HasAlternateKey("PlayerSRU", "TrainingId");

                    b.HasIndex("PlayerSRU1");

                    b.HasIndex("TrainingId");

                    b.ToTable("Attendance");
                });

            modelBuilder.Entity("Application.Data.Models.Doctor", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int?>("AddressId");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("Application.Data.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("KO");

                    b.Property<int>("Location");

                    b.Property<string>("Opposition");

                    b.Property<int>("Result");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Application.Data.Models.Guardian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<string>("JuniorSRU");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Relationship");

                    b.Property<DateTime>("Signature");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("JuniorSRU");

                    b.ToTable("Guardian");
                });

            modelBuilder.Entity("Application.Data.Models.HealthIssue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("PlayerElo");

                    b.HasKey("Id");

                    b.HasIndex("PlayerElo");

                    b.ToTable("HealthIssue");
                });

            modelBuilder.Entity("Application.Data.Models.Junior", b =>
                {
                    b.Property<string>("SRU");

                    b.HasKey("SRU");

                    b.ToTable("Junior");
                });

            modelBuilder.Entity("Application.Data.Models.Kin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Relationship");

                    b.Property<string>("SeniorSRU");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("SeniorSRU")
                        .IsUnique();

                    b.ToTable("Kin");
                });

            modelBuilder.Entity("Application.Data.Models.Member", b =>
                {
                    b.Property<string>("SRU");

                    b.Property<bool>("Active");

                    b.Property<int?>("AddressId");

                    b.Property<string>("Email");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Surname");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("SRU");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Application.Data.Models.Player", b =>
                {
                    b.Property<int>("Elo")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Position");

                    b.Property<string>("SRU")
                        .IsRequired();

                    b.HasKey("Elo");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Application.Data.Models.Profile", b =>
                {
                    b.Property<string>("PlayerSRU");

                    b.Property<int>("SkillId");

                    b.Property<string>("Description");

                    b.Property<int>("Score");

                    b.HasKey("PlayerSRU", "SkillId");

                    b.HasIndex("PlayerSRU")
                        .IsUnique();

                    b.HasIndex("SkillId")
                        .IsUnique();

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("Application.Data.Models.Scores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int?>("GameId");

                    b.Property<int>("Half");

                    b.Property<int>("Points");

                    b.Property<int>("Team");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("Application.Data.Models.Senior", b =>
                {
                    b.Property<string>("SRU");

                    b.HasKey("SRU");

                    b.ToTable("Senior");
                });

            modelBuilder.Entity("Application.Data.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Evaluable");

                    b.Property<string>("Name");

                    b.Property<int?>("PartentId");

                    b.HasKey("Id");

                    b.HasIndex("PartentId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Application.Data.Models.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CoachSRU");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Location");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("CoachSRU");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("Application.Data.Models.Activities", b =>
                {
                    b.HasOne("Application.Data.Models.Training", "Training")
                        .WithMany("Activities")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.Data.Models.Attendance", b =>
                {
                    b.HasOne("Application.Data.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerSRU1")
                        .HasPrincipalKey("SRU")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Application.Data.Models.Training", "Training")
                        .WithMany()
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Application.Data.Models.Doctor", b =>
                {
                    b.HasOne("Application.Data.Models.Address", "Address")
                        .WithOne()
                        .HasForeignKey("Application.Data.Models.Doctor", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Application.Data.Models.Player", "Player")
                        .WithOne("Doctor")
                        .HasForeignKey("Application.Data.Models.Doctor", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.Data.Models.Guardian", b =>
                {
                    b.HasOne("Application.Data.Models.Address", "Address")
                        .WithOne()
                        .HasForeignKey("Application.Data.Models.Guardian", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Application.Data.Models.Junior", "Junior")
                        .WithMany("Guardians")
                        .HasForeignKey("JuniorSRU")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.Data.Models.HealthIssue", b =>
                {
                    b.HasOne("Application.Data.Models.Player", "Player")
                        .WithMany("HealthIssues")
                        .HasForeignKey("PlayerElo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.Data.Models.Junior", b =>
                {
                    b.HasOne("Application.Data.Models.Player", "Player")
                        .WithOne("Junior")
                        .HasForeignKey("Application.Data.Models.Junior", "SRU")
                        .HasPrincipalKey("Application.Data.Models.Player", "SRU")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.Data.Models.Kin", b =>
                {
                    b.HasOne("Application.Data.Models.Address", "Address")
                        .WithOne()
                        .HasForeignKey("Application.Data.Models.Kin", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Application.Data.Models.Senior", "Senior")
                        .WithOne("Kin")
                        .HasForeignKey("Application.Data.Models.Kin", "SeniorSRU")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.Data.Models.Member", b =>
                {
                    b.HasOne("Application.Data.Models.Address", "Address")
                        .WithOne()
                        .HasForeignKey("Application.Data.Models.Member", "AddressId");
                });

            modelBuilder.Entity("Application.Data.Models.Player", b =>
                {
                    b.HasOne("Application.Data.Models.Member", "Member")
                        .WithOne("Player")
                        .HasForeignKey("Application.Data.Models.Player", "SRU")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.Data.Models.Profile", b =>
                {
                    b.HasOne("Application.Data.Models.Player", "Player")
                        .WithOne()
                        .HasForeignKey("Application.Data.Models.Profile", "PlayerSRU")
                        .HasPrincipalKey("Application.Data.Models.Player", "SRU")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Application.Data.Models.Skill", "Skill")
                        .WithOne()
                        .HasForeignKey("Application.Data.Models.Profile", "SkillId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Application.Data.Models.Scores", b =>
                {
                    b.HasOne("Application.Data.Models.Game")
                        .WithMany("Scores")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Application.Data.Models.Senior", b =>
                {
                    b.HasOne("Application.Data.Models.Player", "Player")
                        .WithOne("Senior")
                        .HasForeignKey("Application.Data.Models.Senior", "SRU")
                        .HasPrincipalKey("Application.Data.Models.Player", "SRU")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Application.Data.Models.Skill", b =>
                {
                    b.HasOne("Application.Data.Models.Skill", "Partent")
                        .WithMany()
                        .HasForeignKey("PartentId");
                });

            modelBuilder.Entity("Application.Data.Models.Training", b =>
                {
                    b.HasOne("Application.Data.Models.Member", "Coach")
                        .WithMany()
                        .HasForeignKey("CoachSRU")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
