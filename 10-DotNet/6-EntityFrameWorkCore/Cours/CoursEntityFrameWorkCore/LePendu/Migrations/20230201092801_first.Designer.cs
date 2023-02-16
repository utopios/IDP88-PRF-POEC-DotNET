﻿// <auto-generated />
using LePendu.Tools;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LePendu.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20230201092801_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LePendu.Models.PenduUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<string>("Pseudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("pseudo");

                    b.HasKey("Id");

                    b.ToTable("pendu_user");
                });

            modelBuilder.Entity("LePendu.Models.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("WordValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("word_value");

                    b.HasKey("Id");

                    b.ToTable("word");
                });

            modelBuilder.Entity("PenduUserWord", b =>
                {
                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.Property<int>("WordsId")
                        .HasColumnType("int");

                    b.HasKey("UsersId", "WordsId");

                    b.HasIndex("WordsId");

                    b.ToTable("PenduUserWord");
                });

            modelBuilder.Entity("PenduUserWord", b =>
                {
                    b.HasOne("LePendu.Models.PenduUser", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LePendu.Models.Word", null)
                        .WithMany()
                        .HasForeignKey("WordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}