using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorShop.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 1, "book", "Books", "books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 3, "aperture", "Video game", "video-game" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "briefcase", "Clothes", "clothes" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 4, 6, 22, 20, 50, 24, DateTimeKind.Local).AddTicks(2487), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "t is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "https://i.pinimg.com/originals/d0/7f/49/d07f49fad86f488c5d13b7d71f7c2abb.jpg", false, false, 19.99m, 9.99m, "The Hitchhiker's Guide to the Galaxy" },
                    { 22, 1, new DateTime(2021, 4, 6, 22, 20, 50, 26, DateTimeKind.Local).AddTicks(4197), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hypérion est un roman de science-fiction appartenant au genre space opera, écrit par Dan Simmons en 1989 et publié en France en 1991.", "https://i.pinimg.com/originals/bf/0b/bd/bf0bbd47c62723da28597fcbba4ac366.jpg", false, false, 19.99m, 9.99m, "Hyperion" },
                    { 7, 3, new DateTime(2021, 4, 6, 22, 20, 50, 26, DateTimeKind.Local).AddTicks(4162), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Half-Life saga is the story of Gordon Freeman, a physicist who finds himself at the center of resistance to an alien invasion that threatens the future of humanity. From Valve's 1998 debut game onward, the series has been at the forefront of immersive action and storytelling.", "https://images-na.ssl-images-amazon.com/images/I/512Lrp-8JxL._SX378_BO1,204,203,200_.jpg", false, false, 29.99m, 8.19m, "Half-Life 2" },
                    { 18, 3, new DateTime(2021, 4, 6, 22, 20, 50, 26, DateTimeKind.Local).AddTicks(4191), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diablo III est un jeu vidéo d'action et de rôle de type hack and slash développé par Blizzard Entertainment. Il constitue le troisième opus de la série, succédant à Diablo et à Diablo II. Publié par Activision Blizzard, le jeu a bénéficié d'une sortie mondiale le 15 mai 2012.", "https://s3.gaming-cdn.com/images/products/20/271x377/diablo-iii-cover.jpg", false, false, 29.99m, 19.99m, "Diablo 3" },
                    { 57, 3, new DateTime(2021, 4, 6, 22, 20, 50, 26, DateTimeKind.Local).AddTicks(4194), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Day of the Tentacle, également connu sous le nom de Maniac Mansion: Day of the Tentacle, est un jeu vidéo d'aventure graphique développé et publié par LucasArts en juin 1993 sur PC puis Macintosh. Le jeu est sorti à la fois sur disquettes et sur CD-ROM, et fait suite à Maniac Mansion sorti en 1987", "https://static.trueachievements.com/boxart/Game_8970.jpg", false, false, 9.99m, 9.99m, "Day of the Tentacles" },
                    { 76, 2, new DateTime(2021, 4, 6, 22, 20, 50, 26, DateTimeKind.Local).AddTicks(4199), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Découvrez la collection T-shirt femme manche courte col rond Blanc Un développeur écrit du code Stop. Pas cher & Livraison rapide avec du choix et du stock.", "https://www.coque-unique.com/clothes/tshirt-femme-col-rond-mc-un-developpeur-ecrit-du-code-stop-white.jpg", false, false, 25.99m, 11.99m, "T-shirt Un développeur écrit du code Stop Femme" },
                    { 77, 2, new DateTime(2021, 4, 6, 22, 20, 50, 26, DateTimeKind.Local).AddTicks(4201), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Découvrez la collection T-shirt homme manche courte col rond Blanc Un développeur écrit du code Stop. Pas cher & Livraison rapide avec du choix et du stock.", "https://www.coque-unique.com/clothes/tshirt-mc-col-rond-un-developpeur-ecrit-du-code-stop-white.jpg", false, false, 25.99m, 11.99m, "T-shirt Un développeur écrit du code Stop Homme" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
