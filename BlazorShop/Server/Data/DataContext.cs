using System;
using System.Collections.Generic;
using BlazorShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books",
                    Icon = "book"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video game",
                    Url = "video-game",
                    Icon = "aperture"
                },
                new Category
                {
                    Id = 2,
                    Name = "Clothes",
                    Url = "clothes",
                    Icon = "briefcase"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "t is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    Image = "https://i.pinimg.com/originals/d0/7f/49/d07f49fad86f488c5d13b7d71f7c2abb.jpg",
                    DateCreated = new DateTime(2021, 04, 04)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Nineteen Eighty-Four",
                    Description = "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Description = "The Half-Life saga is the story of Gordon Freeman, a physicist who finds himself at the center of resistance to an alien invasion that threatens the future of humanity. From Valve's 1998 debut game onward, the series has been at the forefront of immersive action and storytelling.",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/512Lrp-8JxL._SX378_BO1,204,203,200_.jpg",
                    DateCreated = new DateTime(2021, 04, 04)
                },
                new Product
                {
                    Id = 18,
                    CategoryId = 3,
                    Title = "Diablo 3",
                    Description = "Diablo III est un jeu vidéo d'action et de rôle de type hack and slash développé par Blizzard Entertainment. Il constitue le troisième opus de la série, succédant à Diablo et à Diablo II. Publié par Activision Blizzard, le jeu a bénéficié d'une sortie mondiale le 15 mai 2012.",
                    Image = "https://s3.gaming-cdn.com/images/products/20/271x377/diablo-iii-cover.jpg",
                    DateCreated = new DateTime(2021, 04, 04)
                },
                new Product
                {
                    Id = 57,
                    CategoryId = 3,
                    Title = "Day of the Tentacles",
                    Description = "Day of the Tentacle, également connu sous le nom de Maniac Mansion: Day of the Tentacle, est un jeu vidéo d'aventure graphique développé et publié par LucasArts en juin 1993 sur PC puis Macintosh. Le jeu est sorti à la fois sur disquettes et sur CD-ROM, et fait suite à Maniac Mansion sorti en 1987",
                    Image = "https://static.trueachievements.com/boxart/Game_8970.jpg",
                    DateCreated = new DateTime(2021, 04, 04)
                },
                new Product
                {
                    Id = 22,
                    CategoryId = 1,
                    Title = "Hyperion",
                    Description = "Hypérion est un roman de science-fiction appartenant au genre space opera, écrit par Dan Simmons en 1989 et publié en France en 1991.",
                    Image = "https://i.pinimg.com/originals/bf/0b/bd/bf0bbd47c62723da28597fcbba4ac366.jpg",
                    DateCreated = new DateTime(2021, 04, 04)
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "Super Nintendo Entertainment System",
                    Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 76,
                    CategoryId = 2,
                    Title = "T-shirt Un développeur écrit du code Stop Femme",
                    Description = "Découvrez la collection T-shirt femme manche courte col rond Blanc Un développeur écrit du code Stop. Pas cher & Livraison rapide avec du choix et du stock.",
                    Image = "https://www.coque-unique.com/clothes/tshirt-femme-col-rond-mc-un-developpeur-ecrit-du-code-stop-white.jpg",
                    DateCreated = new DateTime(2021, 04, 04)
                },
                new Product
                {
                    Id = 77,
                    CategoryId = 2,
                    Title = "T-shirt Un développeur écrit du code Stop Homme",
                    Description = "Découvrez la collection T-shirt homme manche courte col rond Blanc Un développeur écrit du code Stop. Pas cher & Livraison rapide avec du choix et du stock.",
                    Image = "https://www.coque-unique.com/clothes/tshirt-mc-col-rond-un-developpeur-ecrit-du-code-stop-white.jpg",
                    DateCreated = new DateTime(2021, 04, 04)
                }
            );

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Default" },
                new Edition { Id = 2, Name = "Paperback" },
                new Edition { Id = 3, Name = "E-Book" },
                new Edition { Id = 4, Name = "Audiobook" },
                new Edition { Id = 5, Name = "Pc" },
                new Edition { Id = 6, Name = "X-Box" },
                new Edition { Id = 7, Name = "Playstation" }
            );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 22,
                    EditionId = 2,
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 22,
                    EditionId = 3,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 5,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 6,
                    Price = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 7,
                    Price = 49.99m,
                    OriginalPrice = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 18,
                    EditionId = 5,
                    Price = 9.99m,
                    OriginalPrice = 24.99m,
                },
                new ProductVariant
                {
                    ProductId = 57,
                    EditionId = 5,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 76,
                    EditionId = 1,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 77,
                    EditionId = 1,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 1,
                    Price = 73.74m,
                    OriginalPrice = 400m
                }
            );
        }
    }
}
