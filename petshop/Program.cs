using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    class Program
    {
        static void Main(string[] args)
        {
            CatHouse cats = new CatHouse();

            Cat c1 = new Cat("mestan1", 1, "woman", 10, 10, 3);
            cats.AddCat(ref c1);
            Cat c2 = new Cat("mestan2", 4, "woman", 20, 5, 5);
            cats.AddCat(ref c2);
            cats.ShowCats();











            for (int i = 0; i < 10; i++)

            {

                c1.Play();

                c2.Play();

            }

            for (int i = 0; i < 10; i++)

            {

                c1.Sleep();

                c2.Sleep();

            }

            for (int i = 0; i < 10; i++)

            {

                c1.Play();

                c2.Play();

            }
            PetShop ps = new PetShop();
            ps.AddCatHouse(ref cats);
            ps.ShowHouses();


        }
    }
}
