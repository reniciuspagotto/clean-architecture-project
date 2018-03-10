using NutriAppServer.Shared.Enum;
using System;

namespace NutriAppServer.Domain.Entities
{
    public class Subscription
    {
        public DateTime? ExpireDate { get; private set; }
        public EStatus Active { get; private set; }
        public ESubscriptionTime SubscriptionTime { get; private set; }
    }
}