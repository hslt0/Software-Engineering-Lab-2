using FactoryMethod.SubscriptionCreators;
using FactoryMethod.Subscriptions;

Console.WriteLine("Factory Method Pattern Example\n");

ISubscriptionCreator webSite = new WebSite();
var domesticSub = webSite.CreateSubscription();
PrintSubscriptionDetails("WebSite", domesticSub);

ISubscriptionCreator mobileApp = new MobileApp();
var educationalSub = mobileApp.CreateSubscription();
PrintSubscriptionDetails("MobileApp", educationalSub);

ISubscriptionCreator managerCall = new ManagerCall();
var premiumSub = managerCall.CreateSubscription();
PrintSubscriptionDetails("ManagerCall", premiumSub);
return;

void PrintSubscriptionDetails(string creatorName, ISubscription subscription)
{
    Console.WriteLine($"Created via {creatorName}: {subscription.GetType().Name}");
    Console.WriteLine($"Monthly Fee: {subscription.MonthlyFee}");
    Console.WriteLine($"Min Period: {subscription.MinPeriod} months");Console.WriteLine($"Channels: {string.Join(", ", subscription.Channels)}");
    Console.WriteLine();
}
