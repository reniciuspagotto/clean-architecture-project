using ArquiteturaPadrao.Infra.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaPadrao.Api.Controllers
{
    public class BaseController : Controller
    {
        private readonly IUnitOfWork _uow;

        public BaseController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Commit()
        {
            _uow.Commit();
        }

        public void CommitAsync()
        {
            _uow.CommitAsync();
        }
    }
}
