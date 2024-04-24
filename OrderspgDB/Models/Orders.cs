using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderspgDB.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public int CustomerID { get; set; }
        public double Price { get; set; }

        public int Amount { get; set; }

        public Customers Customer { get; set; } = null!;

        public Products Product { get; set; } = null!;
    }
}
