namespace striped_and_orange_belt;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting actions based on character health...");
        Console.WriteLine("Characters attacking first due to low health!");
        Warrior warrior = new Warrior("Jack", 40, 60);
        Healer healer = new Healer("John", 120, 30);

        warrior => warrior._health < 50;
    }
}