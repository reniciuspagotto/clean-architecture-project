using ArquiteturaPadrao.Infra.UnitOfWork;
using ArquiteturaPadrao.Shared.Response;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ArquiteturaPadrao.Api.Controllers
{
    public class BaseController : Controller
    {
        private readonly IUnitOfWork _uow;

        public BaseController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        protected IActionResult GetResponse<T>(Func<T> action)
        {
            try
            {
                var dataReturn = action();
                _uow.Commit();
                return GetOkRequestJson(dataReturn);
            }
            catch (Exception ex)
            {
                return GetBadRequestJson(ex.Message);
            }
        }

        private BadRequestObjectResult GetBadRequestJson(string message)
        {
            return BadRequest(new ResponseResult
            {
                Success = false
            });
        }

        private OkObjectResult GetOkRequestJson<T>(T entity)
        {
            return Ok(new ResponseResult
            {
                Success = true,
                Data = entity
            });
        }
    }
}
