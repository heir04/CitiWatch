using CitiWatch.Domain.Enums;

namespace CitiWatch.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public UserRole Role { get; set; } 
        public string? PasswordHash { get; set; }
    }
}