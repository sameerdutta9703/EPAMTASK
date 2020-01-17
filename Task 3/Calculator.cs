using System;

class Calculator
{
    public static void Main(string[] args)
    {
        int firstNum, secondNum;
        String operation;

        Console.WriteLine("Enter the first number");
        firstNum=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        secondNum=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operator to perform the specified operation");
        Console.WriteLine("The operators should be among +, -, *, /");
        operation=Console.ReadLine();

        if(opetation=="+")
        {
            Console.WriteLine(firstNum+" + "+secondNum+"  = "+(firstNum+secondNum));
            Console.ReadLine();
        }

        else if(opetation=="-")
        {
            Console.WriteLine(firstNum+" - "+secondNum+"  = "+(firstNum-secondNum));
            Console.ReadLine();
        }

        else if(opetation=="*")
        {
            Console.WriteLine(firstNum+" * "+secondNum+"  = "+(firstNum*secondNum));
            Console.ReadLine();
        }

        else if(opetation=="/")
        {
            Console.WriteLine(firstNum+" / "+secondNum+"  = "+(firstNum/secondNum));
            Console.ReadLine();
        }
    }
}