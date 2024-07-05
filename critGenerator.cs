using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int num = rnd.Next(1, 100);
        Console.WriteLine(num);
        
        Ability ability1 = new Ability("Skibidi Hellscape", "SKIBIDI DOP DOP DOP YES YES YES", 102.5, num);
        
        Console.WriteLine(ability1.AbilityName);
        Console.WriteLine(ability1.Damage);
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
        if(critRate<=50){
            Console.WriteLine("Critical Hit!");
            damage = damage*2;
            Damage = damage;
        }else {
            Damage = damage;
        }
        Damage = damage;
        CritRate = critRate;
    }
}
