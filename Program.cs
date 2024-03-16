using System;

public class DataGeneric<T> where T : struct
{
    public T Data { get; private set; }

    public void SetData(T data)
    {
        this.Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan: " + Data);
    }
}

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

        DataGeneric<int> dataGeneric = new DataGeneric<int>();
        dataGeneric.SetData(1302223032);
        dataGeneric.PrintData();
    }
}