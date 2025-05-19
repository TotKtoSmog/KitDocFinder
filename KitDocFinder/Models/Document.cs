namespace KitDocFinder.Models
{
    /// <summary>
    /// Модель данных для сущности "Документ"
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Идентификатор сущности "Документ"
        /// </summary>
        public int Id {  get; set; }
        /// <summary>
        /// Внешний ключ для сущности "Документация"
        /// </summary>
        public int DocumentationId { get; set; }
        /// <summary>
        /// Название документа
        /// </summary>
        public required string Title {  get; set; }
        /// <summary>
        /// Версия документа
        /// </summary>
        public required string Version { get; set; }
        /// <summary>
        /// Целевая платформа
        /// </summary>
        public required string Platform { get; set; }
        /// <summary>
        /// Ссылка на документ
        /// </summary>
        public required string Link { get; set; }
        /// <summary>
        /// Дата создания документа
        /// </summary>
        public required DateTime CreateAt { get; set; }
        /// <summary>
        /// Внешний ключ для сущности "Тип документа"
        /// </summary>
        public int DocumentTypeId { get; set; }
    }
}
