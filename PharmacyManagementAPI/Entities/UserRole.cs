using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementAPI.Entities
{
    public class UserRole
    {
        [Key]
        public int UserRoleID { get; set; }
        public string RoleName { get; set; }
    }
}
