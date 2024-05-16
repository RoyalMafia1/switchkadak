namespace switchkadak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int num = 0;
            switch (num)
            {
                case 1:
                    Console.WriteLine("arvo kadak vaga zesty ja gey");
                    break;
                case 2:
                    Console.WriteLine("arvo kadak soob sulti enda vanaema keldris");
                    break;
                case 3:
                    Console.WriteLine("arvo kadak likes grandparent succ");
                    break;
                default:
                    Console.WriteLine("arvo kadak is not valid");
                    break;
            }
        }

    }
}
