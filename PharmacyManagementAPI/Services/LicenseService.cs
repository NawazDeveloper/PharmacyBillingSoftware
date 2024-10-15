using PharmacyManagementAPI.Data.PharmacyManagementAPI.Data;

namespace PharmacyManagementAPI.Services
{
    public class LicenseService
    {
        private readonly ApplicationDbContext _context;

        public LicenseService(ApplicationDbContext context)
        {
            _context = context;
        }

        //public bool IsLicenseValid(string licenseKey)
        //{
        //    var license = _context.Licenses.FirstOrDefault(l => l.LicenseKey == licenseKey);
        //    if (license == null)
        //    {
        //        return false; // License doesn't exist or is inactive
        //    }

        //    //if (license.ExpiryDate < DateTime.Now)
        //    //{
        //    //    return false; // License has expired
        //    //}

        //    return true;
        //}

        //public bool IsFeatureAllowed(string licenseKey, string feature)
        //{
        //    var license = _context.Licenses.FirstOrDefault(l => l.LicenseKey == licenseKey);
        //    if (license == null)
        //    {
        //        return false;
        //    }

        //    // Check if the feature is included in the license's feature set
        //    var features = "";// license.Features.Split(',');
        //    return features.Contains(feature);
        //}
    }
}
