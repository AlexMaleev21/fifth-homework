namespace dz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Play play = new Play("Play Name", "Author Initials", "Genre", "Year");
            play.PrintInfo();
            GC.Collect();
            Console.Read();

            Console.WriteLine();

            Shop shop = new Shop("Shop Name", "Shop Adress", "Shop Type");
            using(shop)
            {
                shop.ShowInfo();
            }
        }
    }
}
