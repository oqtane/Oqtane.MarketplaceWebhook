using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Oqtane.Shared;
using Oqtane.Enums;
using Oqtane.Infrastructure;
using Oqtane.Controllers;
using System.Net;

namespace Oqtane.MarketplaceWebhook.Controllers
{
    [Route(ControllerRoutes.ApiRoute)]
    public class MarketplaceWebhookController : ModuleControllerBase
    {
        // this is your account id assigned by Stripe
        private readonly string accountId = "";

        public MarketplaceWebhookController(ILogManager logger, IHttpContextAccessor accessor) : base(logger, accessor) 
        {
            
        }

        // POST api/<controller>
        [IgnoreAntiforgeryToken]
        [HttpPost]
        public void Post([FromBody] Models.Webhook Webhook)
        {
            if (ModelState.IsValid)
            {
                // validate account id
                if (Webhook.AccountId == accountId)
                {

                    _logger.Log(LogLevel.Information, this, LogFunction.Create, "Webhook Added {Webhook}", Webhook);
                }
                else
                {
                    _logger.Log(LogLevel.Error, this, LogFunction.Security, "Unauthorized Webhook Post Attempt {Webhook}", Webhook);
                    HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                }
            }
            else
            {
                _logger.Log(LogLevel.Error, this, LogFunction.Security, "Unauthorized Webhook Post Attempt {Webhook}", Webhook);
                HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            }
        }
    }
}
