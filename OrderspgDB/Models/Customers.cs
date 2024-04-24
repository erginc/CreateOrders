using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderspgDB.Models
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }

        public string CustomerName { get; set; } = null!;

        public string CustomerSurname { get; set; } = null!;

        public string CustomerEmail { get; set; } = null!;

        public long Mobile { get; set; }

        public string Address { get; set; } = null!;

        public ICollection<Orders> Orders { get; set; } = new List<Orders>(); // Navigation property

    }
}
