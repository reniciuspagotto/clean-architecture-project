using ArquiteturaPadrao.Shared.Enum;
using System;

namespace ArquiteturaPadrao.Domain.Entities
{
    public class Subscription
    {
        public DateTime? ExpireDate { get; private set; }
        public EStatus Active { get; private set; }
        public ESubscriptionTime SubscriptionTime { get; private set; }
    }
}