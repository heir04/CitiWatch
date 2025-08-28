using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiWatch.Domain.Entities
{
    public class Complaint : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Guid StatusId { get; set; }
        public Status? Status { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? MediaUrl { get; set; }
    }
}