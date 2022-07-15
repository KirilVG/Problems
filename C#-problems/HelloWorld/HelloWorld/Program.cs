using System;
using System.Globalization;

class HelloWorld
{
    static void DateCalculations()
    {
        string input = Console.ReadLine();
        var date = DateTime.ParseExact(input, "dd-MM-yyyy",CultureInfo.InvariantCulture);
        date = date.AddDays(999);
        Console.WriteLine(date.ToString("dd-MM-yyyy"));
    }

    static void DateCalculationsFromcurrentdate()
    {
        var date = DateTime.Now;
        date = date.AddDays(999);
        Console.WriteLine(date.ToString("dd-MM-yyyy"));
    }

    static void PrintInfo()
    {
        const string boilerplateString = "You are {0} {1}, a {2}-years old person from {3}";
        string firstName = Console.ReadLine()?? "blank";
        string lastName = Console.ReadLine()?? "blank";
        int age = int.Parse(Console.ReadLine() ?? "0");
        string town = Console.ReadLine()?? "blank";
        Console.WriteLine(boilerplateString, firstName,lastName,age,town);
    }

    static void PrintRectangleOfaStars()
    {
        int number = int.Parse(Console.ReadLine());
        for(int i=0;i<number;i++)
        {
            if(i==0 || i==number-1)
            {
                for(int j=0;j<number;j++)
                {
                    Console.Write('*');
                }
            }
            else
            {
                for (int j = 0; j < number; j++)
                {
                    if(j==0||j==number-1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        PrintRectangleOfaStars();
    }
}
public class MyConverter
{
    public void FromCelsiustoFarenheit()
    {
        double C=double.Parse(Console.ReadLine());
        double F = C * 1.8 + 32;
        Console.WriteLine(Math.Round(F, 2));
    }

    public void FromRadianstoDegrees()
    {
        double R = double.Parse(Console.ReadLine());
        double D = R / Math.PI *180;
        Console.WriteLine(Math.Round(D, 0));
    }

    public void FromUSDtoBGN()
    {
        double USD = double.Parse(Console.ReadLine());
        double BGN = USD*1.79549;
        Console.WriteLine(Math.Round(BGN, 2));
    }

    public void CurrencyConverter()
    {
        double amount=Double.Parse(Console.ReadLine());
        string originalCurrency = Console.ReadLine();
        string newCurrency=Console.ReadLine();

        double inBGN;
        switch(originalCurrency)
        {
            case "BGN":
                inBGN = amount;
                break;
            case "USD":
                inBGN = amount * 1.79549;
                break;
            case "EUR":
                inBGN = amount * 1.95583;
                break;
            case "GBP":
                inBGN = amount * 2.53405;
                break;
            default:
                throw new ArgumentException("Invalid currency");
        }

        double newAmount;
        switch (newCurrency)
        {
            case "BGN":
                newAmount = inBGN;
                break;
            case "USD":
                newAmount = inBGN / 1.79549;
                break;
            case "EUR":
                newAmount = inBGN / 1.95583;
                break;
            case "GBP":
                newAmount = inBGN / 2.53405;
                break;
            default:
                throw new Exception("invalid currency");
        }

        Console.WriteLine("{0} {1}",Math.Round(newAmount, 2),newCurrency);
    }
}
public class MyMath
{
    public void TriangleArea(double c,double h)
    {
        double area = Math.Round(c * h / 2, 2);
        Console.WriteLine("Triangle area = {0}", area);
    }
    public void RectangleAreaAndPerimeter(double x1, double y1, double x2, double y2)
    {
        double side1 = (x1 - x2);
        if (side1 < 0) side1 *= -1;
        double side2 = (y1 - y2);
        if (side2 < 0) side2 *= -1;
        double area=side1* side2;
        double perimeter = side1 * 2 + side2 * 2;
        Console.WriteLine("Area = {0}", area);
        Console.WriteLine("Perimeter = {0}", perimeter);
    }
    public void CircleAreaAndPerimeter(double r)
    {
        double area = 3.14 * r * r;
        double perimeter = 2 * 3.14 * r;
        Console.WriteLine("Area = {0}", area);
        Console.WriteLine("Perimeter = {0}", perimeter);
    }
    public double TrapezoidArea()
    {
        double b1 = double.Parse(Console.ReadLine()?? "0.0");
        double b2 = double.Parse(Console.ReadLine() ?? "0.0");
        double h = double.Parse(Console.ReadLine() ?? "0.0");
        return ((b1 + b2) / 2) * h;
    }
    public int SqureArea(int a)
    {
        return a * a;
    }
    public double InchesToCm(double a)
    {
        return a * 2.54;
    }
}
