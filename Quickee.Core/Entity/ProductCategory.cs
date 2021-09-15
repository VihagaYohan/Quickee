using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Quickee.Core.Framework.BaseClass;

namespace Quickee.Core.Entity
{
    public class ProductCategory:BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}