using CitiWatch.Domain.Enums;

namespace CitiWatch.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
        public string? PasswordHash { get; set; }
    }
}