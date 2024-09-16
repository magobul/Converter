using peregruzka;

class Program
{
    static void Main()
    {
        Overload converter = new Overload();

        converter.Convert("123", out int intResult);
        Console.WriteLine($"Конвертация в int: {intResult}");

        converter.Convert("123.45", out double doubleResult); ;
        Console.WriteLine($"Конвертация в double: {doubleResult}");

        converter.Convert("true", out bool boolResult);
        Console.WriteLine($"Конвертация в bool: {boolResult}");
    }
}