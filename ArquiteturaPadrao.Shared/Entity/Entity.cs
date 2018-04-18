using System;

namespace ArquiteturaPadrao.Shared.Entity
{
    public class Entity
    {
        public Guid Id { get; private set; }

        public void CreateId()
        {
            Id = Guid.NewGuid();
        }

        public void SetId(Guid id)
        {
            Id = id;
        }
    }
}