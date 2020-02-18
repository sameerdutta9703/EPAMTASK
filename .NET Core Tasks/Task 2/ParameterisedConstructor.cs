using System; 
namespace ParameterizedConstructorExample { 
 
class Parameterized { 
  
    String name; 
    int id; 
  
    Parameterized(String name, int id) 
    { 
        this.name = name; 
        this.id = id; 
    } 
  
    public static void Main() 
    { 
  
        Parameterized pm = new Parameterized("Sameer", 6004); 
        Console.WriteLine("Name = " + pm.name + 
                         " and Id = " + pm.id); 
    } 
} 
} 