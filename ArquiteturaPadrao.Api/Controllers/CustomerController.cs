using Microsoft.AspNetCore.Mvc;
using ArquiteturaPadrao.Shared.Response;
using ArquiteturaPadrao.Domain.Command;
using ArquiteturaPadrao.Domain.Handlers;
using ArquiteturaPadrao.Infra.UnitOfWork;

namespace ArquiteturaPadrao.Api.Controllers
{
    [Route("api/customers")]
    public class CustomerController : BaseController
    {
        private readonly CustomerHandler _handler;

        public CustomerController(CustomerHandler handler, IUnitOfWork uow) : base(uow)
        {
            _handler = handler;
        }

        [HttpPost]
        public ResponseResult Create([FromBody] CreateCustomerCommand command)
        {
            var response = _handler.Handle(command);
            Commit();
            return new ResponseResult();
        }

        [HttpPut]
        public ResponseResult Edit(CreateCustomerCommand command)
        {
            var response = _handler.Handle(command);
            Commit();
            return new ResponseResult();
        }

        [HttpGet]
        public ResponseResult Get()
        {
            return new ResponseResult();
        }
    }
}