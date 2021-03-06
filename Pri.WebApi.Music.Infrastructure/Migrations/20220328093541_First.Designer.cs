// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pri.Oe.WebApi.Music.Infrastructure.Data;

namespace Pri.WebApi.Music.Infrastructure.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    [Migration("20220328093541_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pri.Oe.WebApi.Music.Core.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            Image = "andjusticeforall.jpg",
                            Name = "...And Justice for All",
                            ReleaseDate = new DateTime(1988, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 1,
                            Image = "metallica.jpg",
                            Name = "Metallica",
                            ReleaseDate = new DateTime(1991, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 1,
                            Image = "masterofpuppets.jpg",
                            Name = "Master of Puppets",
                            ReleaseDate = new DateTime(1986, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 1,
                            Image = "hardwired.jpg",
                            Name = "Hardwired...To Self-Destruct",
                            ReleaseDate = new DateTime(2016, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 2,
                            Image = "appetitefordestruction.jpg",
                            Name = "Appetite For Destruction",
                            ReleaseDate = new DateTime(1987, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            ArtistId = 2,
                            Image = "useyourillusion1.jpg",
                            Name = "Use Your Illusion I",
                            ReleaseDate = new DateTime(1991, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            ArtistId = 2,
                            Image = "useyourillusion2.jpg",
                            Name = "Use Your Illusion II",
                            ReleaseDate = new DateTime(1991, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            ArtistId = 3,
                            Image = "mtvunpluggedinnewyork.jpg",
                            Name = "MTV Unplugged In New York",
                            ReleaseDate = new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            ArtistId = 3,
                            Image = "liveatreading.jpg",
                            Name = "Live at Reading",
                            ReleaseDate = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            ArtistId = 3,
                            Image = "nevermind.jpg",
                            Name = "Nevermind",
                            ReleaseDate = new DateTime(1991, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            ArtistId = 4,
                            Image = "ten.jpg",
                            Name = "Ten",
                            ReleaseDate = new DateTime(1991, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            ArtistId = 4,
                            Image = "spintheblackcirclelive.jpg",
                            Name = "Spin The Black Circle Live In Seattle '95",
                            ReleaseDate = new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            ArtistId = 5,
                            Image = "livetheanciennebelgique.jpg",
                            Name = "Live @ The Ancienne Belgique",
                            ReleaseDate = new DateTime(2010, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            ArtistId = 5,
                            Image = "blackfuel.jpg",
                            Name = "Black Fuel",
                            ReleaseDate = new DateTime(1997, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            ArtistId = 7,
                            Image = "rageagainstthemachine.jpg",
                            Name = "Rage Against The Machine",
                            ReleaseDate = new DateTime(1992, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16,
                            ArtistId = 7,
                            Image = "evilempire.jpg",
                            Name = "Evil Empire",
                            ReleaseDate = new DateTime(1996, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Pri.Oe.WebApi.Music.Core.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Followers")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Followers = 15044763,
                            Image = "images/artist/metallica.jpg",
                            Name = "Metallica",
                            Popularity = 85
                        },
                        new
                        {
                            Id = 2,
                            Followers = 17664350,
                            Image = "images/artist/gunsnroses.jpg",
                            Name = "Guns N' Roses",
                            Popularity = 82
                        },
                        new
                        {
                            Id = 3,
                            Followers = 11175759,
                            Image = "images/artist/nirvana.jpg",
                            Name = "Nirvana",
                            Popularity = 82
                        },
                        new
                        {
                            Id = 4,
                            Followers = 5980792,
                            Image = "images/artist/pearljam.jpg",
                            Name = "Pearl Jam",
                            Popularity = 79
                        },
                        new
                        {
                            Id = 5,
                            Followers = 9637,
                            Image = "images/artist/channelzero.jpg",
                            Name = "Channel Zero",
                            Popularity = 30
                        },
                        new
                        {
                            Id = 6,
                            Followers = 78309,
                            Image = "images/artist/therapy.jpg",
                            Name = "Therapy?",
                            Popularity = 44
                        },
                        new
                        {
                            Id = 7,
                            Followers = 4468769,
                            Image = "images/artist/rageagainstthemachine.jpg",
                            Name = "Rage Against The Machine",
                            Popularity = 73
                        },
                        new
                        {
                            Id = 8,
                            Followers = 2141,
                            Image = "images/artist/kinghiss.jpg",
                            Name = "King Hiss",
                            Popularity = 15
                        });
                });

            modelBuilder.Entity("Pri.Oe.WebApi.Music.Core.Entities.Album", b =>
                {
                    b.HasOne("Pri.Oe.WebApi.Music.Core.Entities.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("Pri.Oe.WebApi.Music.Core.Entities.Artist", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
