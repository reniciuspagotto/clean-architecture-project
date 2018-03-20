using Microsoft.AspNetCore.Mvc;
using ArquiteturaPadrao.Shared.Response;
using ArquiteturaPadrao.Domain.Command;
using ArquiteturaPadrao.Domain.Handlers;

namespace ArquiteturaPadrao.Api.Controllers
{
    [Route("api/customers")]
    public class CustomerController : Controller
    {
        private readonly CustomerHandler _handler;

        public CustomerController(CustomerHandler handler)
        {
            _handler = handler;
        }

        [HttpPost]
        public ResponseResult Create(CreateCustomerCommand command)
        {
            var response = _handler.Handle(command);
            return new ResponseResult();
        }

        [HttpPut]
        public ResponseResult Edit(CreateCustomerCommand command)
        {
            var response = _handler.Handle(command);
            return new ResponseResult();
        }

        [HttpGet]
        public ResponseResult Get()
        {
            return new ResponseResult();
        }
    }
}