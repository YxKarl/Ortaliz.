using GameApp.Libraries.Interfaces;

class Program
{
    static void Main(string[] args)
    {   // Create instances of IronShield and Potion
        IronShield ironShield = new IronShield("Iron Shield", 150);
        ironShield.ShowInfo();
        ironShield.UseItem();

        Console.WriteLine("-------------------------------");

        Potion Potion = new Potion("Health Potion", 50);
        Potion.ShowInfo();
        Potion.UseItem();
    }
}
