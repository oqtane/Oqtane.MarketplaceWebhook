using System;

namespace Oqtane.MarketplaceWebhook.Models
{
    public class Webhook
    {
        public int OrderId { get; set; }
        public string AccountId { get; set; }
        public string PackageId { get; set; }
        public int LicenseId { get; set; }
        public string LicenseName { get; set; }
        public string InstallationId { get; set; }
        public string Email { get; set; }
        public string LicenseKey { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Custom { get; set; }
    }

}
