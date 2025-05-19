namespace KitDocFinder.Models
{
    /// <summary>
    /// Модель данных для сущности "Пользователь Telegram-bot"
    /// </summary>
    public class TelegramUser
    {
        /// <summary>
        /// Идентификатор сущности "Пользователь Telegram-bot"
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Личный идентификатор пользователя Telegram
        /// </summary>
        public long TelegramUserId { get; set; }
        /// <summary>
        /// Имя пользователя в Telegram
        /// </summary>
        public required string TelegramUserName { get; set; }
        /// <summary>
        /// Реальное имя пользователя
        /// </summary>
        public required string FirstName { get; set; }
        /// <summary>
        /// Реальное фамилия 
        /// </summary>
        public required string LastName { get; set; }
        /// <summary>
        /// Статус авторизации пользователя
        /// </summary>
        public bool IsAuthorized { get; set; }
        /// <summary>
        /// Дата Создания пользователя
        /// </summary>
        public DateTime CreateAt { get; set; }
        /// <summary>
        /// Время последней активности пользователя 
        /// </summary>
        public DateTime LastActivityAt { get; set; }
        /// <summary>
        /// Последняя команда пользователя
        /// </summary>
        public required string LastCommand { get; set; }
    }
}
