using FactoryMethod.Subscriptions;

namespace FactoryMethod.SubscriptionCreators;

public class MobileApp : ISubscriptionCreator
{
    public ISubscription CreateSubscription()
    {
        return new EducationalSubscription();
    }
}