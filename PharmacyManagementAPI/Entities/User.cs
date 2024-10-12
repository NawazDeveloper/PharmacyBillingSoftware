namespace PharmacyManagementAPI.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public string LicenseKey { get; set; }
        public bool IsActive { get; set; }
        public int UserRoleID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        // Relationships
        public UserRole UserRole { get; set; }
        
    }
}
