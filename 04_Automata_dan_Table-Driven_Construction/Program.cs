using _04_Automata_dan_Table_Driven_Construction;
class Program
{
    static void Main()
    {
        FruitCodes fruitCodes = new FruitCodes();
        Console.WriteLine("Enter fruit name:");
        var userInput = Console.ReadLine();
        Console.WriteLine(fruitCodes.GetFruitCode(userInput));
        Console.ReadKey();
    }
}
