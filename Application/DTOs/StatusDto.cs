using System.ComponentModel.DataAnnotations;

namespace CitiWatch.Application.DTOs
{
    public class StatusCreateDto
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;
    }

    public class StatusUpdateDto
    {
        [StringLength(100, MinimumLength = 2)]
        public string? Name { get; set; }
    }

    public class StatusResponseDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
