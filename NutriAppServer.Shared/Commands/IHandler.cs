using NutriAppServer.Shared.Response;

namespace NutriAppServer.Shared.Commands
{
    public interface IHandler<T> where T : class
    {
        object Handle(T command);
    }
}