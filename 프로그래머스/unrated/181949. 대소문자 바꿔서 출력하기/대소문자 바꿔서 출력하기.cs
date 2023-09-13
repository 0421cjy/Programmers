using System;

public class Example
{
    public static void Main()
    {
        String s;
        String result = "";

        Console.Clear();
        s = Console.ReadLine();

        foreach(var c in s)
        {
            if (char.IsLower(c))
            {
                result += char.ToUpper(c);
            }
            else
            {
                result += char.ToLower(c);
            }
        }
        
        Console.WriteLine(result);
    }
}