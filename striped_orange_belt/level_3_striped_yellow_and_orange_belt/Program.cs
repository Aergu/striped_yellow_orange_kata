namespace level_3_striped_yellow_and_orange_belt;

class Program
{
    static void Main(string[] args)
    {
       
        var heal = new HealAbility();
        var attack = new AttackAbility();
        
        var playerAbilities = new AbilityContainer<IAbility>();
        
        playerAbilities.AddAbility(heal);
        playerAbilities.AddAbility(attack);
        
        Console.WriteLine("Executing all abilities:");
        playerAbilities.ExecuteAllAbilities();
        
        playerAbilities.RemoveAbility(attack);
        
        Console.WriteLine("Executing remaining abilities:");
        playerAbilities.ExecuteAllAbilities();
    }
}