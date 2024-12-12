namespace striped_and_orange_belt;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting actions based on character health...");
        Console.WriteLine("Characters attacking first due to low health!");
        Warrior warrior = new Warrior("Jack", 40);
        Healer healer = new Healer("John", 120);
        Enemy enemy = new Enemy("Goblin", 50);

        string chosenAttack = "Kick";
        string enemyTarget = "Goblin";
        
        var attackButton = new Dictionary<string, Action<string>>
        {
            {"Kick", (enemyTarget) => Console.WriteLine($"The Warrior {warrior._name} kicked {enemyTarget}! It dealt damage!") }
        };


        if (attackButton.ContainsKey(chosenAttack))
        {
            attackButton[chosenAttack](enemyTarget);
        }
        else
        {
            Console.WriteLine("The attack is invalid!");
        }

        string chosenSpell = "Heal";
        string allyTarget = "Warrior Jack";
        
        var HealButton = new Dictionary<string, Action<string>>
        {
            {"Heal", (allyTarget) => Console.WriteLine($"The healer {healer._name} healed {allyTarget}!") }
        };

        if (HealButton.ContainsKey(chosenSpell))
        {
            HealButton[chosenSpell](allyTarget);
        }
        else
        {
            Console.WriteLine("The spell is invalid!");
        }
    }
}