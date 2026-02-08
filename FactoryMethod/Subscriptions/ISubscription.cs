namespace FactoryMethod.Subscriptions;

public interface ISubscription
{
    decimal MonthlyFee { get; }
    int MinPeriod { get; } // in months
    List<string> Channels { get; }
}