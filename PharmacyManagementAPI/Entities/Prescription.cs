namespace PharmacyManagementAPI.Entities
{
    public class Prescription
    {

        public int PrescriptionID { get; set; }
        public int CustomerID { get; set; }
        public string DoctorName { get; set; }
        public string PrescriptionDetails { get; set; }
        public DateTime PrescriptionDate { get; set; }

        // Relationships
        public Customer Customer { get; set; }
    }


}
