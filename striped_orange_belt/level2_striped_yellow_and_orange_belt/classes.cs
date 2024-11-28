namespace level2_striped_yellow_and_orange_belt;

class Character
{
    private string name { get; }
    private int health;

    public Character(string name, int health)
    {
        _name = name;
        _health = health;
    }
    
    
    public void CharHealthChange(int damage, int heal)
    {
        _health -= damage;
        _health += heal;
    }
}