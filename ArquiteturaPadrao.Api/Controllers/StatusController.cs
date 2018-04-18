using ArquiteturaPadrao.Shared.Response;
using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaPadrao.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/status")]
    public class StatusController : Controller
    {
        [HttpGet]
        public ResponseResult IsActive()
        {
            var data = new ResponseResult();
            data.Success = true;
            data.Message.Add("A aplicação está online");
            data.Message.Add("Versão 1.0");

            return data;
        }
    }
}