using System.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        // Assigment 1
        // Console.WriteLine("Converting SEK to YEN");
        // int sek = Convert.ToInt32(Console.ReadLine()); 
        // double yen = ConvertSekToYen(sek);
        // Console.WriteLine($"{sek}SEK = {yen}YEN");

        // Assigment 2
        // Console.Write("Enter rectange base: ");
        // int rectBase = Convert.ToInt32(Console.ReadLine()); 
        // Console.Write("Enter rectange height: ");
        // int rectHeight = Convert.ToInt32(Console.ReadLine()); 
        // WriteRectData(rectBase, rectHeight);

        // // Assigment 3
        // LucasNumber(10);

        // // Assigment 4
        // Power(4, 2);

        // Assigment 5
        string expression = "5 + 2";
        Console.WriteLine(Sum(expression));
    }

    static double ConvertSekToYen(int sek, double rate = 15.86) {
        return sek * rate;
    }

    static void WriteRectData(int rectBase, int rectHeight) {
        Console.WriteLine($"Area: {rectBase * rectHeight}");
        Console.WriteLine($"Circumference: {(rectBase + rectHeight) * 2}");
    }

    static void LucasNumber(int length, int numOne=2, int numTwo=1) {
        if (length <= 0) {
            return;
        }

        length -= 1;
        Console.WriteLine(numOne);
        Console.WriteLine(numTwo);
        int sum = numOne + numTwo;

        LucasNumber(length, sum, sum + numTwo);
    }

    static double Power(double baseValue, int exponent) {
        if (exponent == 0) {
            return 1;
        }

        if (exponent < 0) {
            return 1 / Power(baseValue, -exponent);
        }

        return baseValue * Power(baseValue, exponent - 1);
    }

    static int Sum(string input) {
        string[] components = input.Split("+"); 
        int sum = 0;

        foreach (string component in components) {
            if (component == "+") {
                continue;
            }

            sum += int.Parse(component);
        };

        return sum;
    }
}
