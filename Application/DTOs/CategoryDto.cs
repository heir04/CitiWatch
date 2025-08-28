using System.ComponentModel.DataAnnotations;

namespace CitiWatch.Application.DTOs
{
    public class CategoryCreateDto
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;
    }

    public class CategoryUpdateDto
    {
        [StringLength(100, MinimumLength = 2)]
        public string? Name { get; set; }
    }

    public class CategoryResponseDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
