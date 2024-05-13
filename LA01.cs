using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your salary");
        var salary = double.Parse(Console.ReadLine());
        
        Console.WriteLine("How many years have you worked here?");
        var years = int.Parse(Console.ReadLine());
        
        if(years >= 10){
            double bonus = salary + salary*0.2;
            Console.WriteLine($"Your total salary is {bonus}");
        }else{
            double bonus = salary + salary*0.1;
            Console.WriteLine($"Your total salary is {bonus}");
        }        
    }
}
