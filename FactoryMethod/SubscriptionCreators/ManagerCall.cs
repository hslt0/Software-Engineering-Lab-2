using FactoryMethod.Subscriptions;

namespace FactoryMethod.SubscriptionCreators;

public class ManagerCall : ISubscriptionCreator
{
    public ISubscription CreateSubscription()
    {
        return new PremiumSubscription();
    }
}