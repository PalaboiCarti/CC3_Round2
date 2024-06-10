using System;

public class Cigarette
{
    //attributes
    private string name;
    public string propName{
        get{return name;}
        set{name = value;}
    }
    
    private string brand;
    public string propBrand{
        get{return brand;}
        set{brand = value;}
    }
    private string quality;
    public string propQuality{
        get{return quality;}
        set{quality = value;}
    }
    
    private int amount;
    public int propAmount{
        get{return amount;}
        set{
            if(value < 0){
                Console.WriteLine($"Imposible naman yan tol eh.");
                Console.WriteLine("");
            }
            amount = value;
            
        }
    }
    
    private int price;
    public int propPrice{
        get{return price;}
        set{
            if(value < 0){
                Console.WriteLine($"Ayos ka din eh noh, sinisingil mo ata ako ah.");
                Console.WriteLine("");
            }
            price = value;
            
        }
    }
    
    private bool cancer;
    public bool propCancer{
        get{return cancer;}
        set{cancer = value;}
    }
    
    //constructor
    public Cigarette(string Name, string Brand, string Quality, int Amount, int Price, bool Cancer)
    {
        propName = Name;
        propBrand = Brand;
        propQuality = Quality;
        propAmount = Amount;
        propPrice = Price;
        propCancer = Cancer;
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
