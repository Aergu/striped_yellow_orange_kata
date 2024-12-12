namespace level_3_striped_yellow_and_orange_belt;

public interface IAbility
{
    string Name { get; }
    void Execute();
}
public class HealAbility : IAbility
{
    public string Name => "Healing Light";
    public void Execute()
    {
        Console.WriteLine($"{Name} healed for 50 health points!");
    }
}

public class AttackAbility : IAbility
{
    public string Name => "Crushing Blow";
    public void Execute()
    {
        Console.WriteLine($"{Name} deals 100 damage!");
    }
}
public class AbilityContainer<T> where T : IAbility
{
    private readonly List<T> _abilities = new List<T>();

    public void AddAbility(T ability)
    {
        _abilities.Add(ability);
        Console.WriteLine($"Ability {ability.Name} added to the container.");
    }

    public void RemoveAbility(T ability)
    {
        _abilities.Remove(ability);
        Console.WriteLine($"Ability {ability.Name} removed from the container.");
    }

    public void ExecuteAllAbilities()
    {
        foreach (var ability in _abilities)
        {
            ability.Execute();
        }
    }
}
