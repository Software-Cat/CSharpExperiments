using System;

internal class GlazerCalc
{
    public static void Main()
    {
        const double MAX_WIDTH = 5.0;
        const double MAX_HEIGHT = 3.0;
        const double MIN_WIDTH = .5;
        const double MIN_HEIGHT = .75;

        double width, height, woodLength, glassArea;
        string widthString, heightString;

        do
        {
            Console.Write($"Give the width of the window between {MIN_WIDTH} and {MAX_WIDTH}: ");
            widthString = Console.ReadLine() ?? string.Empty;
            width = double.Parse(widthString);
        } while (width < MIN_WIDTH || width > MAX_WIDTH);

        do
        {
            Console.Write($"Give the height of the window between {MIN_HEIGHT} and {MAX_HEIGHT}: ");
            heightString = Console.ReadLine() ?? string.Empty;
            height = double.Parse(heightString);
        } while (height < MIN_HEIGHT || height > MAX_HEIGHT);

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width + height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet.");
        Console.WriteLine("The area of the glass is " + glassArea + " square meters.");
    }
}
