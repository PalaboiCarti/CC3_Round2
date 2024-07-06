using System;

public class Game
{
    public static void Main(string[] args)
    {
        //Character Making
        Console.WriteLine("What is your name, traveler?");
        string name = Console.ReadLine();
        
        Console.WriteLine("And what is your ability called?");
        string abilityName = Console.ReadLine();
        
        Ability person1Ability = new Ability(abilityName, "*placeholder ability sounds*", 102.5, 50);
        Player person1 = new Player(name, 300, person1Ability);
        
        //First Level
        //Making the WizardGnome
        Ability Gooning = new Ability("Gooning", "*medieval music plays*", 269, 20);
        Player WizardGnome = new Player("Wizard Gnome", 1000, Gooning);
        
        //Dialogue
        Console.WriteLine("...");
        Console.WriteLine($"Welcome to the supermarket, {name}.");
        Console.WriteLine($"I need your help fighting this wizard gnome; he keeps on messing with my cash register!");
        Console.WriteLine($"[{WizardGnome.Name}]: Nyahahaha, I denounce capitalism from every fiber of my being...");
        Console.WriteLine("_______________________________________");
        
        //First battle
        person1.castAbility();
        WizardGnome.takeDamage(person1.myAbility.Damage);
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
        //RNG Generator
        Random rnd = new Random();
        int num = rnd.Next(1, 100);

        //Crit Generator
        if(myAbility.CritRate>=num){
            Console.WriteLine("Critical Hit!");
            myAbility.Damage = myAbility.Damage*2;
        }else {
            myAbility.Damage = myAbility.Damage;
        }
        Console.WriteLine($"*it deals {myAbility.Damage} damage!*");
        Console.WriteLine("_______________________________________");
    }
    
    public void takeDamage(double oppDamage)
    {
        Health = Health - oppDamage;
        Console.WriteLine($"[Name: {Name}, HP: {Health}]");
        Console.WriteLine($"Ouch! That dealt {oppDamage} leaving me with {Health} HP!");
        Console.WriteLine("_______________________________________");
    }
    
}

class Ability
{
    public string AbilityName{get; set;}
    public string SoundEffect {get; set;}
    public double Damage {get; set;}
    public int CritRate{get; set;}
    
    public Ability(string abilityName, string soundEffect, double damage, int critRate)
    {
        AbilityName = abilityName;
        SoundEffect = soundEffect;
        Damage = damage;
        CritRate = critRate;
    }
}
