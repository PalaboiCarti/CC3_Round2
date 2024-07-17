using System;

public class Person
{
    public string Name{get;set;}
    public int Age{get;set;}
    
    public void Eat(string Food){
        Console.WriteLine($"{Name} had {Food} for dinner.");
    }
}

class Student:Person
{
    public bool nagAaralPa{get;set;}
    public void goToSchool(){
        if(nagAaralPa == true){
            Console.WriteLine($"{Name} surprisingly still goes to school.");       
        } else {
            Console.WriteLine($"Hindi na nag aaral yan si {Name}.");
        }
    }
}

class CollegeStudent:Student
{
    public string Uni{get;set;}
    public void goToUni(){
        if(nagAaralPa == true){
             
            Console.WriteLine($"{Name} goes to {Uni} and attends classes sometimes; depende sa mood.");       
        } else {
            Console.WriteLine($"{Name} has taken the balasubas route and no longer studies in {Uni}");
        }
    }
}

public class MainThing
{
    public static void Main(string[] args)
    {
        Person Gregorio = new Person();
        Gregorio.Name = "Gregorio";
        Gregorio.Age = 20;
        Gregorio.Eat("Marlboro Red and Sting");
        
        Student stud1 = new Student();
        stud1.nagAaralPa = true;
        stud1.Name = Gregorio.Name;
        stud1.goToSchool();
        
        CollegeStudent coll1 = new CollegeStudent();
        coll1.Uni = "University of the Cordilleras";
        coll1.nagAaralPa = stud1.nagAaralPa;
        coll1.Name = stud1.Name;
        coll1.goToUni();
        
    }
}
