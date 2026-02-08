namespace FactoryMethod.Subscriptions;

public class DomesticSubscription : ISubscription
{
    public decimal MonthlyFee => 10.0m;
    public int MinPeriod => 1;
    public List<string> Channels => ["Local News", "National News", "Sports"];
}