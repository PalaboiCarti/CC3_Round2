using System;

public class Cigarette
{
    //attributes
    public string name{get;set;}
    public string brand{get;set;}
    public string quality{get;set;}
    public int amount{get;set;}
    public int price{get;set;}
    public bool cancer{get;set;}
    
    //constructor
    public Cigarette(string Name, string Brand, string Quality, int Amount, int Price, bool Cancer)
    {
        name = Name;
        brand = Brand;
        quality = Quality;
        amount = Amount;
        price = Price;
        cancer = Cancer;
    }
    
    //method
    public void info(){
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Okey ba to? {quality} yan");
        Console.WriteLine($"Ilan sa isang kaha? {amount} tol");
        Console.WriteLine($"Magkano yan? {price} lang yan");
        if(cancer == true){
            Console.WriteLine("Okey na sana kaso magkaka cancer ka neto eh");
        }else{
            Console.WriteLine("Efas to men");
        }
        
    }
}


class Program{
    static void Main(){
        Cigarette MarlboroRed = new Cigarette("Marlboro Red", "Marlboro", "Goodshit", 20, 180, true);
        MarlboroRed.info();
    }
}
