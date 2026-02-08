namespace Singleton;

public sealed class Authenticator
{
    private static readonly Lock Lock = new();

    private Authenticator()
    {
    }

    public static Authenticator Instance
    {
        get
        {
            if (field != null) return field;
            
            lock (Lock)
            {
                field ??= new Authenticator();
            }
            return field;
        }
    }
}