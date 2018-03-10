using Microsoft.AspNetCore.Mvc;
using NutriAppServer.Domain.Command;
using NutriAppServer.Shared.Response;

namespace NutriAppServer.Api.Controllers
{
    [Route("api/customers")]
    public class CustomerController : Controller
    {
        public CustomerController()
        {

        }

        [HttpPost]
        public ResponseResult Create(CreateCustomerCommand command)
        {
            return new ResponseResult();
        }

        [HttpPut]
        public ResponseResult Edit(CreateCustomerCommand command)
        {
            return new ResponseResult();
        }

        [HttpGet]
        public ResponseResult Get()
        {
            return new ResponseResult();
        }
    }
}