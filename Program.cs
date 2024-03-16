using System;

public class HaloGeneric<T> where T : class
{
    public void SapaUser(T x)
    {
        Console.WriteLine(x);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric<string> halo = new HaloGeneric<string>();
        halo.SapaUser("hallo praktian!");
         }
}
