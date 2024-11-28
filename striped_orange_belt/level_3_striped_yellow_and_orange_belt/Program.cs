namespace level_3_striped_yellow_and_orange_belt;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Adding abilities to the container...");
        AbilityContainer<string> abilityContainer = new AbilityContainer<string>();
        Console.WriteLine(abilityContainer);
    }
}