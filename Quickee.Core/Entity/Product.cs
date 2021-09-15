using System.ComponentModel.DataAnnotations;
using Quickee.Core.Framework.BaseClass;

namespace Quickee.Core.Entity
{
    public class Product:BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public ProductCategory CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public int StockCount { get; set; } = 0;
    }
}