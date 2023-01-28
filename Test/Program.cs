class Osoba
{
    private int _wiek;

    public int PobierzWiek()
    {
        return _wiek;
    }

    public void UstawWiek(int wiek)
    {
        _wiek = wiek;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Osoba Karol = new Osoba();

        Karol.UstawWiek(21);
        System.Console.WriteLine(Karol.PobierzWiek());

        System.Console.ReadKey();
    }
}