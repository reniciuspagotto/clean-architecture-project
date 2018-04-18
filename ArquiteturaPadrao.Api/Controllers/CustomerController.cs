﻿using Microsoft.AspNetCore.Mvc;
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
        public ResponseResult Create([FromBody] CreateCustomerCommand command)
        {
            var response = _handler.Handle(command);
            Commit();
            return new ResponseResult();
        }

        [HttpPut]
        public ResponseResult Edit(EditCustomerCommand command)
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