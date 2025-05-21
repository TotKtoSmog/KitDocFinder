using KitDocFinder.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;


namespace KitDocFinder.Data
{
    /// <summary>
    /// Контекст для работы с базой данных
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        private ApplicationDbContext() => Database.EnsureCreated();

        /// <summary>
        /// Конструктор для создания контекста
        /// </summary>
        /// <param name="options">параметры</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) { }
        /// <summary>
        /// Дата-сет для работы с документами
        /// </summary>
        public DbSet<Document> Documents { get; set; }
        /// <summary>
        /// Дата-сет для работы с документацией
        /// </summary>
        public DbSet<Documentation> Documentations { get; set; }
        /// <summary>
        /// Дата-сет для работы с типом документации
        /// </summary>
        public DbSet<DocumentType> DocumentTypes { get; set; }
        /// <summary>
        /// Дата-сет для работы с товаром
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// Дата-сет для работы с пользователями
        /// </summary>
        public DbSet<TelegramUser> TelegramUsers { get; set; }
        /// <summary>
        /// Настройка моделей
        /// </summary>
        /// <param name="modelBuilder">Сборщик</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("document");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("document_id");
                entity.Property(e => e.DocumentationId).HasColumnName("documentation_id");
                entity.Property(e => e.Title).HasColumnName("title");
                entity.Property(e => e.Version).HasColumnName("version");
                entity.Property(e => e.Platform).HasColumnName("platform");
                entity.Property(e => e.Link).HasColumnName("link");
                entity.Property(e => e.CreateAt).HasColumnName("created_at");
                entity.Property(e => e.DocumentationId).HasColumnName("document_type_id");
            });

            modelBuilder.Entity<Documentation>(entity =>
            {
                entity.ToTable("documentation");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("documentation_id");
                entity.Property(e => e.Number).HasColumnName("number");
                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.ToTable("document_type");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("document_type_id");
                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("product_id");
                entity.Property(e => e.Title).HasColumnName("title");
                entity.Property(e => e.DocumentationId).HasColumnName("documentation_id");
            });

            modelBuilder.Entity<TelegramUser>(entity =>
            {
                entity.ToTable("telegram_user");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.TelegramUserId).HasColumnName("telegram_user_id");
                entity.Property(e => e.TelegramUserName).HasColumnName("telegram_user_name");
                entity.Property(e => e.FirstName).HasColumnName("first_name");
                entity.Property(e => e.LastName).HasColumnName("last_name");
                entity.Property(e => e.IsAuthorized).HasColumnName("is_authorized");
                entity.Property(e => e.CreateAt).HasColumnName("created_at");
                entity.Property(e => e.LastActivityAt).HasColumnName("last_activity_at");
                entity.Property(e => e.LastCommand).HasColumnName("last_command");
            });

            modelBuilder.Entity<Document>()
                .HasOne<Documentation>()
                .WithMany()
                .HasForeignKey(d => d.DocumentationId);

            modelBuilder.Entity<Document>()
                .HasOne<DocumentType>()
                .WithMany()
                .HasForeignKey(d => d.DocumentTypeId);

            modelBuilder.Entity<Product>()
                .HasOne<Documentation>()
                .WithMany()
                .HasForeignKey(d => d.DocumentationId);
        }


    }
}
