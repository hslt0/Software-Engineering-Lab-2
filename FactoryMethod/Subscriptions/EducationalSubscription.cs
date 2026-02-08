namespace FactoryMethod.Subscriptions;

public class EducationalSubscription : ISubscription
{
    public decimal MonthlyFee => 5.0m;
    public int MinPeriod => 6;
    public List<string> Channels => ["Documentaries", "History", "Science"];
}