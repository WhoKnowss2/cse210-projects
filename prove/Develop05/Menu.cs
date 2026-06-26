public class Menu
{
    private List<string> _options;

    public Menu()
    {
        _options = new List<string>
        {
            "Create New Goal",
            "List Goals",
            "Save Goals",
            "Load Goals",
            "Record Event",
            "Quit"
        };
    }

    public void DisplayMenu()
    {
        Console.WriteLine("==== Menu Options ====");
        Console.WriteLine();

        for (int i = 0; i < _options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_options[i]}");
        }
    }

    public int GetChoice()
    {
        int choice;

        Console.Write("Select a choice from the menu: ");

        while (!int.TryParse(Console.ReadLine(), out choice) ||
               choice < 1 || choice > _options.Count)
        {
            Console.WriteLine($"Please enter a number between 1 and {_options.Count}.");
            Console.Write("Select a choice from the menu: ");
        }

        return choice;
    }
}