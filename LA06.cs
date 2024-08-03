using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Warrior Garen = new Warrior("Garen", 100);
        Mage Lux = new Mage("Lux", 80);
        
        void battle(){
            while (Garen.Health > 0 && Lux.Health > 0)
            {
                Garen.Attack("Lux", Lux);
                if (Lux.Health <= 0)
                {
                    Lux.DisplayStatus();
                    break;
                }
                Lux.Defend();
                Lux.DisplayStatus();
                Lux.Attack("Garen", Garen);
                if (Garen.Health <= 0)
                {
                    Garen.DisplayStatus();
                    break;
                }
                Garen.Defend();
                Garen.DisplayStatus();
            }    
        }
        
        battle();
    }
}

//template for game characters
abstract class GameCharacter{
    public string Name {get; set;}
    public double Health {get; set;}
    
    public abstract void DisplayStatus();
    
    public GameCharacter(string name, double health){
        Name = name;
        Health = health;
    }
}

//interface for actions
interface IActions{
    void Attack(string a, GameCharacter b);
    void Defend();
    void SpecialAttack(string a, GameCharacter b);
}

//class warrior
class Warrior:GameCharacter, IActions{
    public Warrior(string name, double health):base(name, health){
        Name = name;
        Health = health;
    }
    
    public void Attack(string name, GameCharacter gc)
    {
        Console.WriteLine($"{Name}: I swing my sword at you!");
        double damage = 10;
        gc.Health -= damage;
    }   
    public void SpecialAttack(string name, GameCharacter gc){
        Console.WriteLine($"{Name}: DEMAAACIA");
        double damage = 69420;
        gc.Health -= damage;
    }
    
    public void Defend(){
        Console.WriteLine($"{Name}: Blllllocked");
    }
    
    public override void DisplayStatus(){
        Console.WriteLine($"{Name}'s Health : {Health}");
        if(Health > 0){
            Console.WriteLine($"{Name} still lives!");
        }else{
            Console.WriteLine($"{Name} is dead!");
        }
    }
}
//class mage
class Mage:GameCharacter, IActions{
    public Mage(string name, double health):base(name, health){
        Name = name;
        Health = health;
    }
    
    public void Attack(string name, GameCharacter gc){
        Console.WriteLine($"{Name}: I swing my staff at you good sir!");
        double damage = 15;
        gc.Health -= damage;
    }
    
    public void SpecialAttack(string name, GameCharacter gc){
        Console.WriteLine($"{Name}: HUUUUUUUUAH");
        double damage = 100;
        gc.Health -= damage;
    }
    
    public void Defend(){
        Console.WriteLine($"{Name}: SHIELD SPELL");
    }
    
    public override void DisplayStatus(){
        Console.WriteLine($"{Name}'s Health : {Health}");
        if(Health > 0){
            Console.WriteLine($"{Name} still lives!");
        }else{
            Console.WriteLine($"{Name} is dead!");
        }
    }
}
