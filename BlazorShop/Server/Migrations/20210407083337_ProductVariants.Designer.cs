﻿// <auto-generated />
using System;
using BlazorShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210407083337_ProductVariants")]
    partial class ProductVariants
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "aperture",
                            Name = "Video game",
                            Url = "video-game"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "briefcase",
                            Name = "Clothes",
                            Url = "clothes"
                        });
                });

            modelBuilder.Entity("BlazorShop.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 3,
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pc"
                        },
                        new
                        {
                            Id = 6,
                            Name = "X-Box"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Playstation"
                        });
                });

            modelBuilder.Entity("BlazorShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EditionId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EditionId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "t is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                            Image = "https://i.pinimg.com/originals/d0/7f/49/d07f49fad86f488c5d13b7d71f7c2abb.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "The Hitchhiker's Guide to the Galaxy"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Nineteen Eighty-Four"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Half-Life saga is the story of Gordon Freeman, a physicist who finds himself at the center of resistance to an alien invasion that threatens the future of humanity. From Valve's 1998 debut game onward, the series has been at the forefront of immersive action and storytelling.",
                            Image = "https://images-na.ssl-images-amazon.com/images/I/512Lrp-8JxL._SX378_BO1,204,203,200_.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Half-Life 2"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Diablo III est un jeu vidéo d'action et de rôle de type hack and slash développé par Blizzard Entertainment. Il constitue le troisième opus de la série, succédant à Diablo et à Diablo II. Publié par Activision Blizzard, le jeu a bénéficié d'une sortie mondiale le 15 mai 2012.",
                            Image = "https://s3.gaming-cdn.com/images/products/20/271x377/diablo-iii-cover.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Diablo 3"
                        },
                        new
                        {
                            Id = 57,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Day of the Tentacle, également connu sous le nom de Maniac Mansion: Day of the Tentacle, est un jeu vidéo d'aventure graphique développé et publié par LucasArts en juin 1993 sur PC puis Macintosh. Le jeu est sorti à la fois sur disquettes et sur CD-ROM, et fait suite à Maniac Mansion sorti en 1987",
                            Image = "https://static.trueachievements.com/boxart/Game_8970.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Day of the Tentacles"
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hypérion est un roman de science-fiction appartenant au genre space opera, écrit par Dan Simmons en 1989 et publié en France en 1991.",
                            Image = "https://i.pinimg.com/originals/bf/0b/bd/bf0bbd47c62723da28597fcbba4ac366.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Hyperion"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Super Nintendo Entertainment System"
                        },
                        new
                        {
                            Id = 76,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Découvrez la collection T-shirt femme manche courte col rond Blanc Un développeur écrit du code Stop. Pas cher & Livraison rapide avec du choix et du stock.",
                            Image = "https://www.coque-unique.com/clothes/tshirt-femme-col-rond-mc-un-developpeur-ecrit-du-code-stop-white.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "T-shirt Un développeur écrit du code Stop Femme"
                        },
                        new
                        {
                            Id = 77,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Découvrez la collection T-shirt homme manche courte col rond Blanc Un développeur écrit du code Stop. Pas cher & Livraison rapide avec du choix et du stock.",
                            Image = "https://www.coque-unique.com/clothes/tshirt-mc-col-rond-un-developpeur-ecrit-du-code-stop-white.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "T-shirt Un développeur écrit du code Stop Homme"
                        });
                });

            modelBuilder.Entity("BlazorShop.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariant");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 2,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 3,
                            OriginalPrice = 0m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 4,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 2,
                            OriginalPrice = 0m,
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = 22,
                            EditionId = 2,
                            OriginalPrice = 14.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 22,
                            EditionId = 3,
                            OriginalPrice = 0m,
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 5,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 6,
                            OriginalPrice = 0m,
                            Price = 69.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 7,
                            OriginalPrice = 59.99m,
                            Price = 49.99m
                        },
                        new
                        {
                            ProductId = 18,
                            EditionId = 5,
                            OriginalPrice = 24.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 57,
                            EditionId = 5,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 76,
                            EditionId = 1,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 77,
                            EditionId = 1,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 6,
                            EditionId = 1,
                            OriginalPrice = 400m,
                            Price = 73.74m
                        });
                });

            modelBuilder.Entity("BlazorShop.Shared.Product", b =>
                {
                    b.HasOne("BlazorShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorShop.Shared.Edition", null)
                        .WithMany("Products")
                        .HasForeignKey("EditionId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazorShop.Shared.ProductVariant", b =>
                {
                    b.HasOne("BlazorShop.Shared.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorShop.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BlazorShop.Shared.Edition", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BlazorShop.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}