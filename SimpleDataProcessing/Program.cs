﻿using System;

internal class GlazerCalc
{
    public static void Main()
    {
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        widthString = Console.ReadLine() ?? string.Empty;
        width = double.Parse(widthString);

        heightString = Console.ReadLine() ?? string.Empty;
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width + height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet.");
        Console.WriteLine("The area of the glass is " + glassArea + " square meters.");
    }
}
