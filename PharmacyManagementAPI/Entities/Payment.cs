using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementAPI.Entities
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public int SalesOrderID { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; }  // E.g., Cash, Card, UPI
        public DateTime PaymentDate { get; set; }

        // Relationships
        public SalesOrder SalesOrder { get; set; }
    }
}
