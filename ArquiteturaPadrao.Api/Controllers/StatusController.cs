using ArquiteturaPadrao.Domain.Command;
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
            data.Message.Add("A aplicação está ativa");
            data.Message.Add("Operação concluída com sucesso");
            data.Message.Add("Resposta comprimida com sucesso");
            data.Message.Add("Requisição feita na rota api/isactive");
            data.Data = new CreateCustomerCommand();

            return data;
        }
    }
}