namespace level_3_striped_yellow_and_orange_belt;

public class AbilityContainer<T>
{
    private List<T> abilities = new List<T>();

    private string ability = "Heavy Slash (Effect: Deals 50 damage)";
    private string ability2 = "Healing Ray (Effect: Heals 55 health)";
    public void AddAbility(T ability)
    {
        abilities.Add(ability);
        Console.WriteLine($"Added Attack: {ability}");

        Console.WriteLine("Listing all abilities in the container:");
        Console.WriteLine($"- {ability}");
        Console.WriteLine($"- {ability2}");
    }
}