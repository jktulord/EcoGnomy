using System;
using System.Collections.Generic;
using System.Text;

namespace EcoGnomy
{
    class gnom
    {
        string[] names = new string[10] {"Jonatan","Joseph","Jotaro","Josuke","Giorno","Joseppe","Johnny","Jakob","Dio","Speedwagon" };

        public string name;
        public int age;
        public int money;
        public int hunger = 0;

        public gnom(string name, int age, int money)
        {
            this.name = name;
            this.age = age;
            this.money = money;
        }
    }
}
