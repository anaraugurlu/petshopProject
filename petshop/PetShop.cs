using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    class PetShop
    {
        public CatHouse[] CatHouses { get; set; }
        public int CatHouseCount { get; set; }
        public void AddCatHouse(ref CatHouse cathouse)

        {

            CatHouse[] temp = new CatHouse[++CatHouseCount];

            if (CatHouses != null)

            {

                CatHouses.CopyTo(temp, 0);

            }

            temp[temp.Length - 1] = cathouse;

            CatHouses = temp;

        }
        public static int[] RemoveHouse(int[] source, int index)
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
        public void ShowHouses()

        {

            if (CatHouses != null)

            {

                foreach (var item in CatHouses)

                {

                    item.ShowCats();

                }

            }

        }
    }
}
