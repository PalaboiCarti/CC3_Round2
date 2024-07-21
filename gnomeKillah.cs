using System;

public class Game
{
    public static void Main(string[] args)
    {
        // Character Making
        Console.WriteLine("What is your name, traveler?");
        string name = Console.ReadLine();

        Console.WriteLine("And what is your ability called?");
        string abilityName = Console.ReadLine();

        Player.Ability person1Ability = new Player.Ability(abilityName, "*placeholder ability sounds*", 200.5, 50);
        Player person1 = new Player(name, 700, person1Ability);

        // First Level
        // Making the WizardGnome
        Player.Ability Gooning = new Player.Ability("Gooning", "*medieval music plays*", 269, 25);
        Player WizardGnome = new Player("Wizard Gnome", 1000, Gooning);

        // Dialogue
        Console.WriteLine("...");
        Console.WriteLine($"Welcome to the supermarket, {name}.");
        Console.WriteLine($"I need your help fighting this wizard gnome; he keeps on messing with my cash register!");
        Console.WriteLine($"[{WizardGnome.Name}]: Nyahahaha, I denounce capitalism from every fiber of my being...");
        Console.WriteLine("_______________________________________");

        // First battle
        while (person1.Health > 0 && WizardGnome.Health > 0)
        {
            person1.castAbility();
            WizardGnome.takeDamage(person1.myAbility.Damage);
            if (WizardGnome.Health <= 0)
            {
                Console.WriteLine($"{WizardGnome.Name} is defeated!");
                break;
            }

            WizardGnome.castAbility();
            person1.takeDamage(WizardGnome.myAbility.Damage);
            if (person1.Health <= 0)
            {
                Console.WriteLine($"{person1.Name} is defeated!");
                break;
            }
        }
    }
}

class Player
{
    public string Name { get; set; }
    public double Health { get; set; }
    public Ability myAbility { get; set; }

    public Player(string name, double health, Ability ability)
    {
        Name = name;
        Health = health;
        myAbility = ability;
    }

    public void castAbility()
    {
        Console.WriteLine($"[Name: {Name}, HP: {Health}]");
        Console.WriteLine($"I, {Name}, cast {myAbility.AbilityName}, here I go!");
        Console.WriteLine($"{myAbility.SoundEffect}");
        bool critHit = Ability.critGenerator(myAbility.CritRate);
        if (critHit)
        {
            Console.WriteLine($"Critical hit! It deals {myAbility.Damage * 2} damage!");
        }
        else
        {
            Console.WriteLine($"*It deals {myAbility.Damage} damage!*");
        }
        Console.WriteLine("_______________________________________");
    }

    public void takeDamage(double oppDamage)
    {
        Health -= oppDamage;
        Console.WriteLine($"[Name: {Name}, HP: {Health}]");
        Console.WriteLine($"Ouch! That dealt {oppDamage} damage, leaving me with {Health} HP!");
        Console.WriteLine("_______________________________________");
    }

    public class Ability
    {
        public string AbilityName { get; set; }
        public string SoundEffect { get; set; }
        public double Damage { get; set; }
        public int CritRate { get; set; }

        public Ability(string abilityName, string soundEffect, double damage, int critRate)
        {
            AbilityName = abilityName;
            SoundEffect = soundEffect;
            CritRate = critRate;
            Damage = damage;
        }

        public static bool critGenerator(int critRate)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 100);
            return num < critRate;
        }
    }
}
