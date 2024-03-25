using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Assignment_3.Data;

public partial class WebTechnologiesContext : DbContext
{
    public WebTechnologiesContext()
    {
    }

    public WebTechnologiesContext(DbContextOptions<WebTechnologiesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS19;Database=web_technologies;Integrated Security=True;Connect Timeout=30;Packet Size=4096;MultipleActiveResultSets=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.CartId).HasName("PK__cart__2EF52A275B686F35");

            entity.ToTable("cart");

            entity.Property(e => e.CartId).HasColumnName("cart_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantities).HasColumnName("quantities");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK__comments__E795768732D8246D");

            entity.ToTable("comments");

            entity.Property(e => e.CommentId).HasColumnName("comment_id");
            entity.Property(e => e.CommentText)
                .HasMaxLength(255)
                .HasColumnName("comment_text");
            entity.Property(e => e.Images)
                .HasMaxLength(255)
                .HasColumnName("images");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__orders__46596229A18EF9B5");

            entity.ToTable("orders");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.PaymentMethod).HasColumnName("payment_method");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.ShippingAddress).HasColumnName("shipping_address");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TotalCost).HasColumnName("total_cost");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__product__47027DF5178BB08A");

            entity.ToTable("product");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Pricing).HasColumnName("pricing");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .HasColumnName("product_name");
            entity.Property(e => e.ShippingCost).HasColumnName("shipping_cost");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__user__B9BE370F5A9CFF49");

            entity.ToTable("user");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.PurchaseHistory)
                .HasMaxLength(255)
                .HasColumnName("purchase_history");
            entity.Property(e => e.ShippingAddress)
                .HasMaxLength(255)
                .HasColumnName("shipping_address");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
