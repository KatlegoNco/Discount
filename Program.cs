class Program
{
    static void Main()
    {
        //discount with user input
        Console.WriteLine("Enter the price of the item: ");
        //set price
        int price = int.Parse(Console.ReadLine());
        //set discount
        if (price > 1000 && price < 2000)
        {
            Console.WriteLine("Discounted price: " + (price - 100));
        }
        else if (price > 800 && price < 1000)
        {
            Console.WriteLine("Discounted price: " + (price - 80));
        }
        else if (price > 700 && price < 800)
        {
            Console.WriteLine("Discounted price: " + (price - 70));
        }
        else
        {
            Console.WriteLine("Discounted price: " + price);
        }

    }
}