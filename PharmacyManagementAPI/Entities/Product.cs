using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementAPI.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
            public string ProductName { get; set; }
            public string ProductCode { get; set; }  // Barcode or unique code for the product
            public int CategoryID { get; set; }
            public decimal PurchasePrice { get; set; }
            public decimal SellingPrice { get; set; }
            public int QuantityInStock { get; set; }
            public int LowStockThreshold { get; set; }
            public DateTime ExpiryDate { get; set; }
            public DateTime ManufactureDate { get; set; }
            public string BatchNumber { get; set; }
            public string StorageLocation { get; set; }
            public bool IsPrescriptionRequired { get; set; }  // If it's a prescription drug
            public string SupplierName { get; set; }
            public string SupplierContact { get; set; }

            // Relationships
            public Category Category { get; set; }
            public Supplier Supplier { get; set; }

    }
}
