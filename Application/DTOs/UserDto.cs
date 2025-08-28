using System.ComponentModel.DataAnnotations;
using CitiWatch.Domain.Enums;

namespace CitiWatch.Application.DTOs
{
    public class UserCreateDto
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;

        public UserRole Role { get; set; } = UserRole.User;
    }

    public class UserUpdateDto
    {
        [StringLength(100, MinimumLength = 2)]
        public string? FullName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public UserRole? Role { get; set; }
    }

    public class UserResponseDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public UserRole Role { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }

    public class LoginDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
