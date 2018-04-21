using Microsoft.AspNetCore.Mvc;
using ArquiteturaPadrao.Shared.Response;
using ArquiteturaPadrao.Domain.Handlers;
using ArquiteturaPadrao.Infra.UnitOfWork;
using ArquiteturaPadrao.Domain.Command.Customer;

namespace ArquiteturaPadrao.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/customers")]
    public class CustomerController : BaseController
    {
        private readonly CustomerHandler _handler;

        public CustomerController(CustomerHandler handler, IUnitOfWork uow) : base(uow)
        {
            _handler = handler;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateCustomerCommand command)
        {
            return GetResponse(() => _handler.Handle(command));
        }

        [HttpPut]
        public IActionResult Edit(EditCustomerCommand command)
        {
            return GetResponse(() => _handler.Handle(command));
        }

        [HttpGet]
        public ResponseResult Get()
        {
            return new ResponseResult();
        }
    }
}