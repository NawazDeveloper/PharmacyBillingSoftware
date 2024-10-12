namespace PharmacyManagementAPI.Entities
{
    public class SalesOrderItem
    {
        public int SalesOrderItemID { get; set; }
        public int SalesOrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }

        // Relationships
        public SalesOrder SalesOrder { get; set; }
        public Product Product { get; set; }
    }
}
