using System;
public class HelloWorld
{
  public static void Main (string[]args)
  {
  	askStuff ();
  	retry ();
  
  	static void askStuff ()
  	{
  	  Console.WriteLine ("Enter your salary");
  	  double salary = double.Parse (Console.ReadLine ());
  
  	    Console.WriteLine ("Enter years worked");
  	  int years = int.Parse (Console.ReadLine ());
  
  	  double bonus = (years >= 10) ? 0.2 : 0.1;
  	  double totalSalary = salary + salary * bonus;
  
  	    Console.WriteLine ($"Your total salary is {totalSalary}");
  	}
  
  	static void retry ()
  	{
  	  while (true)
  		{
  		  Console.WriteLine ("Would you like to retry? y/n");
  		  var res = Console.ReadLine ().Trim ().ToLower ();
  
  		  if (res == "y")
  			{
  			  Console.WriteLine ("Aight");
  			  askStuff ();
  			}
  		  else if (res == "n")
  			{
  			  Console.WriteLine ("Aight have a blessed day booboo");
  			  break;
  			}
  		  else
  			{
  			  Console.WriteLine ("whut u talmbout");
  			}
  
  		}
  	}
  }
}
