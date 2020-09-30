using System;
using System.Collections.Generic;
using System.Text;

namespace EcoGnomy
{
     
    public class town
    {
        static Random rnd = new Random();
        public int money = 100;
        List<gnom> gnoms = new List<gnom>();

        public town()
        {
            this.add_gnom(10);
            
        }

        public void print_gnoms()
        {
            foreach (gnom cur in gnoms){
                Console.WriteLine(cur.name+"-"+ cur.money+"$ hunger="+ cur.hunger);
            }
            
        }

        public void add_gnom(int n) 
        {
            int r = rnd.Next(gnoms.Count);
            gnoms.Add(new gnom("Josepe", 12, 5));
            if (n > 0)
            {
                this.add_gnom(n - 1);
            }
        }
        

    }
}
