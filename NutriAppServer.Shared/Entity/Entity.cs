using Flunt.Notifications;
using System;

namespace NutriAppServer.Shared.Entity
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