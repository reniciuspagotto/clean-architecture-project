using ArquiteturaPadrao.Shared.Response;
using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaPadrao.Api.Controllers
{
    [Route("api/status")]
    public class StatusController : Controller
    {
        [HttpGet]
        public ResponseResult IsActive()
        {
            var data = new ResponseResult();
            data.Success = true;
            data.Message.Add("A aplicação está online");

            return data;
        }
    }
}