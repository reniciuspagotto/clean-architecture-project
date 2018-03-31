namespace ArquiteturaPadrao.Infra.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        void CommitAsync();
    }
}
