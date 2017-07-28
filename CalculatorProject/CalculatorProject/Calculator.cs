using System;

public class Calculator
{
    int numberone;
    int numbertwo;

    int main()
    {
        Console.WriteLine("What is the first number?");
        numberone = Console.ReadLine();
        Console.WriteLine("What is the second number?");
        numbertwo = Console.ReadLine();
        int sum;
        sum = numberone + numbertwo;
        Console.WriteLine(sum);


    }
    //public void plus() { }
    //public void minus() { }
    //public void times() { }
    //public void divide() { }

}
