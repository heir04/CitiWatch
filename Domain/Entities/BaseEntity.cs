using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecurityDriven;

namespace CitiWatch.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = FastGuid.NewGuid();
        public Guid CreatedBy { get; set; }
        public DateTime Createdon { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; }
        public Guid IsDeletedBy { get; set; }
        public DateTime IsDeletedOn { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}