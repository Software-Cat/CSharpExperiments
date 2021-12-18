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

        Console.WriteLine("Give the width of the window: ");
        widthString = Console.ReadLine() ?? string.Empty;
        width = double.Parse(widthString);

        if (width < MIN_WIDTH)
        {
            Console.WriteLine("Width is too small.\n\n");
            Console.WriteLine("Using minimum.");
            width = MIN_WIDTH;
        }
        else if (width > MAX_WIDTH)
        {
            Console.WriteLine("Width is too large.\n\n");
            Console.WriteLine("Using maximum.");
            width = MAX_WIDTH;
        }

        Console.WriteLine("Give the height of the window: ");
        heightString = Console.ReadLine() ?? string.Empty;
        height = double.Parse(heightString);

        if (height < MIN_HEIGHT)
        {
            Console.WriteLine("Height is too small.\n\n");
            Console.WriteLine("Using minimum.");
            height = MIN_HEIGHT;
        }
        else if (height > MAX_HEIGHT)
        {
            Console.WriteLine("Height is too large.\n\n");
            Console.WriteLine("Using maximum.");
            height = MAX_HEIGHT;
        }

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width + height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet.");
        Console.WriteLine("The area of the glass is " + glassArea + " square meters.");
    }
}
