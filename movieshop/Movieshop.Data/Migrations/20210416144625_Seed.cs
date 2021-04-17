using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movieshop.Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    Awards = table.Column<string>(maxLength: 200, nullable: true),
                    Gender = table.Column<string>(maxLength: 50, nullable: true),
                    YearsActive = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    MovieName = table.Column<string>(maxLength: 150, nullable: true),
                    ProducerName = table.Column<string>(maxLength: 150, nullable: true),
                    ProductionName = table.Column<string>(maxLength: 250, nullable: true),
                    Category = table.Column<string>(maxLength: 100, nullable: true),
                    Genre = table.Column<string>(maxLength: 100, nullable: true),
                    MovieCountry = table.Column<string>(maxLength: 100, nullable: true),
                    TimeLast = table.Column<double>(nullable: false),
                    YearsToWatch = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    ShippingDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    YearsActive = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Production",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    Year = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Production", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WatchLatter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchLatter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 250, nullable: true),
                    GenreName = table.Column<string>(maxLength: 100, nullable: true),
                    GenreId = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(maxLength: 100, nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    ActersName = table.Column<string>(maxLength: 250, nullable: true),
                    ActorId = table.Column<int>(nullable: true),
                    ActersId = table.Column<int>(nullable: false),
                    ProducerName = table.Column<string>(maxLength: 250, nullable: true),
                    ProducerId = table.Column<int>(nullable: false),
                    ProductionName = table.Column<string>(maxLength: 250, nullable: true),
                    ProductionId = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(maxLength: 150, nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Realise = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 1500, nullable: true),
                    Language = table.Column<string>(maxLength: 100, nullable: true),
                    URL = table.Column<string>(nullable: true),
                    Rating = table.Column<double>(nullable: false),
                    Awards = table.Column<int>(nullable: false),
                    TimeLast = table.Column<double>(nullable: false),
                    YearsToWatch = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movie_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Producer_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Production_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Production",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "Awards", "BirthDate", "Country", "Gender", "Name", "YearsActive" },
                values: new object[,]
                {
                    { 5, "61", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(6300), "USA", "Female", "Julia Roberts", " 1987–present" },
                    { 9, "99", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(6313), "USA", "Male", "Leonardo DiCaprio", "1989–present" },
                    { 8, "16", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(6310), "USA", "Male", "Dwayne Johnson-The Rock", " 1999–present" },
                    { 7, "36", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(6306), "USA", "Male", "Tom Cruise", " 1981–present" },
                    { 1, "33", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(5440), "USA", "Male", "Silvester Stalone", "1968–present" },
                    { 2, "119", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(6252), "USA", "Male", "Brad Pitt", " 1987–present" },
                    { 3, "60", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(6291), "USA", "Female", "Angelina Jolie", "1982–present" },
                    { 4, "1", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(6295), "UK", "Male", "Jason Statham", "1993–present" },
                    { 6, "24", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(6303), "UK", "Female", "Keira Knightley", "1993–present" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b4280b6a-0613-4cbd-a9e6-f1701e926e73", "a6dd5dd9-2590-4f1f-a314-80565105fc82", "admin", "ADMIN" },
                    { "b4280b6a-0613-4cbd-a9e6-f1701e926e75", "12f93c61-26b6-4643-9cf6-cfcc002fbe33", "guest", "GUEST" },
                    { "b4280b6a -0613-4cbd-a9e6-f1701e926e74", "a0ae26bb-3f47-4867-90ec-d6ca79dd9c41", "editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b4280b6a-0613-4cbd-a9e6-f1701e926e73", 0, "c8554266 -b401-4519-9aeb-a9283053fc58", "admin@movieshop.com", true, false, null, "ADMIN@MOVIESHOP.COM", "ADMIN@MOVIESHOP.COM", "AQAAAAEAACcQAAAAEMJCvkNLBOWOystmwD0hIGzHvPd52qFTGd42mfLpHjpdqBm7NwAQ2AuyYWR9OxbN+w==", null, false, "", false, "admin@movieshop.com" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 11, "History" },
                    { 10, "Biography" },
                    { 9, "Thriller" },
                    { 8, "Crime" },
                    { 7, "Adventure" },
                    { 12, "Undefined" },
                    { 5, "Comedy" },
                    { 4, "Drama" },
                    { 3, "Sci-Fi" },
                    { 2, "Action" },
                    { 1, "Romance" },
                    { 6, "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 12, "Undefined" },
                    { 11, "History" },
                    { 9, "Thriller" },
                    { 8, "Crime" },
                    { 7, "Adventure" },
                    { 10, "Biography" },
                    { 5, "Comedy" },
                    { 4, "Drama" },
                    { 3, "Sci-Fi" },
                    { 2, "Action" },
                    { 1, "Romance" },
                    { 6, "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Producer",
                columns: new[] { "Id", "BirthDate", "Country", "Gender", "Name", "YearsActive" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 4, 16, 16, 46, 24, 840, DateTimeKind.Local).AddTicks(573), "USA", "Female", "Kathleen Kennedy", "1979–present" },
                    { 5, new DateTime(2021, 4, 16, 16, 46, 24, 840, DateTimeKind.Local).AddTicks(569), "UK", "Male", "David Heyman", "1992-present" },
                    { 4, new DateTime(2021, 4, 16, 16, 46, 24, 840, DateTimeKind.Local).AddTicks(566), "USA", "Male", "Jerry Bruckheimer", "1972–present" },
                    { 2, new DateTime(2021, 4, 16, 16, 46, 24, 840, DateTimeKind.Local).AddTicks(531), "USA", "Male", "Gore Verbinski", "	1989–present" },
                    { 1, new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(9702), "Canada", "Male", "James Cameron", "1974–present" },
                    { 3, new DateTime(2021, 4, 16, 16, 46, 24, 840, DateTimeKind.Local).AddTicks(563), "USA", "Male", "Kevin Feige", "2000–present" }
                });

            migrationBuilder.InsertData(
                table: "Production",
                columns: new[] { "Id", "Country", "Name", "Year" },
                values: new object[,]
                {
                    { 6, "USA", "Universal Studios", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(8864) },
                    { 1, "USA", "Universal Pictures", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(8605) },
                    { 2, "USA", "Warner Brothers", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(8838) },
                    { 3, "USA", "20th Century", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(8854) },
                    { 4, "USA", "Columbia Pictures", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(8857) },
                    { 5, "USA", "Walt Disney Pictures", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(8861) },
                    { 7, "USA", "New Line Cinema", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(8867) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "b4280b6a-0613-4cbd-a9e6-f1701e926e73", "b4280b6a-0613-4cbd-a9e6-f1701e926e73" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "ActersId", "ActersName", "ActorId", "Awards", "CategoryId", "CategoryName", "Country", "DateAdded", "Description", "GenreId", "GenreName", "Language", "Price", "ProducerId", "ProducerName", "ProductionId", "ProductionName", "Rating", "Realise", "TimeLast", "Title", "URL", "YearsToWatch" },
                values: new object[,]
                {
                    { 2, 4, "Jason Statham", null, 7, 2, "Action", "USA", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4448), "When a mysterious woman seduces Dominic Toretto into the world of terrorism and a betrayal of those closest to him, the crew face trials that will test them as never before", 8, "Crime", "English", 6.9900000000000002, 3, "Kevin Feige", 1, "Universal Pictures", 6.7000000000000002, new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4433), 2.2400000000000002, "The Fate of the Furious", "fateofthefurious.jpg", 16 },
                    { 5, 6, " Keira Knightley", null, 1, 4, "Drama", "USA", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4532), "Colette is pushed by her husband to write novels under his name. Upon their success, she fights to make her talents known, challenging gender norms.", 10, "Biography", "English", 5.79, 6, "Kathleen Kennedy", 3, "20th Century", 6.7000000000000002, new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4529), 1.52, "Colette ", "colette.jpg", 8 },
                    { 7, 9, "Leonardo DiCaprio", null, 11, 4, "Drama", "USA", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4546), "A seventeen - year - old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill - fated R.M.S.Titanic.", 1, "Romance", "English", 9.9900000000000002, 1, "James Cameron", 3, "20th Century", 7.7999999999999998, new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4543), 3.2000000000000002, "Titanic", "titanic_.jpg", 8 },
                    { 4, 1, " ‎Sylvester Stallone", null, 4, 2, "Action", "USA", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4524), "Rambo must confront his past and unearth his ruthless combat skills to exact revenge in a final mission.", 9, "Thriller", "English", 6.8899999999999997, 5, "David Heyman", 4, "Columbia Pictures", 6.0999999999999996, new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4521), 1.3300000000000001, "Rambo: Last Blood", "", 16 },
                    { 6, 7, "Tom Cruise", null, 5, 5, "Comedy", "USA", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4539), " talented New York City bartender takes a job at a bar in Jamaica and falls in love.", 1, "Romance", "English", 6.8899999999999997, 4, "Jerry Bruckheimer", 6, "Universal Studios", 5.9000000000000004, new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4536), 1.49, "Cocktail", "coctail.jpg", 12 },
                    { 1, 8, "Dwayne Johnson-The Rock", null, 2, 2, "Action", "USA", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(3149), "In the aftermath of a massive earthquake in California, a rescue-chopper pilot makes a dangerous journey with his ex-wife across the state in order to rescue his daughter.", 9, "Thriller", "English", 9.9000000000000004, 4, "Jerry Bruckheimer", 7, "New Line Cinema", 6.0999999999999996, new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(2865), 1.54, "San Andreas", "San_Andreas_poster.jpg", 12 },
                    { 3, 3, "Angelina Jolie", null, 5, 2, "Action", "USA", new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4517), "A bored married couple is surprised to learn that they are both assassins hired by competing agencies to kill each other.", 5, "Comedy", "English", 5.4900000000000002, 6, "Kathleen Kennedy", 7, "New Line Cinema", 6.5, new DateTime(2021, 4, 16, 16, 46, 24, 839, DateTimeKind.Local).AddTicks(4513), 2.6000000000000001, "Mr. & Mrs. Smith ", "smithFamily.jpg", 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_ActorId",
                table: "Movie",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CategoryId",
                table: "Movie",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_GenreId",
                table: "Movie",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_ProducerId",
                table: "Movie",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_ProductionId",
                table: "Movie",
                column: "ProductionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ShoppingCard");

            migrationBuilder.DropTable(
                name: "WatchLatter");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Producer");

            migrationBuilder.DropTable(
                name: "Production");
        }
    }
}
