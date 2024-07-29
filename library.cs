using System;

class Book{
    public string Name {get;set;}
    public Book(string name){
        Name = name;
    }
    public void Borrow(){
        Console.WriteLine("A general book is being borrowed");
    }
}

class Manga:Book{
    public Manga(string name):base(name){
        Name = name;
    }
    public void Borrow(){
        Console.WriteLine("A manga is being borrowed");
    }
}

class Manhwa:Book{
    public Manhwa(string name):base(name){
        Name = name;
    }
    public void Borrow(){
        Console.WriteLine("A manhwa is being borrowed");
    }
}

class Classic:Book{
    public Classic(string name):base(name){
        Name = name;
    }
    public void Borrow(){
        Console.WriteLine("A classical book is being borrowed");
    }
}

class Librarian{
    public string Name{get; set;}
    public Librarian(string name){
        Name = name;
    }
    
    public void Scold(){
        Console.WriteLine("Librarian: Hoy manahimik ka");
    }
    
    public void Scold(Book book){
        Console.WriteLine($"Librarian: ireturn mo na ang {book.Name}. sumbong kita sigi");
    }
    
    public void Scold(Book book, string dueDate){
        Console.WriteLine($"Librarian: ireturn mo na ang {book.Name} by {dueDate}");
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Book book1 = new Book("The Prince");
        book1.Borrow();
        
        Manga manga1 = new Manga("jjba");
        manga1.Borrow();
        
        Manhwa manhwa1 = new Manhwa("furryporn");
        manhwa1.Borrow();
        
        Classic classic1 = new Classic("The Prince");
        classic1.Borrow();
        
        Librarian Lissandra = new Librarian("Lissandra");
        Lissandra.Scold();
        Lissandra.Scold(book1);
        Lissandra.Scold(book1, "Friday the 13th");
    }
}
