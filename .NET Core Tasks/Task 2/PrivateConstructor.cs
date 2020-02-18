using System; 
namespace privateConstructorExample { 
  
public class PrivateConstructor { 
  
    // declare private Constructor 
    private PrivateConstructor() 
    { 
        
    } 
  
    // declare static variable field 
    public static int count; 
  
    // declare static method 
    public static int Count() 
    { 
        return ++count; 
    } 
  
    // Main Method 
    public static void Main() 
    {   
        PrivateConstructor.count = 99; 
        PrivateConstructor.Count(); 
        Console.WriteLine(PrivateConstructor.count); 
  
        PrivateConstructor.sCount(); 
        Console.WriteLine(PrivateConstructor.count); 
    } 
} 
} 