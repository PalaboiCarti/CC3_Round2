using System;

public class CritTesting
{
    public static void Main(string[] args)
    {
        Ability ability1 = new Ability("Skibidi Hellscape", "SKIBIDI DOP DOP DOP YES YES YES", 102.5, 50);
        ability1.cast();
    }
}

class Ability
{
    public string AbilityName{get; set;}
    public string SoundEffect {get; set;}
    public double Damage {get; set;}
    public int CritRate {get; set;}
    
    public Ability(string abilityName, string soundEffect, double damage, int critRate)
    {
        AbilityName = abilityName;
        SoundEffect = soundEffect;
        Damage = damage;
        CritRate = critRate;
    }
    
    public void cast()
    {
        Console.WriteLine($"I cast {AbilityName}!");

        //RNG Generator
        Random rnd = new Random();
        int num = rnd.Next(1, 100);

        //Crit Generator
        if(CritRate<=num){
            Console.WriteLine("Critical Hit!");
            Damage = Damage*2;
        }else {
            Damage = Damage;
        }
        
        Console.WriteLine($"{AbilityName} deals {Damage} damage!");
    }
}
