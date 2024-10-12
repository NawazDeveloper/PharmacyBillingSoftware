namespace PharmacyManagementAPI.Entities
{
    public class Licence
    {
        public int LicenseID { get; set; }
        public string LicenseKey { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
    }
}
