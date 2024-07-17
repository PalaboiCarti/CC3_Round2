using System;

public class Vehicle
{
    public string Brand{get;set;}
    public string Model{get;set;}
    public int Year{get;set;}
    
    public void DisplayInfo(){
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
    }
    
    public void StartEngine(){
        Console.WriteLine($"Alas, the engine starts... vrrrr");
    }
    
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }
}

public class Car:Vehicle
{
    public int NumberOfSeats{get;set;}
    public bool HasSunRoof{get;set;}
    
    public void DisplayCarInfo(){
        Console.WriteLine($"Brand: {Brand}, model: {Model}, year: {Year}, seats: {NumberOfSeats}, has sunroof: {HasSunRoof}");    
    }
    
    public Car(string brand, string model, int year, int seats, bool sunRoof):base(brand, model, year)
    {
        Brand = brand;
        Model = model;
        Year = year;
        NumberOfSeats = seats;
        HasSunRoof = sunRoof;
    }
}

public class Boat:Vehicle
{
    public string HullMaterial{get;set;}
    public string Draft{get;set;}
    
    public void DisplayBoatInfo(){
        Console.WriteLine($"Brand: {Brand}, model: {Model}, year: {Year}, hull: {HullMaterial}, draft: {Draft}"); 
    }
    
    public Boat(string brand, string model, int year, string hull, string draft):base(brand, model, year)
    {
        Brand = brand;
        Model = model;
        Year = year;
        HullMaterial = hull;
        Draft = draft;
    }
}

public class Airplane:Vehicle
{
    public int Wingspan{get;set;}
    public int MaxAltitude{get;set;}
    
    public void DisplayAirplaneInfo(){
        Console.WriteLine($"Brand: {Brand}, model: {Model}, year: {Year}, wingspan: {Wingspan}, max altitude: {MaxAltitude}"); 
    }
    
    public Airplane(string brand, string model, int year, int wingspan, int altitude):base(brand, model, year)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Wingspan = wingspan;
        MaxAltitude = altitude;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Car DaBaby = new Car("Dababy", "Unknown", 1969, 4, false);
        DaBaby.DisplayCarInfo();
        
        Boat FlyingDutchman = new Boat("The Flying Dutchman", "his mom", 888, "pirate", "pirate siguro");
        FlyingDutchman.DisplayBoatInfo();
        
        Airplane AngelOfDarkness = new Airplane("Angel of darkness", "the forsaken one", 777, 777, 9999999);
        AngelOfDarkness.DisplayAirplaneInfo();
    }
}
