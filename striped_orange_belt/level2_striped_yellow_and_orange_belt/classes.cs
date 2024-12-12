namespace level2_striped_yellow_and_orange_belt;

class PlayerCharacter
{
    public string name = "Joshua";
    public int health = 2000;
    public int damage = 10;

    public delegate void PlayerCharacterAction(int Attack);

    
    public static void PrintToConsole(int Attack)
    {
        Console.WriteLine($"{Attack}");
    }

    public delegate void HealthChangedEvent(int healthChanged);
    public event HealthChangedEvent _healthChanged;
    public void HealthCheck(int healthChanged)
    {
        Console.WriteLine($"Enemy ambush!");
        
        _healthChanged?.Invoke(healthChanged);
    }

 
}

class EnemyCharacter
{
    public string name = "Dark Knight";
    public int health = 3000;
    public int damage = 8;
    
    public delegate void EnemyCharacterAction(int Attack);

    public delegate void HealthChangedEvent(int healthChanged);
    public event HealthChangedEvent _healthChanged;
    public void HealthCheck(int healthChanged)
    {
        Console.WriteLine($"Enemy ambush!");
        
        _healthChanged?.Invoke(healthChanged);
    }
}

