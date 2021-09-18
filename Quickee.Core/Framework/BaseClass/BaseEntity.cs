using System;

namespace Quickee.Core.Framework.BaseClass
{
    public class BaseEntity
    {
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastModified { get; set; }
    }
}