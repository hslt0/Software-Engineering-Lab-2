using FactoryMethod.Subscriptions;

namespace FactoryMethod.SubscriptionCreators;

public interface ISubscriptionCreator
{
    ISubscription CreateSubscription();
}