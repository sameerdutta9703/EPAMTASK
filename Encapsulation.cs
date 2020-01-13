using System;

class Encapsulation
{
    DemoEncap obj=new DemoEncap();

    obj.Name = "Sameer";
    obj.Age = "22";

    //console out the desired output
    Console.WriteLine("Name: " +  obj.Name);
    Console.WriteLine("Age: " +obj.Age);
    Console.Readline();
}

public class DemoEncap {

    //Declaring two private variables
    private String stuName;
    private int stuAge;

    public String Name
    {
        get
        {
            return stuName;
        }
        set
        {
            stuName value;
        }
    }

    public int Age
    {
        get
        {
            return stuAge;
        }
        set
        {
            StuAge=value;
        }
    }
}
