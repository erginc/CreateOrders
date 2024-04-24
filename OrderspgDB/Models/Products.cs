using System.ComponentModel.DataAnnotations;

namespace OrderspgDB.Models
{
    public class Products
    {

        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; } = string.Empty;

        public double ProductCost { get; set; }

        public ICollection<Orders> Orders { get; set; } = new List<Orders>(); // Navigation property
    }
}
