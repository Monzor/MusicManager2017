using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MusicManager2017.Models;

namespace MusicManager2017.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    [Migration("20171013041450_initdb")]
    partial class initdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicManager2017.Models.Album", b =>
                {
                    b.Property<int>("AlbumID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArtistID");

                    b.Property<int>("GenreID");

                    b.Property<decimal>("Price");

                    b.Property<string>("Title");

                    b.HasKey("AlbumID");

                    b.HasIndex("ArtistID");

                    b.HasIndex("GenreID");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("MusicManager2017.Models.Artist", b =>
                {
                    b.Property<int>("ArtistID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<string>("Name");

                    b.HasKey("ArtistID");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("MusicManager2017.Models.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MusicManager2017.Models.Album", b =>
                {
                    b.HasOne("MusicManager2017.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MusicManager2017.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
