﻿// <auto-generated />
using ApiProject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiProject.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20191111202442_LAZYLOADING")]
    partial class LAZYLOADING
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiProject.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistID");

                    b.Property<string>("Image");

                    b.Property<string>("Label");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("ArtistID");

                    b.ToTable("Albums");

                    b.HasData(
                        new { ID = 1, ArtistID = 1, Image = "./css/images/east-atlanta-santa.jpg", Label = "label", Title = "East Atlanta Santa" },
                        new { ID = 2, ArtistID = 2, Image = "./css/images/blink182.jpg", Label = "label", Title = "Blink 182" },
                        new { ID = 3, ArtistID = 3, Image = "./css/images/poison.jpg", Label = "label", Title = "The Poison" },
                        new { ID = 4, ArtistID = 4, Image = "./css/images/fmc.png", Label = "label", Title = "Full Moon Fever" }
                    );
                });

            modelBuilder.Entity("ApiProject.Models.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Artists");

                    b.HasData(
                        new { ID = 1, Image = "./css/images/gucci-mane.jpg", Name = "Gucci Mane" },
                        new { ID = 2, Image = "./css/images/blink182.jpg", Name = "Blink 182" },
                        new { ID = 3, Image = "./css/images/bfmv.jpg", Name = "Bullet For My Valentine" },
                        new { ID = 4, Image = "./css/images/Tom.jpg", Name = "Tom Petty" }
                    );
                });

            modelBuilder.Entity("ApiProject.Models.Song", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumID");

                    b.Property<string>("Link");

                    b.Property<string>("Time");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("AlbumID");

                    b.ToTable("Songs");

                    b.HasData(
                        new { ID = 1, AlbumID = 1, Link = "link", Time = "2:55", Title = "Don't Count Me Out" },
                        new { ID = 2, AlbumID = 1, Link = "link", Time = "4:53", Title = "Dope Money" },
                        new { ID = 3, AlbumID = 1, Link = "link", Time = "2:56", Title = "Extra" },
                        new { ID = 4, AlbumID = 1, Link = "link", Time = "3:14", Title = "Put Yourself In The Shoes" },
                        new { ID = 5, AlbumID = 1, Link = "link", Time = "3:36", Title = "Go" },
                        new { ID = 6, AlbumID = 1, Link = "link", Time = "3:12", Title = "Maybe It's the Juice" },
                        new { ID = 7, AlbumID = 1, Link = "link", Time = "2:44", Title = "That Ever Lived" },
                        new { ID = 8, AlbumID = 1, Link = "link", Time = "3:02", Title = "Dead People" },
                        new { ID = 9, AlbumID = 1, Link = "link", Time = "3:12", Title = "Medication" },
                        new { ID = 10, AlbumID = 1, Link = "link", Time = "3:57", Title = "Odd Ball" },
                        new { ID = 11, AlbumID = 1, Link = "link", Time = "3:21", Title = "One Min" },
                        new { ID = 12, AlbumID = 1, Link = "link", Time = "3:03", Title = "Riding Dirty" },
                        new { ID = 13, AlbumID = 1, Link = "link", Time = "2:28", Title = "With My Pistol" },
                        new { ID = 14, AlbumID = 1, Link = "link", Time = "3:39", Title = "Trappin Out the Mansion" },
                        new { ID = 15, AlbumID = 1, Link = "link", Time = "2:29", Title = "One Day At a Time " },
                        new { ID = 16, AlbumID = 2, Link = "link", Time = "2:53", Title = "Feeling This" },
                        new { ID = 17, AlbumID = 2, Link = "link", Time = "2:43", Title = "Obvious" },
                        new { ID = 18, AlbumID = 2, Link = "link", Time = "3:47", Title = "I Miss You" },
                        new { ID = 19, AlbumID = 2, Link = "link", Time = "5:20", Title = "Violence" },
                        new { ID = 20, AlbumID = 2, Link = "link", Time = "2:42", Title = "Stockholm Syndrome" },
                        new { ID = 21, AlbumID = 2, Link = "link", Time = "3:03", Title = "Down" },
                        new { ID = 22, AlbumID = 2, Link = "link", Time = "2:13", Title = "The Fallen Interlude" },
                        new { ID = 23, AlbumID = 2, Link = "link", Time = "1:53", Title = "Go" },
                        new { ID = 24, AlbumID = 2, Link = "link", Time = "4:20", Title = "Asthenia" },
                        new { ID = 25, AlbumID = 2, Link = "link", Time = "4:12", Title = "Always" },
                        new { ID = 26, AlbumID = 2, Link = "link", Time = "2:20", Title = "Easy Target" },
                        new { ID = 27, AlbumID = 2, Link = "link", Time = "4:40", Title = "All Of This" },
                        new { ID = 28, AlbumID = 2, Link = "link", Time = "4:55", Title = "Here's Your Letter" },
                        new { ID = 29, AlbumID = 2, Link = "link", Time = "6:22", Title = "I'm Lost Without You" },
                        new { ID = 30, AlbumID = 2, Link = "link", Time = "2:22", Title = "Intro" },
                        new { ID = 31, AlbumID = 3, Link = "link", Time = "4:17", Title = "Her Voice Resides" },
                        new { ID = 32, AlbumID = 3, Link = "link", Time = "3:43", Title = "4 Words" },
                        new { ID = 33, AlbumID = 3, Link = "link", Time = "5:48", Title = "Tears Don't Fall" },
                        new { ID = 34, AlbumID = 3, Link = "link", Time = "3:35", Title = "Suffocating Under Words of Sorrow" },
                        new { ID = 35, AlbumID = 3, Link = "link", Time = "3:30", Title = "Hit The Floor" },
                        new { ID = 36, AlbumID = 3, Link = "link", Time = "3:45", Title = "All these Things I Hate" },
                        new { ID = 37, AlbumID = 3, Link = "link", Time = "4:01", Title = "Room 409" },
                        new { ID = 38, AlbumID = 3, Link = "link", Time = "3:39", Title = "The Poison" },
                        new { ID = 39, AlbumID = 3, Link = "link", Time = "3:55", Title = "10 Years Today" },
                        new { ID = 40, AlbumID = 3, Link = "link", Time = "3:56", Title = "Cries in Vain" },
                        new { ID = 41, AlbumID = 3, Link = "link", Time = "4:08", Title = "Spit You Out" },
                        new { ID = 42, AlbumID = 3, Link = "link", Time = "6:48", Title = "The End" },
                        new { ID = 43, AlbumID = 4, Link = "link", Time = "4:14", Title = "Free Fallin" },
                        new { ID = 44, AlbumID = 4, Link = "link", Time = "2:56", Title = "I Won't Back Down" },
                        new { ID = 45, AlbumID = 4, Link = "link", Time = "4:06", Title = "Love Is a Long Road" },
                        new { ID = 46, AlbumID = 4, Link = "link", Time = "3:58", Title = "A Face In The Crowd" },
                        new { ID = 47, AlbumID = 4, Link = "link", Time = "4:23", Title = "Runnin' Down a Dream" },
                        new { ID = 48, AlbumID = 4, Link = "link", Time = "2:47", Title = "I'll Feel a Whole Lot Better" },
                        new { ID = 49, AlbumID = 4, Link = "link", Time = "3:05", Title = "Yer So Bad" },
                        new { ID = 50, AlbumID = 4, Link = "link", Time = "2:47", Title = "Depending On You" },
                        new { ID = 51, AlbumID = 4, Link = "link", Time = "2:31", Title = "The Apartment Song" },
                        new { ID = 52, AlbumID = 4, Link = "link", Time = "2:00", Title = "Alright For Now" },
                        new { ID = 53, AlbumID = 4, Link = "link", Time = "3:29", Title = "A Mind with a Heart of Its Own" },
                        new { ID = 54, AlbumID = 4, Link = "link", Time = "2:56", Title = "Zombie Zoo" }
                    );
                });

            modelBuilder.Entity("ApiProject.Models.Album", b =>
                {
                    b.HasOne("ApiProject.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApiProject.Models.Song", b =>
                {
                    b.HasOne("ApiProject.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
