using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementAPI.Entities
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
