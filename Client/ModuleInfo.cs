using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.MarketplaceWebhook
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Marketplace Webhook",
            Version = "1.0.0",
            Description = "Marketplace Webhook",
            Owner = "Oqtane Labs Inc",
            Contact = "Oqtane Labs Inc",
            Url = "https://www.oqtane.net",
            License = "Copyright 2023-2024 by Oqtane Labs Inc. All Rights Reserved.",
            PackageName = "Oqtane.MarketplaceWebhook",
            Categories = ""
        };
    }
}
