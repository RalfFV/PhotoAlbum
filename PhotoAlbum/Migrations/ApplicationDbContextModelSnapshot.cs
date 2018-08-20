﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PhotoAlbum.Data;
using System;

namespace PhotoAlbum.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhotoAlbum.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<bool>("Professional");

                    b.HasKey("ID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("PhotoAlbum.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("EventTypeID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("PhotoAlbum.Models.EventType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("EventTypes");
                });

            modelBuilder.Entity("PhotoAlbum.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Nation");

                    b.Property<int>("PlaceID");

                    b.Property<string>("PlaceName");

                    b.HasKey("ID");

                    b.HasIndex("PlaceID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("PhotoAlbum.Models.People", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("Relation");

                    b.HasKey("ID");

                    b.ToTable("PeopleDb");
                });

            modelBuilder.Entity("PhotoAlbum.Models.Picture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<bool>("Favorite");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("StackID");

                    b.Property<string>("StackName");

                    b.HasKey("ID");

                    b.HasIndex("StackID");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("PhotoAlbum.Models.PictureAuthor", b =>
                {
                    b.Property<int>("AuthorID");

                    b.Property<int>("PictureID");

                    b.HasKey("AuthorID", "PictureID");

                    b.HasIndex("PictureID");

                    b.ToTable("PictureAuthors");
                });

            modelBuilder.Entity("PhotoAlbum.Models.PictureEvent", b =>
                {
                    b.Property<int>("EventID");

                    b.Property<int>("PictureID");

                    b.HasKey("EventID", "PictureID");

                    b.HasIndex("PictureID");

                    b.ToTable("PictureEvents");
                });

            modelBuilder.Entity("PhotoAlbum.Models.PictureLocation", b =>
                {
                    b.Property<int>("LocationID");

                    b.Property<int>("PictureID");

                    b.HasKey("LocationID", "PictureID");

                    b.HasIndex("PictureID");

                    b.ToTable("PictureLocations");
                });

            modelBuilder.Entity("PhotoAlbum.Models.PicturePeople", b =>
                {
                    b.Property<int>("PeopleID");

                    b.Property<int>("PictureID");

                    b.HasKey("PeopleID", "PictureID");

                    b.HasIndex("PictureID");

                    b.ToTable("PicturePeopleDb");
                });

            modelBuilder.Entity("PhotoAlbum.Models.Place", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("PhotoAlbum.Models.Stack", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Classified");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Stacks");
                });

            modelBuilder.Entity("PhotoAlbum.Models.Event", b =>
                {
                    b.HasOne("PhotoAlbum.Models.EventType", "EventType")
                        .WithMany("Events")
                        .HasForeignKey("EventTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PhotoAlbum.Models.Location", b =>
                {
                    b.HasOne("PhotoAlbum.Models.Place", "Place")
                        .WithMany("Locations")
                        .HasForeignKey("PlaceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PhotoAlbum.Models.Picture", b =>
                {
                    b.HasOne("PhotoAlbum.Models.Stack", "Stack")
                        .WithMany("Pictures")
                        .HasForeignKey("StackID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PhotoAlbum.Models.PictureAuthor", b =>
                {
                    b.HasOne("PhotoAlbum.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PhotoAlbum.Models.Picture", "Picture")
                        .WithMany("PictureAuthors")
                        .HasForeignKey("PictureID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PhotoAlbum.Models.PictureEvent", b =>
                {
                    b.HasOne("PhotoAlbum.Models.Event", "Event")
                        .WithMany("PictureEvent")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PhotoAlbum.Models.Picture", "Picture")
                        .WithMany("PictureEvent")
                        .HasForeignKey("PictureID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PhotoAlbum.Models.PictureLocation", b =>
                {
                    b.HasOne("PhotoAlbum.Models.Location", "Location")
                        .WithMany("PictureLocations")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PhotoAlbum.Models.Picture", "Picture")
                        .WithMany("PictureLocations")
                        .HasForeignKey("PictureID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PhotoAlbum.Models.PicturePeople", b =>
                {
                    b.HasOne("PhotoAlbum.Models.People", "People")
                        .WithMany("PicturePeople")
                        .HasForeignKey("PeopleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PhotoAlbum.Models.Picture", "Picture")
                        .WithMany("PicturePeople")
                        .HasForeignKey("PictureID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
