using Singleton;

Console.WriteLine("Singleton Pattern Example (Authenticator)\n");

// Test single thread
var auth1 = Authenticator.Instance;
var auth2 = Authenticator.Instance;

Console.WriteLine(auth1 == auth2
    ? "Single thread: Both variables contain the same instance."
    : "Single thread: Variables contain different instances.");

// Test multi-thread
Console.WriteLine("\nTesting with multiple threads...");

Parallel.For(0, 10, _ =>
{
    var auth = Authenticator.Instance;
    Console.WriteLine($"Thread {Task.CurrentId}: Instance HashCode = {auth.GetHashCode()}");
});