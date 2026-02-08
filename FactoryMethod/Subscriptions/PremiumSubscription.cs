namespace FactoryMethod.Subscriptions;

public class PremiumSubscription : ISubscription
{
    public decimal MonthlyFee => 25.0m;
    public int MinPeriod => 12;
    public List<string> Channels => ["Movies", "Music", "Sports", "News", "Documentaries"];
}