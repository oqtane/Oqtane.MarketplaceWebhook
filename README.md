# Oqtane.MarketplaceWebhook

An example module which consumes a webhook from the Oqtane Marketplace (https://www.oqtane.net). The Oqtane Marketplace allows you to specify a Webhook Url so that you can receive an instant notification when orders are placed for your products:

![image](https://github.com/oqtane/Oqtane.MarketplaceWebhook/assets/4840590/c58aa612-cabd-4cb1-971b-b3295cbbf322)

Using this module as a reference, your Webhook Url would be: https://yourdomain.com/api/MarketplaceWebhook

This module receives a POST request containing the following information:

```
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
```

You can adapt the code from this module to utilize the information provided to update your own backend systems.



