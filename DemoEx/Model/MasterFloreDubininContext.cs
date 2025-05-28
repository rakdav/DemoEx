using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DemoEx.Model;

public partial class MasterFloreDubininContext : DbContext
{
    public MasterFloreDubininContext()
    {
        Database.EnsureCreated();
    }

    public MasterFloreDubininContext(DbContextOptions<MasterFloreDubininContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public virtual DbSet<Bid> Bids { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MaterialHistory> MaterialHistories { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<PartnerHistory> PartnerHistories { get; set; }

    public virtual DbSet<Place> Places { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Productmaterial> Productmaterials { get; set; }

    public virtual DbSet<Suplier> Supliers { get; set; }

    public virtual DbSet<TypeProduct> TypeProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=TeacherPC;Initial Catalog=MasterFloreDubinin;User ID=user5;Password=1234;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bid>(entity =>
        {
            entity.HasKey(e => e.IdBid);

            entity.ToTable("Bid");

            entity.HasIndex(e => e.IdEmployee, "IX_Bid_idEmployee");

            entity.Property(e => e.IdBid)
                .ValueGeneratedNever()
                .HasColumnName("idBid");
            entity.Property(e => e.IdEmployee).HasColumnName("idEmployee");
            entity.Property(e => e.IdPartner).HasColumnName("idPartner");

            entity.HasOne(d => d.IdEmployeeNavigation).WithMany(p => p.Bids)
                .HasForeignKey(d => d.IdEmployee)
                .HasConstraintName("FK_Bid_Employee");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.IdEmployee).HasName("PK_Material");

            entity.ToTable("Employee");

            entity.Property(e => e.IdEmployee).HasColumnName("idEmployee");
            entity.Property(e => e.Bank)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("bank");
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.Health)
                .HasMaxLength(50)
                .HasColumnName("health");
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.Married).HasColumnName("married");
            entity.Property(e => e.MidleName).HasMaxLength(20);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.IdMaterial).HasName("PK_MaterialTable");

            entity.ToTable("Material");

            entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.CountBox).HasColumnName("countBox");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Foto)
                .HasMaxLength(50)
                .HasColumnName("foto");
            entity.Property(e => e.IdSuppleir).HasColumnName("id_suppleir");
            entity.Property(e => e.MinCount).HasColumnName("min_count");
            entity.Property(e => e.NameMaterial)
                .HasMaxLength(50)
                .HasColumnName("name_material");
            entity.Property(e => e.Price)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("price");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<MaterialHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MaterialHistory");

            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");
            entity.Property(e => e.IdMaterialHistory).HasColumnName("idMaterialHistory");
            entity.Property(e => e.Operation)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("operation");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.NameCompany).HasName("PK_Partner_1");

            entity.ToTable("Partner");

            entity.Property(e => e.NameCompany)
                .HasMaxLength(100)
                .HasColumnName("name_company");
            entity.Property(e => e.Director).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("email");
            entity.Property(e => e.Inn)
                .HasMaxLength(20)
                .HasColumnName("INN");
            entity.Property(e => e.Logo)
                .HasMaxLength(100)
                .HasColumnName("logo");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Reiting).HasColumnName("reiting");
            entity.Property(e => e.Type)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("type");
            entity.Property(e => e.UrAddress)
                .HasMaxLength(100)
                .HasColumnName("ur_address");
        });

        modelBuilder.Entity<PartnerHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PartnerHistory");

            entity.HasIndex(e => e.NameCompany, "IX_PartnerHistory_name_company");

            entity.HasIndex(e => e.NameProduct, "IX_PartnerHistory_name_product");

            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.NameCompany)
                .HasMaxLength(100)
                .HasColumnName("name_company");
            entity.Property(e => e.NameProduct)
                .HasMaxLength(100)
                .HasColumnName("name_product");

            entity.HasOne(d => d.NameCompanyNavigation).WithMany()
                .HasForeignKey(d => d.NameCompany)
                .HasConstraintName("FK_PartnerHistory_Partner");

            entity.HasOne(d => d.NameProductNavigation).WithMany()
                .HasForeignKey(d => d.NameProduct)
                .HasConstraintName("FK_PartnerHistory_Product1");
        });

        modelBuilder.Entity<Place>(entity =>
        {
            entity.HasKey(e => e.IdPlace);

            entity.ToTable("Place");

            entity.HasIndex(e => e.NameCompany, "IX_Place_name_company");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("address");
            entity.Property(e => e.NameCompany)
                .HasMaxLength(100)
                .HasColumnName("name_company");

            entity.HasOne(d => d.NameCompanyNavigation).WithMany(p => p.Places)
                .HasForeignKey(d => d.NameCompany)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Place_Partner1");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.NameProduct).HasName("PK_Product_1");

            entity.ToTable("Product");

            entity.HasIndex(e => e.Type, "IX_Product_type");

            entity.Property(e => e.NameProduct)
                .HasMaxLength(100)
                .HasColumnName("name__product");
            entity.Property(e => e.Articul).HasColumnName("articul");
            entity.Property(e => e.CehNumber).HasColumnName("ceh_number");
            entity.Property(e => e.Cost)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("cost");
            entity.Property(e => e.CountEmp).HasColumnName("count_emp");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Foto)
                .HasMaxLength(100)
                .HasColumnName("foto");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Length).HasColumnName("length");
            entity.Property(e => e.MinPrice)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("min_price");
            entity.Property(e => e.Skan)
                .HasMaxLength(100)
                .HasColumnName("skan");
            entity.Property(e => e.Standart).HasColumnName("standart");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight");
            entity.Property(e => e.WeightWithoutBox)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight_without_box");
            entity.Property(e => e.Width).HasColumnName("width");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Type_product");
        });

        modelBuilder.Entity<Productmaterial>(entity =>
        {
            entity.ToTable("Productmaterial");

            entity.HasIndex(e => e.IdMaterial, "IX_Productmaterial_idMaterial");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.Productmaterials)
                .HasForeignKey(d => d.IdMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productmaterial_Material");
        });

        modelBuilder.Entity<Suplier>(entity =>
        {
            entity.HasKey(e => e.IdSuplier);

            entity.ToTable("Suplier");

            entity.Property(e => e.Inn)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasColumnName("INN");
            entity.Property(e => e.NameSupplier)
                .HasMaxLength(50)
                .HasColumnName("name_supplier");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("type");
        });

        modelBuilder.Entity<TypeProduct>(entity =>
        {
            entity.HasKey(e => e.TypeName);

            entity.ToTable("Type_product");

            entity.Property(e => e.TypeName)
                .HasMaxLength(50)
                .HasColumnName("Type_name");
            entity.Property(e => e.Koef).HasColumnName("koef");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
