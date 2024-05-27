using System;
public class Hero
{
    public string name;
    public string type;
    public string abilityName;
    public int attack;
    public int defense;
    
    public Hero(string name, string type, string abilityName)
    {
        name = name;
        type = type;
        abilityName = abilityName;
        
        if(type == "defender"){
            attack = 10;
            defense = 25;
        } else if(type == "duelist")
        {
            attack = 20;
            defense = 20;
        } else if(type == "marksman"){
            attack = 25;
            defense = 15;
        }
    }
    
    public void displayStats()
        {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Type: {type}");
        Console.WriteLine($"Ability: {abilityName}");
        Console.WriteLine($"Attack: {attack}");
        Console.WriteLine($"Defense: {defense}");
    }
    
    public void castAbility()
    {
        Console.WriteLine($"{name} used {abilityName} dealing {attack} damage to the enemy.");
    }
    
    
    
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your hero's name?");
        string name = Console.ReadLine();
        
        Console.WriteLine("What is your hero's type? (defender, duelist, marksman)");
        string type = Console.ReadLine();
        
        Console.WriteLine("What is your hero's ability?");
        string abilityName = Console.ReadLine();
        
        Hero hero1 = new Hero(name, type, abilityName);
        hero1.displayStats();
        hero1.castAbility();
        
    }
}
