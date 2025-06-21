using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enum.EnumableClass.EnumableClass;

namespace DAL.Dbcontext
{
    public class CannabisAccessorriesDBContext : DbContext
    {


        public CannabisAccessorriesDBContext(DbContextOptions<CannabisAccessorriesDBContext> options) : base(options)
        {

        }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Breeder> Breeders { get; set; }
        public virtual DbSet<CarbonFilter> CarbonFilters { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartDetails> CartDetails { get; set; }
        public virtual DbSet<CartStatus> CartsStatuses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ChipModel> ChipModels { get; set; }
        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<CoolingSystem> CoolingSystems { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Dehumidifier> Dehumidifiers { get; set; }
        public virtual DbSet<GrowTent> GrowTents { get; set; }
        public virtual DbSet<GrowLight> GrowLights { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Nutrient> Nutrients { get; set; }
        public virtual DbSet<NutrientType> NutrientTypes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PowerSupply> PowerSupplies { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<PromotionCategory> PromotionCategories { get; set; }
        public virtual DbSet<PromotionProduct> PromotionProducts { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Seed> Seeds { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }
        public virtual DbSet<Spectrum> Spectrums { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Table Addresses
            modelBuilder.Entity<Address>() //primary key
                .HasKey(a => a.AddressId);
            modelBuilder.Entity<Address>()
                .Property(a => a.AddressId)
                .ValueGeneratedOnAdd();//tự động tăng 

            modelBuilder.Entity<Address>() // foreignkey
                .HasOne(c => c.Customer) //navigation
                .WithMany(a => a.Addresses) //1-n
                .HasForeignKey(a => a.CustomerId)
                .HasConstraintName("FK_ADRESS_CUSTOMER_CUSTOMERID")
                .IsRequired();

            modelBuilder.Entity<Address>()
                .Property(a => a.Country)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Address>()
                .Property(a => a.Province)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Address>()
                .Property(a => a.District)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Address>()
                .Property(a => a.Commune)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Address>()
                .Property(a => a.Road_Village_Hamlet)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Address>()
                .Property(a => a.HouseNumber)
               .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Address>()
                .Property(a => a.PostalCode)
                .HasMaxLength(30)
                .IsRequired();
            modelBuilder.Entity<Address>()
                .Property<bool>(a => a.IsDefault)
                .HasDefaultValue(false); //giá trị mặc định
            modelBuilder.Entity<Address>()
                .Property(a => a.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder.Entity<Address>()
                .Property(a => a.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                 .IsRequired();
            #endregion
            #region Table Brands
            modelBuilder.Entity<Brand>()
                .HasKey(b => b.BrandId); // primary key
            modelBuilder.Entity<Brand>()
                .Property(b => b.BrandId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Brand>()
                .Property(b => b.BrandName)
               .HasMaxLength(255)
                .IsRequired();
            modelBuilder.Entity<Brand>()
                .Property(b => b.Country)
                .HasMaxLength(255)
                .IsRequired();
            modelBuilder.Entity<Brand>()
                .Property(b => b.Description)
                .HasColumnType("NVARCHAR(MAX)")
                .IsRequired();
            modelBuilder.Entity<Brand>()
                .Property(b => b.CreatedAt)
                 .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                 .IsRequired();
            modelBuilder.Entity<Brand>()
                .Property(b => b.UpdatedAt)
                 .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Brand>()
                .Property(b => b.Website)
                .HasColumnType("VARCHAR(MAX)")
                .IsRequired();
            modelBuilder.Entity<Brand>()
                .Property<bool>(b => b.IsActive)
                .HasDefaultValue(true);
            #endregion
            #region Table Breeder
            modelBuilder.Entity<Breeder>()
                .HasKey(b => b.BreederId);
            modelBuilder.Entity<Breeder>()
               .Property(b => b.BreederId)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Breeder>()
                .Property(b => b.BreederName)
                .HasMaxLength(255)
                .IsRequired();
            modelBuilder.Entity<Breeder>()
                .Property(b => b.Country)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Breeder>()
                .Property(b => b.Description)
                .HasColumnType("NVARCHAR(MAX)")
                .IsRequired();
            modelBuilder.Entity<Breeder>()
                .Property(b => b.Website)
                 .HasColumnType("NVARCHAR(MAX)")
                .IsRequired();
            modelBuilder.Entity<Breeder>()
                .Property(b => b.PhoneNumber)
                .HasMaxLength(20)
                .IsRequired();
            modelBuilder.Entity<Breeder>()
                .Property(b => b.Email)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Breeder>() //đánh index
                .HasIndex(b => b.Email)
                .IsUnique()
                .HasDatabaseName("IX_BREEDER_EMAIL");
            modelBuilder.Entity<Breeder>()
                .Property<bool>(b => b.IsActive)
                .HasDefaultValue(true);
            modelBuilder.Entity<Breeder>()
                .Property(b => b.CreatedAt)
                 .HasDefaultValueSql("CURRENT_TIMESTAMP")
                 .ValueGeneratedOnAdd()
                .IsRequired();
            #endregion
            #region Table ChipModels
            modelBuilder.Entity<ChipModel>()
              .HasKey(c => c.ChipModelId);
            modelBuilder.Entity<ChipModel>()
               .Property(c => c.ChipModelId)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<ChipModel>()
                .Property(c => c.Manufacturer)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<ChipModel>()
                .Property(c => c.ModelChip)
                .HasMaxLength(255)
                .IsRequired();
            modelBuilder.Entity<ChipModel>()
                .Property(c => c.Generation)
                .HasConversion<int>()
                .IsRequired();
            modelBuilder.Entity<ChipModel>()
                .Property(c => c.Efficiency)
                .HasPrecision(5,2)
                .IsRequired();

            #endregion
            #region Table CarbonFilters
            modelBuilder.Entity<CarbonFilter>()
                .HasKey(c => c.CarbonFilterId);
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.CarbonFilterId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<CarbonFilter>() // foreignkey
               .HasOne(b => b.Brand) //navigation
               .WithMany(c => c.CarbonFilters) //1-n
               .HasForeignKey(a => a.BrandId)
               .HasConstraintName("FK_CARBONFILTER_BRAND_CARBONFILTERID")
               .IsRequired();

            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.AirflowRate)
                .HasConversion<int>()
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.Quantity)
                .HasConversion<int>()
                .HasDefaultValue(0)
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.Price)
                .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.FilterMaterial)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.Diameter)
                .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.Length)
                .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.Lifespan)
               .HasConversion<int>()
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.MinTemperature)
               .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.MaxTemperature)
              .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.ModelNumber)
              .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.WarrantyPeriod)
              .HasConversion<int>()
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.Description)
                .HasColumnType("NVARCHAR(MAX)");

            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.CreatedAt)
                 .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder.Entity<CarbonFilter>()
                .Property(c => c.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd();
            #endregion
            #region Table Carts
            modelBuilder.Entity<Cart>()
                .HasKey(c => c.CartId);
            modelBuilder.Entity<Cart>()
                .Property(c => c.CartId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.Customer)
                .WithOne(c => c.Cart)
                .HasForeignKey<Cart>(c => c.CustomerId)
                .HasConstraintName("FK_CART_CUSTOMER_CUSTOMERID")
                .IsRequired();
            modelBuilder.Entity<Cart>()
                .Property(c => c.Session_Id)
                .HasMaxLength(255);
            modelBuilder.Entity<Cart>()
                .Property(c => c.Date_Added)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder.Entity<Cart>()
                .Property(c => c.Total_Price)
                .HasPrecision(10, 2);
            #endregion
            #region  Table CartDetails
            modelBuilder.Entity<CartDetails>()
                .HasKey(c => c.CartDetailsId);
            modelBuilder.Entity<CartDetails>()
                .Property(c => c.CartDetailsId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<CartDetails>()
                .HasOne(c => c.Cart)
                .WithMany(c => c.CartDetails)
                .HasForeignKey(c => c.CartId)
                .HasConstraintName("FK_CARTDETAILS_CART_CARTID")
                .IsRequired();
            modelBuilder.Entity<CartDetails>()
                .HasOne(c => c.Product)
                .WithMany(c => c.CartsDetails)
                .HasForeignKey(c => c.ProductId)
                .HasConstraintName("FK_CARTDETAILS_PRODUCT_PRODUCTID")
                .IsRequired();
            modelBuilder.Entity<CartDetails>()
                .HasOne(c => c.CartStatus)
                .WithMany(c => c.CartDetails)
                .HasForeignKey(c => c.CartDetailsId)
                .HasConstraintName("FK_CARTDETAILS_CARTSTATUS_CARTSTATUSID")
                .IsRequired();
            modelBuilder.Entity<CartDetails>()
                .Property<int>(c => c.Quantity);
            modelBuilder.Entity<CartDetails>()
                .Property(c => c.Price)
                .HasPrecision(10, 2);
            #endregion
            #region Table CartStatus
            modelBuilder.Entity<CartStatus>()
                .HasKey(c => c.CartSatusId);
            modelBuilder.Entity<CartStatus>()
                .Property(c => c.CartSatusId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<CartStatus>()
                .Property(c => c.CartSatusName)
                .HasMaxLength(100)
                .IsRequired();
            #endregion
            #region Table Categories
            modelBuilder.Entity<Category>()
                .HasKey(c => c.CategoryId);
            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryName)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Category>()
                .HasIndex(c => c.CategoryName)
                .IsUnique()
                .HasDatabaseName("IX_CATEGORY_CATEGORYNAME");
            modelBuilder.Entity<Category>()
                .Property(c => c.Description)
                .HasColumnType("NVARCHAR(MAX)");

            #endregion
            #region Table Chipmodels
            modelBuilder.Entity<ChipModel>()
                .HasKey(c => c.ChipModelId);
            modelBuilder.Entity<ChipModel>()
                .Property(c => c.ChipModelId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ChipModel>()
                .Property(c => c.Manufacturer)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<ChipModel>()
                .Property(c => c.ModelChip)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<ChipModel>()
                .Property(c => c.Generation)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<ChipModel>()
                .Property(c => c.Efficiency)
                .HasPrecision(5, 2)
                .IsRequired();


            #endregion
            #region Table Classifications
            modelBuilder.Entity<Classification>()
               .HasKey(c => c.ClassificationId);
            modelBuilder.Entity<Classification>()
                .Property(c => c.ClassificationId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Classification>()
                .Property(c => c.ClassificationName)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Classification>()
                .Property<int>(c => c.Quantity)
                .IsRequired();
            modelBuilder.Entity<Classification>()
                .Property(c => c.Description)
                .HasColumnType("NVARCHAR(MAX)");

            modelBuilder.Entity<Classification>()
                .Property(c => c.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder.Entity<Classification>()
                .Property(c => c.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder.Entity<Classification>()
                .Property<bool>(c => c.IsActive);
            #endregion
            #region Table CoolingSystems
            modelBuilder.Entity<CoolingSystem>()
                .HasKey(c => c.CoolingSystemId);
            modelBuilder.Entity<CoolingSystem>()
                .Property(c => c.CoolingSystemId)
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder.Entity<CoolingSystem>()
                .Property(c => c.Type)
                .HasConversion<string>()
                .IsRequired();
            modelBuilder.Entity<CoolingSystem>()
                .Property(c => c.Description)
                .HasColumnType("NVARCHAR(MAX)");

            #endregion
            #region Table  Customers
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.CustomerId);
            modelBuilder.Entity<Customer>()
                .Property(c => c.CustomerId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>()
                .Property(c => c.Username)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Username)
                .IsUnique()
                .HasDatabaseName("IX_CUSTOMER_USERNAME");
            modelBuilder.Entity<Customer>()
                .Property(c => c.HashPassword)
                .HasMaxLength(255)
                .IsRequired();
            modelBuilder.Entity<Customer>()
                .Property(c => c.Name)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Customer>()
                .Property(c => c.Email)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Email)
                .IsUnique()
                .HasDatabaseName("IX_CUSTOMER_EMAIL)");
            modelBuilder.Entity<Customer>()
                .Property(c => c.Phone)
                .HasMaxLength(20)
                .IsRequired();
            modelBuilder.Entity<Customer>()
                .Property<bool>(c => c.Is_anonymous)
                .HasDefaultValue(false);
            modelBuilder.Entity<Customer>()
               .Property(c => c.CreatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP")
               .ValueGeneratedOnAdd()
               .IsRequired();
            modelBuilder.Entity<Customer>()
                .Property(c => c.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                 .IsRequired();
            modelBuilder.Entity<Customer>()
                .Property(c => c.Status)
                .HasConversion<string>()
                .HasDefaultValue(ECustomerStatus.Active)
                .IsRequired();
            modelBuilder.Entity<Customer>()
                .Property(c => c.Token)
                .HasColumnType("TEXT");
            modelBuilder.Entity<Customer>()
                .Property(c => c.RefreshToken)
                .HasColumnType("TEXT");
            modelBuilder.Entity<Customer>()
                .Property(c => c.TokenExpiry)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
            #endregion
            #region Table Dehumidifiers
            modelBuilder.Entity<Dehumidifier>()
                .HasKey(c => c.DehumidifierId);
            modelBuilder.Entity<Dehumidifier>()
                .Property(c => c.DehumidifierId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Dehumidifier>()
                .Property(c => c.DehumidificationCapacity)
                .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<Dehumidifier>()
                .Property(c => c.DehumidifierName)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Dehumidifier>()
                .HasOne(c => c.Brand)
                .WithMany(c => c.Dehumidifiers)
                .HasForeignKey(c => c.BrandId)
                .HasConstraintName("FK_DEHUMIDIFIERS_BRAND")
                .IsRequired();
            modelBuilder.Entity<Dehumidifier>()
                .Property(c => c.CoverageArea)
                .HasPrecision(10, 2);
            modelBuilder.Entity<Dehumidifier>()
                .Property(c => c.NoiseLevel)
                .HasPrecision(5, 2);
            modelBuilder.Entity<Dehumidifier>()
                .Property(c => c.PowerConsumption)
                .HasPrecision(10, 2);
            #endregion
            #region Table GrowTents
            modelBuilder.Entity<GrowTent>()
                .HasKey(c => c.GrowtentId);
            modelBuilder.Entity<GrowTent>()
                .Property(c => c.GrowtentId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<GrowTent>()
                .HasOne(c => c.Brand)
                .WithMany(c => c.GrowTents)
                .HasForeignKey(c => c.BrandId)
                .HasConstraintName("FK_GROWTENT_BRAND_BRANDID")
                .IsRequired();
            modelBuilder.Entity<GrowTent>()
                .Property(c => c.Dimensions)
                .HasMaxLength(100);
            modelBuilder.Entity<GrowTent>()
                .Property(c => c.Material)
                .HasMaxLength(255);
            modelBuilder.Entity<GrowTent>()
                .Property<int>(c => c.Quantity)
                .IsRequired();
            modelBuilder.Entity<GrowTent>()
                .Property<bool>(c => c.Waterproof)
                .HasDefaultValue(false)
                .IsRequired();
            modelBuilder.Entity<GrowTent>()
                .Property(c => c.Price)
                .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<GrowTent>()
                .Property(c => c.FrameMaterial)
                .HasMaxLength(255)
                .IsRequired();
            modelBuilder.Entity<GrowTent>()
                .Property<int>(c => c.WarrantyPeriod);
            modelBuilder.Entity<GrowTent>()
               .Property(c => c.Description)
               .HasColumnType("NVARCHAR(MAX)");
            modelBuilder.Entity<GrowTent>()
               .Property(c => c.CreatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP")
               .ValueGeneratedOnAdd()
               .IsRequired();
            modelBuilder.Entity<GrowTent>()
               .Property(c => c.UpdatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP")
               .ValueGeneratedOnAdd()
               .IsRequired();
            #endregion
            #region Table GrowLights
            modelBuilder.Entity<GrowLight>()
              .HasKey(c => c.GrowLightId);
            modelBuilder.Entity<GrowLight>()
              .Property(c => c.GrowLightId)
              .ValueGeneratedOnAdd();
            modelBuilder.Entity<GrowLight>()
                .HasOne(c => c.Brand)
                .WithMany(c => c.GrowLights)
                .HasForeignKey(c => c.BrandId)
                .HasConstraintName("FK_GROWLIGHT_BRAND_BRANDID")
                .IsRequired();
            modelBuilder.Entity<GrowLight>()
               .HasOne(c => c.PowerSupply)
               .WithMany(c => c.GrowLights)
               .HasForeignKey(c => c.PowerSupplyId)
               .HasConstraintName("FK_GROWLIGHT_POWERSUPPLY_POWERSUPPLYID")
               .IsRequired();
            modelBuilder.Entity<GrowLight>()
               .HasOne(c => c.ChipModel)
               .WithMany(c => c.GrowLights)
               .HasForeignKey(c => c.ChipModelId)
               .HasConstraintName("FK_GROWLIGHT_CHIPMODEL_CHIPMODELID")
               .IsRequired();
            modelBuilder.Entity<GrowLight>()
               .HasOne(c => c.CoolingSystem)
               .WithMany(c => c.GrowLights)
               .HasForeignKey(c => c.CoolingSystemId)
               .HasConstraintName("FK_GROWLIGHT_COOLINGSYSTEM_COOLINGSYSTEMID")
               .IsRequired();
            modelBuilder.Entity<GrowLight>()
               .HasOne(c => c.Spectrum)
               .WithMany(c => c.GrowLights)
               .HasForeignKey(c => c.SpectrumId)
               .HasConstraintName("FK_GROWLIGHT_SPECTRUM_SPECTRUMID")
               .IsRequired();
            modelBuilder.Entity<GrowLight>()
                .Property<int>(c => c.Lifespan);
            modelBuilder.Entity<GrowLight>()
                .Property<int>(c => c.Quantity)
                .IsRequired();
            modelBuilder.Entity<GrowLight>()
                .Property(c => c.Price)
                .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<GrowLight>()
                .Property(c => c.Wattage)
                .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<GrowLight>()
                .Property<int>(c => c.WarrantyPeriod);
            modelBuilder.Entity<GrowLight>()
                .Property(c => c.CoverageArea)
                .HasPrecision(10, 2)
                .IsRequired();
            #endregion
            #region Table Logs
            modelBuilder.Entity<Log>()
                .HasKey(c => c.LogId);
            modelBuilder.Entity<Log>()
                .Property(c => c.LogId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Log>()
                .Property(c => c.Description)
                .HasColumnType("VARCHAR(MAX)");
            modelBuilder.Entity<Log>()
                .Property(a => a.CreateAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder.Entity<Log>()
                .HasOne(c => c.Seller)
                .WithMany(c => c.Logs)
                .HasForeignKey(c => c.SellerId)
                .HasConstraintName("FK_LOG_SELLER_SELLERID")
                .IsRequired();
            #endregion
            #region Table Nutrients
            modelBuilder.Entity<Nutrient>()
                .HasKey(c => c.NutrientId);
            modelBuilder.Entity<Nutrient>()
                .Property(c => c.NutrientId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Nutrient>()
                .HasOne(c => c.Brand)
                .WithMany(c => c.Nutrients)
                .HasForeignKey(c => c.BrandId)
                .HasConstraintName("FK_NUTRIENT_BRAND_BRANDID")
                .IsRequired();
            modelBuilder.Entity<Nutrient>()
                .HasOne(c => c.NutrientType)
                .WithMany(c => c.Nutrients)
                .HasForeignKey(c => c.NutrientTypeId)
                .HasConstraintName("FK_NUTRIENT_NUTRIENTTYPE_NUTRIENTTYPEID")
                .IsRequired();
            modelBuilder.Entity<Nutrient>()
                .Property<int>(c => c.Quantity)
                .IsRequired();
            modelBuilder.Entity<Nutrient>()
                .Property(c => c.Price)
                .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<Nutrient>()
                .Property<int>(c => c.VolumeMl)
                .IsRequired();
            modelBuilder.Entity<Nutrient>()
                .Property(c => c.Ingredients)
                .HasMaxLength(255);
            modelBuilder.Entity<Nutrient>()
                .Property(c => c.NpkRatio)
                .HasMaxLength(50);
            modelBuilder.Entity<Nutrient>()
                .Property<bool>(c => c.IsOrganic)
                .HasDefaultValue(false);
            modelBuilder.Entity<Nutrient>()
                .Property(c => c.Description)
                .HasColumnType("TEXT");
            modelBuilder.Entity<Nutrient>()
                .Property(c => c.StorageInstructions)
                .HasMaxLength(255);
            #endregion
            #region Table NutrientTypes
            modelBuilder.Entity<NutrientType>()
                .HasKey(c => c.NutrientTypeId);
            modelBuilder.Entity<NutrientType>()
                .Property(c => c.NutrientTypeId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<NutrientType>()
                .Property(c => c.NutrientName)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<NutrientType>()
                .Property(c => c.Description)
                .HasColumnType("NVARCHAR(MAX)");
            #endregion 
            #region Table Orders
            modelBuilder.Entity<Order>()
                .HasKey(c => c.OrderId);
            modelBuilder.Entity<Order>()
                .Property(c => c.OrderId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Order>()
                .HasOne(c => c.Seller)
                .WithMany(c => c.Orders)
                .HasForeignKey(c => c.SellerId)
                .HasConstraintName("FK_ORDER_SELLER_SELLERID")
                .IsRequired();
            modelBuilder.Entity<Order>()
                .HasOne(c => c.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(c => c.CustomerId)
                .HasConstraintName("FK_ORDER_CUSTOMER_CUSTOMERID")
                .IsRequired();

            //modelBuilder.Entity<Order>()
            //    .HasOne(c => c.ShippingMethod)
            //    .WithOne(c => c.Order)
            //    .HasForeignKey<ShippingMethod>(p => p.OrderId)
            //    .HasConstraintName("FK_ORDER_SHIPPINGMETHOD")
            //    .IsRequired();
            modelBuilder.Entity<Order>()
                .Property(c => c.OrderSatus)
                .HasConversion<string>()
                .IsRequired();
            modelBuilder.Entity<Order>()
                .Property(c => c.TotalAmount)
                .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<Order>()
                .Property(c => c.TrackingNumber)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Order>()
                .Property(c => c.ShippingFee)
                .HasPrecision(10, 2);
            modelBuilder.Entity<Order>()
                .Property(c => c.ShippingAddress)
                .HasColumnType("NVARCHAR(MAX)");
            modelBuilder.Entity<Order>()
                .Property(c => c.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder.Entity<Order>()
                .Property(c => c.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                 .IsRequired();


            #endregion
            #region Table OrderItems
            modelBuilder.Entity<OrderItem>()
                .HasKey(c => c.OrderItemId);
            modelBuilder.Entity<OrderItem>()
                .Property(c => c.OrderItemId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<OrderItem>()
                .HasOne(c => c.Oder)
                .WithMany(c => c.OrderItems)
                .HasForeignKey(c => c.OderId)
                .HasConstraintName("FK_ODERITEM_ODER")
                .IsRequired();
            modelBuilder.Entity<OrderItem>()
                .HasOne(c => c.Product)
                .WithMany(c => c.OderItems)
                .HasForeignKey(c => c.ProductId)
                .HasConstraintName("FK_ODERITEM_PRODUCT")
                .IsRequired();
            modelBuilder.Entity<OrderItem>()
                .Property<int>(c => c.Quantity);
            modelBuilder.Entity<OrderItem>()
                .Property(c => c.Price)
                .HasPrecision(10, 2);
            #endregion
            #region Table Payments
            modelBuilder.Entity<Payment>()
                .HasKey(c => c.PaymentId);
            modelBuilder.Entity<Payment>()
                .Property(c => c.PaymentId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Payment>()
                .HasOne(c => c.Order)
                .WithOne(c => c.Payment)
                .HasForeignKey<Payment>(c => c.OrderId)
                .HasConstraintName("FK_PAYMENT_ORDER_ORDERID")
                .IsRequired();
            modelBuilder.Entity<Payment>()
               .Property(c => c.Description)
               .HasColumnType("NVARCHAR(MAX)");
            modelBuilder.Entity<Payment>()
                .Property(a => a.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            #endregion
            #region Table PowerSupplys
            modelBuilder.Entity<PowerSupply>()
                .HasKey(c => c.PowerSupplyId);
            modelBuilder.Entity<PowerSupply>()
                .Property(c => c.PowerSupplyId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<PowerSupply>()
                .Property(c => c.Type)
                .HasConversion<string>()
                .IsRequired();
            modelBuilder.Entity<PowerSupply>()
                .Property<int>(c => c.Voltage)
                .IsRequired();
            #endregion
            #region Table Products
            modelBuilder.Entity<Product>()
                .HasKey(c => c.ProductId);
            modelBuilder.Entity<Product>()
                .Property(c => c.ProductId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Product>()
                .Property(c => c.ProductName)
                .HasMaxLength(255)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .HasOne(c => c.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(c => c.CategoryId)
                .HasConstraintName("FK_PRODUCT_CATEGORY_CATEGORYID")
                .IsRequired();
            modelBuilder.Entity<Product>()
               .Property<bool>(c => c.IsActive)
               .HasDefaultValue(true)
               .IsRequired();
            modelBuilder.Entity<Product>()
                .Property(c => c.ProductType)
                .HasConversion<string>()
                .IsRequired();
            modelBuilder.Entity<Product>()
                .HasOne(c => c.GrowTent)
                .WithOne(c => c.Product)
                .HasForeignKey<Product>(c => c.ProductTypeId)
                .HasConstraintName("FK_GROWTENT_PRODUCT_PRODUCTTYPEID")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .HasOne(c => c.GrowLight)
                .WithOne(c => c.Product)
                .HasForeignKey<Product>(c => c.ProductTypeId)
                .HasConstraintName("FK_GROWLIGHT_PRODUCT_PRODUCTTYPEID")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .HasOne(c => c.Seed)
                .WithOne(c => c.Product)
                .HasForeignKey<Product>(c => c.ProductTypeId)
                .HasConstraintName("FK_SEED_PRODUCT_PRODUCTTYPEID")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .HasOne(c => c.CarbonFilter)
                .WithOne(c => c.Product)
                .HasForeignKey<Product>(c => c.ProductTypeId)
                .HasConstraintName("FK_CARBONFILTER_PRODUCT_PRODUCTTYPEID")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .HasOne(c => c.Dehumidifier)
                .WithOne(c => c.Product)
                .HasForeignKey<Product>(c => c.ProductTypeId)
                .HasConstraintName("FK_DEHUMIDIFIER_PRODUCT_PRODUCTTYPEID")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .HasOne(c => c.Nutrient)
                .WithOne(c => c.Product)
                .HasForeignKey<Product>(c => c.ProductTypeId)
                .HasConstraintName("FK_NUTRIENT_PRODUCT_PRODUCTTYPEID")
                .OnDelete(DeleteBehavior.Restrict) //không cho xoá nếu còn ràng buộc
                .IsRequired();

            modelBuilder.Entity<Product>()
               .Property(a => a.CreatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP")
               .ValueGeneratedOnAdd()
               .IsRequired();
            modelBuilder.Entity<Product>()
               .Property(a => a.UpdatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP")
               .ValueGeneratedOnAdd()
               .IsRequired();
            #endregion
            #region Table ProductImages
            modelBuilder.Entity<ProductImage>()
                .HasKey(c => c.ProductImageId);
            modelBuilder.Entity<ProductImage>()
                .Property(c => c.ProductImageId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ProductImage>()
                .HasOne(c => c.Product)
                .WithMany(c => c.ProductImages)
                .HasForeignKey(c => c.ProductId)
                .HasConstraintName("FK_PRODUCTIMAGE_PRODUCT_PRODUCTID")
                .IsRequired();
            modelBuilder.Entity<ProductImage>()
                .Property<string>(c => c.ImageUrl)
                .IsRequired();
            modelBuilder.Entity<ProductImage>()
                .Property(c => c.IsMainImage)
                .HasDefaultValue(false);
            modelBuilder.Entity<ProductImage>()
                .Property(a => a.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder.Entity<ProductImage>()
                .Property(a => a.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            #endregion
            #region Table Promotions
            modelBuilder.Entity<Promotion>()
                .HasKey(c => c.PromotionId);
            modelBuilder.Entity<Promotion>()
                .Property(c => c.PromotionId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Promotion>()
                .Property(c => c.PromotionName)
                .HasColumnType("NVARCHAR(255)")
                .IsRequired();
            modelBuilder.Entity<Promotion>()
                .Property(c => c.Description)
                .HasColumnType("NVARCHAR(MAX)");
            modelBuilder.Entity<Promotion>()
                .Property(c => c.DiscountType)
                .HasConversion<string>()
                .IsRequired();
            modelBuilder.Entity<Promotion>()
                .Property(c => c.DiscountValue)
                .HasPrecision(12, 2)
                .IsRequired();
            modelBuilder.Entity<Promotion>()
                .Property(c => c.MinimumOrderValue)
                .HasPrecision(12, 2)
                .IsRequired();
            modelBuilder.Entity<Promotion>()
                .Property(c => c.MaximumDiscountValue)
                .HasPrecision(12, 2)
                .IsRequired();
            modelBuilder.Entity<Promotion>()
                .Property(c => c.MinimumQuantity)
                .IsRequired();
            modelBuilder.Entity<Promotion>()
              .Property(a => a.StartDate)
              .HasDefaultValueSql("CURRENT_TIMESTAMP")
              .IsRequired();
            modelBuilder.Entity<Promotion>()
              .Property(a => a.EndDate)
              .HasDefaultValueSql("CURRENT_TIMESTAMP")
              .IsRequired();
            modelBuilder.Entity<Promotion>()
               .Property(a => a.IsActive)
               .HasDefaultValue(true)
               .IsRequired();
            modelBuilder.Entity<Promotion>()
                .Property(a => a.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            modelBuilder.Entity<Promotion>()
                .Property(a => a.UpdateAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd()
                .IsRequired();
            #endregion
            #region Table PromotionCategories
            modelBuilder.Entity<PromotionCategory>()
                .HasKey(pc => new { pc.PromotionId, pc.CategoryId });
            modelBuilder.Entity<PromotionCategory>()
                .HasOne(c => c.Promotion)
                .WithMany(c => c.PromotionCategories)
                .HasForeignKey(c => c.PromotionId)
                .HasConstraintName("FK_PROMOTIONCATEGORY_PROMOTION_PROMOTIONID")
                .IsRequired();
            modelBuilder.Entity<PromotionCategory>()
                .HasOne(c => c.Category)
                .WithMany(c => c.PromotionCategories)
                .HasForeignKey(c => c.CategoryId)
                .HasConstraintName("FK_PROMOTIONCATEGORY_CATEGORY_CATEGORYID")
                .IsRequired();
            #endregion
            #region Table PromotionProducts
            modelBuilder.Entity<PromotionProduct>()
                .HasKey(pp => new { pp.PromotionId, pp.ProductId });
            modelBuilder.Entity<PromotionProduct>()
                .HasOne(c => c.Promotion)
                .WithMany(c => c.PromotionProducts)
                .HasForeignKey(c => c.PromotionId)
                .HasConstraintName("FK_PROMOTIONPRODUCT_PROMOTION_PROMOTIONID")
                .IsRequired();
            modelBuilder.Entity<PromotionProduct>()
                .HasOne(c => c.Product)
                .WithMany(c => c.PromotionProducts)
                .HasForeignKey(c => c.ProductId)
                .HasConstraintName("FK_PROMOTIONPRODUCT_PRODUCT_PRODUCTID")
                .IsRequired();
            #endregion
            #region  Table Reviews
            modelBuilder.Entity<Review>()
                .HasKey(c => c.ReviewId);
            modelBuilder.Entity<Review>()
                .Property(c => c.ReviewId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Review>()
                .HasOne(c => c.Customer)
                .WithMany(c => c.Reviews)
                .HasForeignKey(c => c.Customerid)
                .HasConstraintName("FK_REVIEW_CUSTOMER_CUSTOMERID")
                .IsRequired();
            modelBuilder.Entity<Review>()
                .HasOne(c => c.Product)
                .WithMany(c => c.Reviews)
                .HasForeignKey(c => c.ProductId)
                .HasConstraintName("FK_REVIEW_PRODUCT_PRODUCTID")
                .IsRequired();
            modelBuilder.Entity<Review>()
                .HasOne(c => c.Order)
                .WithMany(c => c.Reviews)
                .HasForeignKey(c => c.OrderId)
                .HasConstraintName("FK_REVIEW_ORDER_ORDERID")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            modelBuilder.Entity<Review>()
                .Property(c => c.Rating)
                .HasColumnType("int")
                .IsRequired();
            modelBuilder.Entity<Review>()
                .ToTable(tb => tb.HasCheckConstraint("CK_Review_Rating", "Rating BETWEEN 1 AND 5"));
            modelBuilder.Entity<Review>()
                .Property(c => c.Comments)
                .HasColumnType("NVARCHAR(MAX)");
            modelBuilder.Entity<Review>()
                .Property(c => c.ReviewTitle)
                .HasMaxLength(255);
            modelBuilder.Entity<Review>()
               .Property(c => c.CreatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP")
               .ValueGeneratedOnAdd()
               .IsRequired();
            #endregion
            #region Table Roles
            modelBuilder.Entity<Role>()
                .HasKey(c => c.RoleId);
            modelBuilder.Entity<Role>()
                .Property(c => c.RoleId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Role>()
                .Property(c => c.RoleName)
                .IsRequired();
            modelBuilder.Entity<Role>()
                .Property(c => c.Description)
                .HasColumnType("NVARCHAR(MAX)");
            #endregion
            #region Table Seeds
            modelBuilder.Entity<Seed>()
                .HasKey(c => c.SeedId);
            modelBuilder.Entity<Seed>()
                .Property(c => c.SeedId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Seed>()
                .Property(c => c.THCContent)
                .HasPrecision(5, 2)
                .IsRequired();
            modelBuilder.Entity<Seed>()
                .Property(c => c.CBDContent)
                 .HasPrecision(5, 2)
                .IsRequired();
            modelBuilder.Entity<Seed>()
                .Property(c => c.StrainType)
                .HasConversion<string>();
            modelBuilder.Entity<Seed>()
                .HasOne(c => c.Classification)
                .WithMany(c => c.Seeds)
                .HasForeignKey(c => c.ClassifyId)
                .HasConstraintName("FK_SEED_CLASSIFICATION_CLASSIFYID")
                .IsRequired();
            modelBuilder.Entity<Seed>()
                .Property(c => c.FloweringTimeDays)
                .HasColumnType("INT");
            modelBuilder.Entity<Seed>()
                .Property(c => c.Yield)
                .HasPrecision(10, 2);
            modelBuilder.Entity<Seed>()
                .Property(c => c.Difficulty)
                .HasConversion<string>()
                .IsRequired();
            modelBuilder.Entity<Seed>()
                .Property(c => c.Price)
                .HasPrecision(10, 2)
                .IsRequired();
            modelBuilder.Entity<Seed>()
                .Property(c => c.IndicaPercentage)
                .HasPrecision(5, 2)
                .IsRequired();
            modelBuilder.Entity<Seed>()
                .Property(c => c.SativaPercentage)
                .HasPrecision(5, 2)
                .IsRequired();
            modelBuilder.Entity<Seed>()
                .Property(c => c.TotalQuantity)
                .HasColumnType("INT");
            #endregion
            #region Table Sellers
            modelBuilder.Entity<Seller>(entity =>
            {
                entity.HasKey(c => c.SellerId);

                entity.Property(c => c.SellerId)
                       .ValueGeneratedOnAdd();
                entity.Property(c => c.Username)
                       .HasMaxLength(100)
                       .IsRequired();
                entity.HasIndex(c => c.Username).IsUnique().HasDatabaseName("IX_SEELER_USERNAME");
                entity.Property(c => c.HashPassword).HasMaxLength(255).IsRequired();
                entity.Property(c => c.PhoneNumber).HasColumnType("VARCHAR(20)");
                entity.Property(c => c.Email).HasColumnType("VARCHAR(150)");
                entity.HasIndex(C => C.Email).IsUnique().HasDatabaseName("IX_SEELER_EMAIL");
                entity.Property(c => c.Address).HasColumnType("TEXT");
                entity.Property(c => c.RoleId).IsRequired();
                entity.HasOne(c => c.Role).WithMany(c => c.Sellers).HasForeignKey(c => c.SellerId).HasConstraintName("FK_SELLER_ROLE_ROLEID").IsRequired();
                entity.Property(c => c.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP").ValueGeneratedOnAdd().IsRequired();
                entity.Property(c => c.UpdatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP").ValueGeneratedOnAdd();
                entity.Property(c => c.Satus).HasConversion<string>().IsRequired();
                entity.Property(c => c.Token).HasColumnType("TEXT");
                entity.Property(c => c.RefreshToken).HasColumnType("TEXT");
                entity.Property(c => c.RefreshToken).HasColumnType("TEXT");
                entity.Property(c => c.TokenExpiry).IsRequired();


            });


            #endregion
            #region Table ShippingMedthods
            modelBuilder.Entity<ShippingMethod>(entity =>
            {
                entity.HasKey(c => c.ShippingId);
                entity.Property(c => c.ShippingId).ValueGeneratedOnAdd();
                entity.Property(c => c.Name).HasMaxLength(150).IsRequired();
                entity.Property(c => c.Carrier).HasMaxLength(150).IsRequired();
                entity.Property(c => c.EstimatedDeliveryDate).HasColumnType("INT").IsRequired();
                entity.Property(c => c.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP").ValueGeneratedOnAdd();
                entity.HasOne(c => c.Order).WithOne(c => c.ShippingMethod).HasForeignKey<ShippingMethod>(c => c.OrderId).HasConstraintName("FK_SHIPPINGMETHOD_ORDER_ORDERID").IsRequired();
            });
            #endregion
            #region Table Spectrums
            modelBuilder.Entity<Spectrum>(entity =>
            {
                entity.HasKey(c => c.SpectrumId);
                entity.Property(c => c.SpectrumId).ValueGeneratedOnAdd();
                entity.Property(c => c.Type).HasConversion<string>().IsRequired();
                entity.Property(c => c.Description).HasColumnType("TEXT");
            });

            #endregion
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}