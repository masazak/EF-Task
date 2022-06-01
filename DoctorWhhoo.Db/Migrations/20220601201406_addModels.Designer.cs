﻿// <auto-generated />
using System;
using DoctorWhhoo.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWhhoo.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20220601201406_addModels")]
    partial class addModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DoctorWhhoo.Db.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("DoctorWhhoo.Db.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"), 1L, 1);

                    b.Property<string>("CompanionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WhoPlayed")
                        .HasColumnType("bit");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");
                });

            modelBuilder.Entity("DoctorWhhoo.Db.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("DoctorWhhoo.Db.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemys");
                });

            modelBuilder.Entity("DoctorWhhoo.Db.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("DoctorWhhoo.Db.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeCompanionId"), 1L, 1);

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("Epcomp");
                });

            modelBuilder.Entity("DoctorWhhoo.Db.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeEnemyId"), 1L, 1);

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpEnemy");
                });

            modelBuilder.Entity("DoctorWhhoo.Db.Episode", b =>
                {
                    b.HasOne("DoctorWhhoo.Db.Author", null)
                        .WithMany("EpAuthor")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWhhoo.Db.Doctor", null)
                        .WithMany("EpDoctor")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWhhoo.Db.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWhhoo.Db.Companion", null)
                        .WithMany("EpComp")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWhhoo.Db.Episode", null)
                        .WithMany("EpComp")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWhhoo.Db.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWhhoo.Db.Enemy", null)
                        .WithMany("EpEnemy")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWhhoo.Db.Episode", null)
                        .WithMany("EpEnemy")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWhhoo.Db.Author", b =>
                {
                    b.Navigation("EpAuthor");
                });

            modelBuilder.Entity("DoctorWhhoo.Db.Companion", b =>
                {
                    b.Navigation("EpComp");
                });

            modelBuilder.Entity("DoctorWhhoo.Db.Doctor", b =>
                {
                    b.Navigation("EpDoctor");
                });

            modelBuilder.Entity("DoctorWhhoo.Db.Enemy", b =>
                {
                    b.Navigation("EpEnemy");
                });

            modelBuilder.Entity("DoctorWhhoo.Db.Episode", b =>
                {
                    b.Navigation("EpComp");

                    b.Navigation("EpEnemy");
                });
#pragma warning restore 612, 618
        }
    }
}
