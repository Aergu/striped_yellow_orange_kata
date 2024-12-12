using System.ComponentModel.Design;

namespace striped_and_orange_belt;


    class Warrior
    {
        string name { get; }

       

        public Warrior(string name, int health)
        {
            _name = name;
            _health = health;
        }

        public string _name;
        public int _health;
       
    }

    
    class Healer
    {
        private string name { get; }
        private int health;
        

        public Healer(string name, int health)
        {
            _name = name;
            _health = health;
        }

        public string _name;
        public int _health;
        
    }

    class Enemy
    {
        private string name = "Goblin";

        public Enemy(string name, int health)
        {
            _name = name;
            _health = health;
        }
        
        public string _name;
        public int _health;
        
    }

