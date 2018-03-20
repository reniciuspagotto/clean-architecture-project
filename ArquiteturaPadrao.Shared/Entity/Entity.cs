using Flunt.Notifications;
using System;

namespace ArquiteturaPadrao.Shared.Entity
{
    public class Entity : Notifiable
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}