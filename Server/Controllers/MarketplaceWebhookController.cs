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
                _logger.Log(LogLevel.Information, this, LogFunction.Create, "Webhook Added {Webhook}", Webhook);
            }
            else
            {
                _logger.Log(LogLevel.Error, this, LogFunction.Security, "Unauthorized Webhook Post Attempt {Webhook}", Webhook);
                HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            }
        }
    }
}
