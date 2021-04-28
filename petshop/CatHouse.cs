using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    class CatHouse
    {
        public Cat[] Cats { get; set; }
        public int CatCount { get; set; }

        public void ShowCats()

        {

            if (Cats != null)

            {

                foreach (var item in Cats)

                {

                    item.Show();

                }

            }

        }
        public void Calculate()
        {
            int totalprice = 0;
            int totaleat = 0;
            if (Cats != null)
            {
                foreach (var item in Cats)
                {
                    totalprice += item.Price;
                    totaleat += item.MealQuantity;
                }
            }
            Console.WriteLine(totalprice);
            Console.WriteLine(totaleat);
        }


        public void AddCat(ref Cat cat)

        {

            Cat[] temp = new Cat[++CatCount];

            if (Cats != null)

            {

                Cats.CopyTo(temp, 0);

            }

            temp[temp.Length - 1] = cat;

            Cats = temp;

        }

        public static int[] RemoveCat(int[] source, int index)
        {
            int[] destination = new int[source.Length - 1];
            if (index > 0)
            {
                Array.Copy(source, 0, destination, 0, index);
            }
            if (index < source.Length - 1)
            {
                Array.Copy(source, index + 1, destination, index, source.Length - index - 1);
            }
            return destination;
        }
    }
}
