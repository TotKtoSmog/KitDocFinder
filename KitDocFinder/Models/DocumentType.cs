namespace KitDocFinder.Models
{
    /// <summary>
    /// Модель данных для сущности "Типа документа"
    /// </summary>
    public class DocumentType
    {
        /// <summary>
        /// Идентификатор сущности "Тип документа"
        /// </summary>
        public int Id {  get; set; }
        /// <summary>
        /// Название типа документа
        /// </summary>
        public required string Title { get; set; }
    }
}
