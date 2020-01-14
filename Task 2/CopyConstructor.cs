using System; 
namespace copyConstructorExample { 
  
class CopyConstructor { 
  
    private string month; 
    private int year; 
  
    public CopyConstructor(CopyConstructor c) 
    { 
        month = c.month; 
        year = c.year; 
    } 
  
    public CopyConstructor(string month, int year) 
    { 
        this.month = month; 
        this.year = year; 
    } 
  
    public string Details 
    { 
        get
        { 
            return "Month: " + month.ToString() +  
                     "\nYear: " + year.ToString(); 
        } 
    } 
  
    public static void Main() 
    { 
  
        CopyConstructor cp1 = new CopyConstructor("June", 2018); 
        CopyConstructor cp2 = new CopyConstructor(cp1); 
  
        Console.WriteLine(cp2.Details); 
    } 
} 
} 