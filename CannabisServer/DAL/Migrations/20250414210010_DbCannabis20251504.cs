using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class DbCannabis20251504 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Products");

            migrationBuilder.EnsureSchema(
                name: "Inventory");

            migrationBuilder.EnsureSchema(
                name: "Orders");

            migrationBuilder.EnsureSchema(
                name: "Users");

            migrationBuilder.EnsureSchema(
                name: "Logs");

            migrationBuilder.EnsureSchema(
                name: "lighting");

            migrationBuilder.EnsureSchema(
                name: "Promotions");

            migrationBuilder.EnsureSchema(
                name: "Reviews");

            migrationBuilder.EnsureSchema(
                name: "Oders");

            migrationBuilder.CreateTable(
                name: "Brands",
                schema: "Products",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Website = table.Column<string>(type: "VARCHAR(MAX)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Breeders",
                columns: table => new
                {
                    BreederId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreederName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Website = table.Column<string>(type: "NVARCHAR(MAX)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breeders", x => x.BreederId);
                });

            migrationBuilder.CreateTable(
                name: "CartSatus",
                schema: "Orders",
                columns: table => new
                {
                    CartSatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartSatusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartSatus", x => x.CartSatusId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "Products",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ChipModels",
                schema: "Inventory",
                columns: table => new
                {
                    ChipModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModelChip = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Generation = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Efficiency = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChipModels", x => x.ChipModelId);
                });

            migrationBuilder.CreateTable(
                name: "Classifies",
                columns: table => new
                {
                    ClassificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassificationName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifies", x => x.ClassificationId);
                });

            migrationBuilder.CreateTable(
                name: "CoolingSystems",
                schema: "Inventory",
                columns: table => new
                {
                    CoolingSystemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoolingSystems", x => x.CoolingSystemId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "Users",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HashPassword = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Is_anonymous = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Status = table.Column<string>(type: "nvarchar(20)", nullable: false, defaultValue: "Active"),
                    Token = table.Column<string>(type: "TEXT", nullable: false),
                    RefreshToken = table.Column<string>(type: "TEXT", nullable: false),
                    TokenExpiry = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "NutrientTypes",
                schema: "Inventory",
                columns: table => new
                {
                    NutrientTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutrientName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutrientTypes", x => x.NutrientTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                schema: "lighting",
                columns: table => new
                {
                    PowerSupplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Voltage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.PowerSupplyId);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                schema: "Promotions",
                columns: table => new
                {
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromotionName = table.Column<string>(type: "NVARCHAR(255)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    DiscountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    MinimumOrderValue = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    MinimumQuantity = table.Column<int>(type: "int", nullable: false),
                    MaximumDiscountValue = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.PromotionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "Users",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Spectrums",
                schema: "Inventory",
                columns: table => new
                {
                    SpectrumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spectrums", x => x.SpectrumId);
                });

            migrationBuilder.CreateTable(
                name: "CarbonFilters",
                schema: "Inventory",
                columns: table => new
                {
                    CarbonFilterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarbonFilterName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AirflowRate = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    FilterMaterial = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Diameter = table.Column<decimal>(type: "decimal(4,2)", precision: 10, scale: 2, nullable: false),
                    Length = table.Column<decimal>(type: "decimal(4,2)", precision: 10, scale: 2, nullable: false),
                    Lifespan = table.Column<int>(type: "int", nullable: false),
                    MinTemperature = table.Column<decimal>(type: "decimal(3,2)", precision: 10, scale: 2, nullable: false),
                    MaxTemperature = table.Column<decimal>(type: "decimal(3,2)", precision: 10, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "int", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarbonFilters", x => x.CarbonFilterId);
                    table.ForeignKey(
                        name: "FK_CARBONFILTER_BRAND_CARBONFILTERID",
                        column: x => x.BrandId,
                        principalSchema: "Products",
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dehumidifiers",
                schema: "Inventory",
                columns: table => new
                {
                    DehumidifierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DehumidifierName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DehumidificationCapacity = table.Column<decimal>(type: "decimal(3,2)", precision: 10, scale: 2, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CoverageArea = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    NoiseLevel = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    PowerConsumption = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dehumidifiers", x => x.DehumidifierId);
                    table.ForeignKey(
                        name: "FK_DEHUMIDIFIERS_BRAND",
                        column: x => x.BrandId,
                        principalSchema: "Products",
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrowTents",
                schema: "Inventory",
                columns: table => new
                {
                    GrowtentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Material = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Waterproof = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    FrameMaterial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowTents", x => x.GrowtentId);
                    table.ForeignKey(
                        name: "FK_GROWTENT_BRAND_BRANDID",
                        column: x => x.BrandId,
                        principalSchema: "Products",
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seeds",
                schema: "Inventory",
                columns: table => new
                {
                    SeedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreederId = table.Column<int>(type: "int", nullable: false),
                    THCContent = table.Column<string>(type: "varchar(30)", precision: 5, scale: 2, nullable: false),
                    CBDContent = table.Column<string>(type: "varchar(30)", precision: 5, scale: 2, nullable: false),
                    StrainType = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ClassifyId = table.Column<int>(type: "int", nullable: false),
                    FloweringTimeDays = table.Column<int>(type: "INT", nullable: false),
                    Yield = table.Column<decimal>(type: "decimal(5,2)", precision: 10, scale: 2, nullable: false),
                    Difficulty = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    IndicaPercentage = table.Column<decimal>(type: "decimal(3,2)", precision: 5, scale: 2, nullable: false),
                    SativaPercentage = table.Column<decimal>(type: "decimal(3,2)", precision: 5, scale: 2, nullable: false),
                    TotalQuantity = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seeds", x => x.SeedId);
                    table.ForeignKey(
                        name: "FK_SEED_CLASSIFICATION_CLASSIFYID",
                        column: x => x.ClassifyId,
                        principalTable: "Classifies",
                        principalColumn: "ClassificationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seeds_Breeders_BreederId",
                        column: x => x.BreederId,
                        principalTable: "Breeders",
                        principalColumn: "BreederId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    District = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Commune = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Road_Village_Hamlet = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_ADRESS_CUSTOMER_CUSTOMERID",
                        column: x => x.CustomerId,
                        principalSchema: "Users",
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                schema: "Orders",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Session_Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Date_Added = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Total_Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_CART_CUSTOMER_CUSTOMERID",
                        column: x => x.CustomerId,
                        principalSchema: "Users",
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nutrients",
                schema: "Inventory",
                columns: table => new
                {
                    NutrientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    NutrientTypeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    VolumeMl = table.Column<int>(type: "int", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NpkRatio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsOrganic = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StorageInstructions = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.NutrientId);
                    table.ForeignKey(
                        name: "FK_NUTRIENT_BRAND_BRANDID",
                        column: x => x.BrandId,
                        principalSchema: "Products",
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NUTRIENT_NUTRIENTTYPE_NUTRIENTTYPEID",
                        column: x => x.NutrientTypeId,
                        principalSchema: "Inventory",
                        principalTable: "NutrientTypes",
                        principalColumn: "NutrientTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promotion_Category",
                schema: "Promotions",
                columns: table => new
                {
                    PromotionId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion_Category", x => new { x.PromotionId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_PROMOTIONCATEGORY_CATEGORY_CATEGORYID",
                        column: x => x.CategoryId,
                        principalSchema: "Products",
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PROMOTIONCATEGORY_PROMOTION_PROMOTIONID",
                        column: x => x.PromotionId,
                        principalSchema: "Promotions",
                        principalTable: "Promotions",
                        principalColumn: "PromotionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                schema: "Users",
                columns: table => new
                {
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HashPassword = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Satus = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false),
                    RefreshToken = table.Column<string>(type: "TEXT", nullable: false),
                    TokenExpiry = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SellerId);
                    table.ForeignKey(
                        name: "FK_SELLER_ROLE_ROLEID",
                        column: x => x.SellerId,
                        principalSchema: "Users",
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrowLights",
                schema: "Inventory",
                columns: table => new
                {
                    GrowLightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Wattage = table.Column<int>(type: "int", precision: 10, scale: 2, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    CoverageArea = table.Column<int>(type: "int", precision: 10, scale: 2, nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "int", nullable: false),
                    PowerSupplyId = table.Column<int>(type: "int", nullable: false),
                    ChipModelId = table.Column<int>(type: "int", nullable: false),
                    CoolingSystemId = table.Column<int>(type: "int", nullable: false),
                    SpectrumId = table.Column<int>(type: "int", nullable: false),
                    Lifespan = table.Column<int>(type: "int", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowLights", x => x.GrowLightId);
                    table.ForeignKey(
                        name: "FK_GROWLIGHT_BRAND_BRANDID",
                        column: x => x.BrandId,
                        principalSchema: "Products",
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GROWLIGHT_CHIPMODEL_CHIPMODELID",
                        column: x => x.ChipModelId,
                        principalSchema: "Inventory",
                        principalTable: "ChipModels",
                        principalColumn: "ChipModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GROWLIGHT_COOLINGSYSTEM_COOLINGSYSTEMID",
                        column: x => x.CoolingSystemId,
                        principalSchema: "Inventory",
                        principalTable: "CoolingSystems",
                        principalColumn: "CoolingSystemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GROWLIGHT_POWERSUPPLY_POWERSUPPLYID",
                        column: x => x.PowerSupplyId,
                        principalSchema: "lighting",
                        principalTable: "PowerSupplies",
                        principalColumn: "PowerSupplyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GROWLIGHT_SPECTRUM_SPECTRUMID",
                        column: x => x.SpectrumId,
                        principalSchema: "Inventory",
                        principalTable: "Spectrums",
                        principalColumn: "SpectrumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                schema: "Logs",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_LOG_SELLER_SELLERID",
                        column: x => x.SellerId,
                        principalSchema: "Users",
                        principalTable: "Sellers",
                        principalColumn: "SellerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    OrderSatus = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    ShippingAddress = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    ShippingFee = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    TrackingNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_ORDER_CUSTOMER_CUSTOMERID",
                        column: x => x.CustomerId,
                        principalSchema: "Users",
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDER_SELLER_SELLERID",
                        column: x => x.SellerId,
                        principalSchema: "Users",
                        principalTable: "Sellers",
                        principalColumn: "SellerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_CARBONFILTER_PRODUCT_PRODUCTTYPEID",
                        column: x => x.ProductTypeId,
                        principalSchema: "Inventory",
                        principalTable: "CarbonFilters",
                        principalColumn: "CarbonFilterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DEHUMIDIFIER_PRODUCT_PRODUCTTYPEID",
                        column: x => x.ProductTypeId,
                        principalSchema: "Inventory",
                        principalTable: "Dehumidifiers",
                        principalColumn: "DehumidifierId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GROWLIGHT_PRODUCT_PRODUCTTYPEID",
                        column: x => x.ProductTypeId,
                        principalSchema: "Inventory",
                        principalTable: "GrowLights",
                        principalColumn: "GrowLightId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GROWTENT_PRODUCT_PRODUCTTYPEID",
                        column: x => x.ProductTypeId,
                        principalSchema: "Inventory",
                        principalTable: "GrowTents",
                        principalColumn: "GrowtentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NUTRIENT_PRODUCT_PRODUCTTYPEID",
                        column: x => x.ProductTypeId,
                        principalSchema: "Inventory",
                        principalTable: "Nutrients",
                        principalColumn: "NutrientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PRODUCT_CATEGORY_CATEGORYID",
                        column: x => x.CategoryId,
                        principalSchema: "Products",
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SEED_PRODUCT_PRODUCTTYPEID",
                        column: x => x.ProductTypeId,
                        principalSchema: "Inventory",
                        principalTable: "Seeds",
                        principalColumn: "SeedId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                schema: "Orders",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PaymentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_PAYMENT_ORDER_ORDERID",
                        column: x => x.OrderId,
                        principalSchema: "Orders",
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingMethod",
                schema: "Oders",
                columns: table => new
                {
                    ShippingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Carrier = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EstimatedDeliveryDate = table.Column<int>(type: "INT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingMethod", x => x.ShippingId);
                    table.ForeignKey(
                        name: "FK_SHIPPINGMETHOD_ORDER_ORDERID",
                        column: x => x.OrderId,
                        principalSchema: "Orders",
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartDetails",
                schema: "Orders",
                columns: table => new
                {
                    CartDetailsId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CartStatusId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.CartDetailsId);
                    table.ForeignKey(
                        name: "FK_CARTDETAILS_CARTSTATUS_CARTSTATUSID",
                        column: x => x.CartDetailsId,
                        principalSchema: "Orders",
                        principalTable: "CartSatus",
                        principalColumn: "CartSatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CARTDETAILS_CART_CARTID",
                        column: x => x.CartId,
                        principalSchema: "Orders",
                        principalTable: "Carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CARTDETAILS_PRODUCT_PRODUCTID",
                        column: x => x.ProductId,
                        principalSchema: "Products",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                schema: "Orders",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_ODERITEM_ODER",
                        column: x => x.OderId,
                        principalSchema: "Orders",
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ODERITEM_PRODUCT",
                        column: x => x.ProductId,
                        principalSchema: "Products",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                schema: "Products",
                columns: table => new
                {
                    ProductImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMainImage = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ProductImageId);
                    table.ForeignKey(
                        name: "FK_PRODUCTIMAGE_PRODUCT_PRODUCTID",
                        column: x => x.ProductId,
                        principalSchema: "Products",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promotion_Produc",
                schema: "Promotions",
                columns: table => new
                {
                    PromotionId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion_Produc", x => new { x.PromotionId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_PROMOTIONPRODUCT_PRODUCT_PRODUCTID",
                        column: x => x.ProductId,
                        principalSchema: "Products",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PROMOTIONPRODUCT_PROMOTION_PROMOTIONID",
                        column: x => x.PromotionId,
                        principalSchema: "Promotions",
                        principalTable: "Promotions",
                        principalColumn: "PromotionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                schema: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customerid = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    ReviewTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.CheckConstraint("CK_Review_Rating", "Rating BETWEEN 1 AND 5");
                    table.ForeignKey(
                        name: "FK_REVIEW_CUSTOMER_CUSTOMERID",
                        column: x => x.Customerid,
                        principalSchema: "Users",
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_REVIEW_ORDER_ORDERID",
                        column: x => x.OrderId,
                        principalSchema: "Orders",
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_REVIEW_PRODUCT_PRODUCTID",
                        column: x => x.ProductId,
                        principalSchema: "Products",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BREEDER_EMAIL",
                table: "Breeders",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarbonFilters_BrandId",
                schema: "Inventory",
                table: "CarbonFilters",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_CartId",
                schema: "Orders",
                table: "CartDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ProductId",
                schema: "Orders",
                table: "CartDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerId",
                schema: "Orders",
                table: "Carts",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORY_CATEGORYNAME",
                schema: "Products",
                table: "Categories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CUSTOMER_EMAIL)",
                schema: "Users",
                table: "Customers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CUSTOMER_USERNAME",
                schema: "Users",
                table: "Customers",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dehumidifiers_BrandId",
                schema: "Inventory",
                table: "Dehumidifiers",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowLights_BrandId",
                schema: "Inventory",
                table: "GrowLights",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowLights_ChipModelId",
                schema: "Inventory",
                table: "GrowLights",
                column: "ChipModelId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowLights_CoolingSystemId",
                schema: "Inventory",
                table: "GrowLights",
                column: "CoolingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowLights_PowerSupplyId",
                schema: "Inventory",
                table: "GrowLights",
                column: "PowerSupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowLights_SpectrumId",
                schema: "Inventory",
                table: "GrowLights",
                column: "SpectrumId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowTents_BrandId",
                schema: "Inventory",
                table: "GrowTents",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_SellerId",
                schema: "Logs",
                table: "Logs",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_BrandId",
                schema: "Inventory",
                table: "Nutrients",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_NutrientTypeId",
                schema: "Inventory",
                table: "Nutrients",
                column: "NutrientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OderId",
                schema: "Orders",
                table: "OrderItems",
                column: "OderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                schema: "Orders",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                schema: "Orders",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SellerId",
                schema: "Orders",
                table: "Orders",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                schema: "Orders",
                table: "Payments",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                schema: "Products",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                schema: "Products",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                schema: "Products",
                table: "Products",
                column: "ProductTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_Category_CategoryId",
                schema: "Promotions",
                table: "Promotion_Category",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_Produc_ProductId",
                schema: "Promotions",
                table: "Promotion_Produc",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Customerid",
                schema: "Reviews",
                table: "Reviews",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_OrderId",
                schema: "Reviews",
                table: "Reviews",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                schema: "Reviews",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Seeds_BreederId",
                schema: "Inventory",
                table: "Seeds",
                column: "BreederId");

            migrationBuilder.CreateIndex(
                name: "IX_Seeds_ClassifyId",
                schema: "Inventory",
                table: "Seeds",
                column: "ClassifyId");

            migrationBuilder.CreateIndex(
                name: "IX_SEELER_EMAIL",
                schema: "Users",
                table: "Sellers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SEELER_USERNAME",
                schema: "Users",
                table: "Sellers",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShippingMethod_OrderId",
                schema: "Oders",
                table: "ShippingMethod",
                column: "OrderId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CartDetails",
                schema: "Orders");

            migrationBuilder.DropTable(
                name: "Logs",
                schema: "Logs");

            migrationBuilder.DropTable(
                name: "OrderItems",
                schema: "Orders");

            migrationBuilder.DropTable(
                name: "Payments",
                schema: "Orders");

            migrationBuilder.DropTable(
                name: "ProductImages",
                schema: "Products");

            migrationBuilder.DropTable(
                name: "Promotion_Category",
                schema: "Promotions");

            migrationBuilder.DropTable(
                name: "Promotion_Produc",
                schema: "Promotions");

            migrationBuilder.DropTable(
                name: "Reviews",
                schema: "Reviews");

            migrationBuilder.DropTable(
                name: "ShippingMethod",
                schema: "Oders");

            migrationBuilder.DropTable(
                name: "CartSatus",
                schema: "Orders");

            migrationBuilder.DropTable(
                name: "Carts",
                schema: "Orders");

            migrationBuilder.DropTable(
                name: "Promotions",
                schema: "Promotions");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Products");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "Orders");

            migrationBuilder.DropTable(
                name: "CarbonFilters",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "Dehumidifiers",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "GrowLights",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "GrowTents",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "Nutrients",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "Products");

            migrationBuilder.DropTable(
                name: "Seeds",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "Customers",
                schema: "Users");

            migrationBuilder.DropTable(
                name: "Sellers",
                schema: "Users");

            migrationBuilder.DropTable(
                name: "ChipModels",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "CoolingSystems",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "PowerSupplies",
                schema: "lighting");

            migrationBuilder.DropTable(
                name: "Spectrums",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "Brands",
                schema: "Products");

            migrationBuilder.DropTable(
                name: "NutrientTypes",
                schema: "Inventory");

            migrationBuilder.DropTable(
                name: "Classifies");

            migrationBuilder.DropTable(
                name: "Breeders");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "Users");
        }
    }
}
