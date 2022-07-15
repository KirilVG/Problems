using System;

namespace Point_in_the_figure
{
    class Geeks
    {
        static string PointInTheFigure(int h, int x, int y)
        {
            string result = "";

            string inFirstBlock = "";
            if (x < 3 * h && x > 0 && y < h && y > 0) inFirstBlock = "Inside";
            else if (x > 3 * h || x < 0 || y > h || y < 0) inFirstBlock = "Outside";
            else inFirstBlock = "Border";

            string inSecondBlock = "";
            if (x > 1 && x < 2 && y > 1 && y < 4) inSecondBlock = "Inside";
            else if (x < 1 || x > 2 || y < 1 || y > 4) inSecondBlock = "Outside";
            else inSecondBlock = "Border";

            if (inFirstBlock == "Border" && inSecondBlock == "Border" && !(x == h && y == h) && !(x == 2 * h && y == h)) result = "Inside";
            else if (inFirstBlock == "Outside" && inSecondBlock == "Outside") result = "Outside";
            else if (inFirstBlock == "Inside" || inSecondBlock == "Inside") result = "Inside";
            else result = "Border";

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PointInTheFigure(15, -4, 7));
        }
    }
}