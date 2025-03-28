using System;

public class Program {
    
 
    
    
    private static readonly int[] romanValues = new int[22];

    static Program()
    {
        romanValues['I' - 'C'] = 1;
        romanValues['V' - 'C'] = 5;
        romanValues['X' - 'C'] = 10;
        romanValues['L' - 'C'] = 50;
        romanValues['C' - 'C'] = 100;
        romanValues['D' - 'C'] = 500;
        romanValues['M' - 'C'] = 1000;
    }

    public int RomanToInt(string s) {
        int sum = 0, previousValue = 0;

        for (int i = s.Length - 1; i >= 0; i--) {
            int currentValue = romanValues[s[i] - 'C'];

            sum += (currentValue < previousValue) ? -currentValue : currentValue;

            previousValue = currentValue;
        }

        return sum;
    }

    public static void Main1()
    {
        Program solution = new Program();

        // Example 1: III = 3
        Console.WriteLine($"III = {solution.RomanToInt("III")}");

        // Example 2: LVIII = 58
        Console.WriteLine($"LVIII = {solution.RomanToInt("LVIII")}");

        // Example 3: MCMXCIV = 1994
        Console.WriteLine($"MCMXCIV = {solution.RomanToInt("MCMXCIV")}");
    }

}


