using FactoryMethod.Subscriptions;

namespace FactoryMethod.SubscriptionCreators;

public class WebSite : ISubscriptionCreator
{
    public ISubscription CreateSubscription()
    {
        return new DomesticSubscription();
    }
}