using System.ComponentModel.Design;

namespace striped_and_orange_belt;


    class Warrior
    {
        public string name { get; }
        private int health;
        private int attack;

        private var ActionButton = new Button
        {
            Text = "Attack",
            Command = new Command(() => AttackButton())
        };

        public Warrior(string name, int health, int attack)
        {
            _name = name;
            _health = health;
            _attack = attack;
        }

        public string _name;
        public int _health;
        public int _attack;
    }
    class Healer
    {
        private string name { get; }
        private int health;
        private int attack;
        
        var Actionbutton = new Button
        {
            Text = "Heal",
            Command = new Command(() => HealButton)
        }

        public Healer(string name, int health, int attack)
        {
            _name = name;
            _health = health;
            _attack = attack;
        }

        public string _name;
        public int _health;
        public int _attack;


    }

    class Enemy
    {
        
    }
