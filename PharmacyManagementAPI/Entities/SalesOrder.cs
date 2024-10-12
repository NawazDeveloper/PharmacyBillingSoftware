namespace PharmacyManagementAPI.Entities
{
    public class SalesOrder
    {
        public int SalesOrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal FinalAmount { get; set; }

        // Relationships
        public Customer Customer { get; set; }
        public List<SalesOrderItem> SalesOrderItems { get; set; } = new List<SalesOrderItem>();
    }
}
