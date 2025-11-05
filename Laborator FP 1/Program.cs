Console.WriteLine("Introduceti numerele:");

    string input=Console.ReadLine();
string[] parts = input.Split(' ');
int[] numereleintroduse = Array.ConvertAll(parts, int.Parse);

foreach (int numar in numereleintroduse)
{
    if (numar % 2 == 0)
    {
        Console.WriteLine($"Numerele pare sunt: {numar}");

    }

}



