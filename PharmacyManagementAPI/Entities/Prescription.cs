using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementAPI.Entities
{
    public class Prescription
    {
        [Key]
        public int PrescriptionID { get; set; }
        public int CustomerID { get; set; }
        public string DoctorName { get; set; }
        public string PrescriptionDetails { get; set; }
        public DateTime PrescriptionDate { get; set; }

        // Relationships
        public Customer Customer { get; set; }
    }


}
