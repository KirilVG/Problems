using System;
using System.Globalization;

class HelloWorld
{
    const int bonusDays = 999;

    static void DateCalculations()
    {

        string input = Console.ReadLine();
        DateTime date = DateTime.ParseExact(input, "dd-mm-yyyy", CultureInfo.InvariantCulture);

        date = date.AddDays(bonusDays);
        Console.WriteLine(date.ToString("dd-mm-yyyy"));

    }

    static void DateCalculationsFromCurrentDate()
    {

        var date = DateTime.Now;

        date = date.AddDays(bonusDays);
        Console.WriteLine(date.ToString("dd-mm-yyyy"));

    }

    static void PrintInfo(string firstName, string lastName, int age, string town)
    {

        const string boilerplateString = "You are {0} {1}, a {2}-years old person from {3}";

        Console.WriteLine(boilerplateString, firstName, lastName, age, town);

    }

    static void PrintRectangleStars(int number)
    {

        for (int i = 0; i < number; i++)
        {

            if (i == 0 || i == number - 1)
            {

                for (int j = 0; j < number; j++)
                {

                    Console.Write('*');

                }

            }

            else
            {

                for (int j = 0; j < number; j++)
                {

                    if (j == 0 || j == number - 1)
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
        DateCalculations();
    }
}
public class MyConverter
{
    const double BGNtoBGNMultiplier = 1;
    const double USDtoBGNMultiplier = 1.79549;
    const double EURtoBGNMultiplier = 1.95583;
    const double GBPtoBGNMultiplier = 2.53405;

    const double CelsiusToFarenheitMultiplier = 1.8;
    const double CelsiusToFarenheitOfset = 32.0;

    const double RadiansToDegreesMultiplier = 180;


    public double FromCelsiusToFarenheit(double C)
    {

        double F = C * CelsiusToFarenheitMultiplier + CelsiusToFarenheitOfset;

        return Math.Round(F, 2);

    }

    public double FromRadiansToDegrees(double R)
    {

        double D = R / Math.PI * RadiansToDegreesMultiplier;

        return Math.Round(D, 0);

    }

    public double FromUSDtoBGN(double USD)
    {

        double BGN = USD * USDtoBGNMultiplier;

        return Math.Round(BGN, 2);

    }

    public double CurrencyConverter(double amount, string originalCurrency, string newCurrency)
    {

        double inBGN;
        double newAmount;

        switch (originalCurrency)
        {

            case "BGN":
                inBGN = amount;
                break;

            case "USD":
                inBGN = amount * USDtoBGNMultiplier;
                break;

            case "EUR":
                inBGN = amount * EURtoBGNMultiplier;
                break;

            case "GBP":
                inBGN = amount * GBPtoBGNMultiplier;
                break;

            default:
                throw new ArgumentException("Invalid currency");

        }

        switch (newCurrency)
        {

            case "BGN":
                newAmount = inBGN;
                break;

            case "USD":
                newAmount = inBGN / USDtoBGNMultiplier;
                break;

            case "EUR":
                newAmount = inBGN / EURtoBGNMultiplier;
                break;

            case "GBP":
                newAmount = inBGN / GBPtoBGNMultiplier;
                break;

            default:
                throw new Exception("invalid currency");

        }

        return Math.Round(newAmount, 2);

    }
}

public class MyMath
{
    const double inchesToCmMultiplier = 2.54;
    public void TriangleArea(double c, double h)
    {

        double area = Math.Round(c * h / 2, 2);

        Console.WriteLine("Triangle area = {0}", area);

    }
    public void RectangleAreaAndPerimeter(double x1, double y1, double x2, double y2)
    {

        double side1 = Math.Abs(x1 - x2);
        double side2 = Math.Abs(y1 - y2);
        double area = side1 * side2;
        double perimeter = side1 * 2 + side2 * 2;

        Console.WriteLine("Area = {0}", area);
        Console.WriteLine("Perimeter = {0}", perimeter);

    }
    public void CircleAreaAndPerimeter(double r)
    {

        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine("Area = {0}", area);
        Console.WriteLine("Perimeter = {0}", perimeter);

    }
    public double TrapezoidArea(double b1, double b2, double h)
    {

        return ((b1 + b2) / 2) * h;

    }
    public int SqureArea(int a)
    {

        return a * a;

    }
    public double InchesToCm(double a)
    {

        return a * inchesToCmMultiplier;

    }
}
