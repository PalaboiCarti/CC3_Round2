using System;

public class MainProgram
{
    public static void Main(string[] args)
    {
        Person Esquibidi = new Person("Esquibidi", 300);
        Ability Skibidi = new Ability("The Mighty Skibidi", "*brrrrrr skibidi dop dop dop yes yes*", 102.5);
        Esquibidi.castAbility(Skibidi);
        
        Person WizardGnome = new Person("Wizard Gnome", 1000);
        Ability Gooning = new Ability("Gooning", "*medieval music plays*", 269);
        WizardGnome.castAbility(Gooning);
        
        Esquibidi.takeDamage(Gooning);
    }
}

class Person
{
    public string Name{get; set;}
    public double Health{get; set;}
    
    public Person(string name, double health)
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
