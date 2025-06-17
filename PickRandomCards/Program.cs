using PickRandomCards;

class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Insira o numero de cartas que você quer pegar: ");
        string line = Console.ReadLine();


        if (int.TryParse(line, out int numberOfCards))
        {
            foreach (string card in CardPicker.PickSomeCards(numberOfCards))
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um numero valido.");
        }
    }
}