namespace PharmacyManagementAPI.Entities
{
    public class StockMovement
    {
        public int StockMovementID { get; set; }
        public int ProductID { get; set; }
        public int QuantityChanged { get; set; }
        public string MovementType { get; set; }  // In or Out
        public DateTime MovementDate { get; set; }

        // Relationships
        public Product Product { get; set; }
    }
}
