namespace KitDocFinder.Models
{
    /// <summary>
    /// Модель данных для сущности "Документация"
    /// </summary>
    public class Documentation
    {
        /// <summary>
        /// Идентификатор сущности "Документации"
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Номер документации
        /// </summary>
        public required string Number { get; set; }
        /// <summary>
        /// Название документации
        /// </summary>
        public required string Title { get; set; }
    }
}
