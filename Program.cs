namespace vizgözjeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adja meg a víz hőmérsékletét: ");
            int h = int.Parse(Console.ReadLine());
            if (h <= 0)
            {
                Console.WriteLine("A víz jéggé fagyott");
            }
            else if (0 < h & h < 100)
            {
                Console.WriteLine("A víz folyékony");
            }
            else if (h >= 100)
            {
                Console.WriteLine("A vízből gőz lett");
            }
        }
    }
}
