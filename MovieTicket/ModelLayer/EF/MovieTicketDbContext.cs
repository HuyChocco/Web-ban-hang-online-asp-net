namespace ModelLayer.EF
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class MovieTicketDbContext : DbContext
	{
		public MovieTicketDbContext()
			: base("name=MovieTicketDbContext")
		{
		}

		public virtual DbSet<About> Abouts { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Contact> Contacts { get; set; }
		public virtual DbSet<Content> Contents { get; set; }
		public virtual DbSet<ContentTag> ContentTags { get; set; }
		public virtual DbSet<Feedback> Feedbacks { get; set; }
		public virtual DbSet<Footer> Footers { get; set; }
		public virtual DbSet<Menu> Menus { get; set; }
		public virtual DbSet<MenuType> MenuTypes { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<OrderDetail> OrderDetails { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<ProductCategory> ProductCategories { get; set; }
		public virtual DbSet<Slide> Slides { get; set; }
		public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
		public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
		public virtual DbSet<Tag> Tags { get; set; }
		public virtual DbSet<User> Users { get; set; }


		public virtual DbSet<Role> Roles { set; get; }
		public virtual DbSet<Credential> Credentials { set; get; }

		public virtual DbSet<UserGroup> UserGroups { set; get; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<About>()
				.Property(e => e.MetaTitle)
				.IsUnicode(false);

			modelBuilder.Entity<About>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<About>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Category>()
				.Property(e => e.MetaTitle)
				.IsFixedLength();

			modelBuilder.Entity<Category>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Category>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Content>()
				.Property(e => e.MetaTitle)
				.IsUnicode(false);

			modelBuilder.Entity<Content>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Content>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<ContentTag>()
				.Property(e => e.TagID)
				.IsUnicode(false);

			modelBuilder.Entity<Footer>()
				.Property(e => e.ID)
				.IsFixedLength();

			modelBuilder.Entity<Product>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<Product>()
				.Property(e => e.MetaTitle)
				.IsUnicode(false);

			modelBuilder.Entity<Product>()
				.Property(e => e.Price)
				.HasPrecision(18, 0);

			modelBuilder.Entity<Product>()
				.Property(e => e.PromotionPrice)
				.HasPrecision(18, 0);

			modelBuilder.Entity<Product>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Product>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<ProductCategory>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<ProductCategory>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Slide>()
				.Property(e => e.Create)
				.IsFixedLength();

			modelBuilder.Entity<Slide>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<Slide>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);

			modelBuilder.Entity<SystemConfig>()
				.Property(e => e.ID)
				.IsUnicode(false);

			modelBuilder.Entity<Tag>()
				.Property(e => e.ID)
				.IsUnicode(false);

			modelBuilder.Entity<Tag>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.CreatedBy)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.ModifiedBy)
				.IsUnicode(false);
		}

		
	}
}
