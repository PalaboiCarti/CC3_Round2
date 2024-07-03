using System;

public class Game
{
    public static void Main(string[] args)
    {
        //naming the character
        Console.WriteLine("What is your name, traveler?");
        string name = Console.ReadLine();
        
        //First Level
        Console.WriteLine("...");
        Console.WriteLine($"Welcome to the supermarket, {name}.");
        Console.WriteLine($"I need your help fighting this wizard gnome; he keeps on messing with my cash register!");
        Console.WriteLine("_______________________________________");
        
        
        //first battle
        Player person1 = new Player(name, 300);
        Ability Skibidi = new Ability("The Mighty Skibidi", "*brrrrrr skibidi dop dop dop yes yes*", 102.5);
        person1.castAbility(Skibidi);
        
        Player person2 = new Player("Wizard Gnome", 1000);
        Ability Gooning = new Ability("Gooning", "*medieval music plays*", 269);
        WizardGnome.castAbility(Gooning);
        
        person1.takeDamage(Gooning);
    }
}

class Player
{
    public string Name{get; set;}
    private double Health = 300;
    
    public Player(string name, double health)
    {
        Name = name;
        Health = health;
    }
    
    public void castAbility(Ability myAbility)
    {
        Console.WriteLine($"[Name: {Name}, HP: {Health}]");
        Console.WriteLine($"I, {Name}, cast {myAbility.AbilityName}, here I go!");
        Console.WriteLine($"{myAbility.SoundEffect}");
        Console.WriteLine($"*it deals {myAbility.Damage} damage!*");
        Console.WriteLine("_______________________________________");
    }
    
    public void takeDamage(Ability oppAbility)
    {
        Health = Health - oppAbility.Damage;
        Console.WriteLine($"[Name: {Name}, HP: {Health}]");
        Console.WriteLine($"Ouch! That dealt {oppAbility.Damage} leaving me with {Health} HP!");
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
