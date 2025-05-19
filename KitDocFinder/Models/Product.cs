namespace KitDocFinder.Models
{
    /// <summary>
    /// Модель данных для сущности "Продукт"
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Идентификатор сущности "Продукта"
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название продукта
        /// </summary>
        public required string Title { get; set; }
        /// <summary>
        /// Внешний ключ для сущности "Документация"
        /// </summary>
        public int DocumentationId { get; set; }
    }
}
