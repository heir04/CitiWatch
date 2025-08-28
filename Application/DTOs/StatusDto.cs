using System.ComponentModel.DataAnnotations;

namespace CitiWatch.Application.DTOs
{
    public class ComplaintStatusUpdateDto
    {
        public Guid Id { get; set; }
    }

    public class StatusResponseDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
