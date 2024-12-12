using System.Security.Cryptography;

namespace level2_striped_yellow_and_orange_belt;

public class PlayerCharacter
{
    public string Name { get; set; }
    public int Health { get; private set; }

    // Event for health changes
    public event Action<int> _healthChanged;

    public PlayerCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;

        Console.WriteLine($"{Name} took {damage} damage!");
        _healthChanged?.Invoke(Health);
    }
}

public class EnemyCharacter
{
    public string Name { get; set; }
    public int Health { get; private set; }

    // Event for health changes
    public event Action<int> _healthChanged;

    public EnemyCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;

        Console.WriteLine($"{Name} took {damage} damage!");
        _healthChanged?.Invoke(Health);
    }
}

