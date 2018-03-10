using Microsoft.AspNetCore.Mvc;

namespace NutriAppServer.Api.Controllers
{
    [Route("api/status")]
    public class StatusController : Controller
    {
        [HttpGet]
        public bool IsActive()
        {
            return true;
        }
    }
}