using System;

namespace EcoGnomy
{
    class Program
    {
        static void Main(string[] args)
        {
            town mytown = new town();
            while (true)
            {

                string word = Console.ReadLine();
                if (word == "print") { mytown.print_gnoms(); }
            }
        }
    }
}
