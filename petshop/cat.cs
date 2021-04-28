using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    class Cat
    {
        public string Nickname { get; set; }
        public int Age { get; set; } = 0;
        public string Gender { get; set; }
        public int Energy { get; set; } = 100;
        public int Price { get; set; }
        public int MealQuantity { get; set; }
        public Cat(string nickname, int age, string gender, int energy, int price, int mealquantity)
        {
            Age = age;
            Nickname = nickname;
            Gender = gender;
            Energy = energy;
            Price = price;
            MealQuantity = mealquantity;


        }
        public void Sleep()

        {

            Energy += 30;

        }

        public void Play()

        {

            if (Energy > 0)

            {

                Price += 3;

                Energy -= 3;



            }

            else

            {

                Energy = 0;

            }

        }
        public void Eat()
        {
            Energy += 10;
            Price += 5;
        }
        public void Show()

        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine($"age {Age}");
            Console.WriteLine($"Nickname {Nickname}");
            Console.WriteLine($"Energy {Energy}");
            Console.WriteLine($"Gender {Gender}");
            Console.WriteLine($"Price{Price}");

        }
    }
}
