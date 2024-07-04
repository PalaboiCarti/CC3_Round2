using System;

public class Game
{
    public static void Main(string[] args)
    {
        //naming the character
        Console.WriteLine("What is your name, traveler?");
        string name = Console.ReadLine();
        
        Console.WriteLine("And what is your ability called?");
        string abilityName = Console.ReadLine();
        
        Ability person1Ability = new Ability(abilityName, "*placeholder ability sounds*", 102.5);
        Player person1 = new Player(name, 300, person1Ability);
        
        //First Level
        Ability Gooning = new Ability("Gooning", "*medieval music plays*", 269);
        Player WizardGnome = new Player("Wizard Gnome", 1000, Gooning);
        
        Console.WriteLine("...");
        Console.WriteLine($"Welcome to the supermarket, {name}.");
        Console.WriteLine($"I need your help fighting this wizard gnome; he keeps on messing with my cash register!");
        Console.WriteLine($"[{WizardGnome.Name}]: Nyahahaha, I denounce capitalism from every fiber of my being...");
        Console.WriteLine("_______________________________________");
        
        //First battle
        person1.castAbility();
        WizardGnome.castAbility();
        person1.takeDamage(WizardGnome.myAbility.Damage);
    }
}

class Player
{
    public string Name{get; set;}
    private double Health = 300;
    public Ability myAbility;
    
    
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
        Console.WriteLine($"*it deals {myAbility.Damage} damage!*");
        Console.WriteLine("_______________________________________");
    }
    
    public void takeDamage(double oppDamage)
    {
        Health = Health - oppDamage;
        Console.WriteLine($"[Name: {Name}, HP: {Health}]");
        Console.WriteLine($"Ouch! That dealt {oppDamage} leaving me with {Health} HP!");
    }
    
}

class Ability
{
    public string AbilityName{get; set;}
    public string SoundEffect {get; set;}
    public double Damage {get; set;}
    public Ability(string abilityName, string soundEffect, double damage)
    {
        AbilityName = abilityName;
        SoundEffect = soundEffect;
        Damage = damage;
    }
}
