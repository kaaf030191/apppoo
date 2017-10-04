public sealed class Singleton
{
    private static volatile Singleton instance;

    private Singleton() { }

    public static Singleton GetInstance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}