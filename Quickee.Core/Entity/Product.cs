using System.ComponentModel.DataAnnotations;
using Quickee.Core.Framework.BaseClass;

namespace Quickee.Core.Entity
{
    public class Product:BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }

        [Range(1, 1000, ErrorMessage ="Stock count must be between 1 - 1000")]
        public int StockCount { get; set; } = 1;

        // navigation properties
        public ProductCategory Category { get; set; }
    }
}