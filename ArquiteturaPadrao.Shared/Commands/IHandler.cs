using ArquiteturaPadrao.Shared.Response;

namespace ArquiteturaPadrao.Shared.Commands
{
    public interface IHandler<T> where T : class
    {
        object Handle(T command);
    }
}