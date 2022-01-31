using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{
    internal class CatalogService
    {
        public bool AvailabilityProductInCatalog(Product[] catalog, int index)
        {
            if (catalog[index].Quantity > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("К сожалению данного товара нет в наличии((");
                return false;
            }
        }

        public bool AvailabilityProductInCatalog(Product[] catalog, int index, int quantity)
        {
            if (catalog[index].Quantity >= quantity)
            {
                return true;
            }

            Console.WriteLine($"К сожалению данного товара нет в количестве {quantity}шт. Доступно {catalog[index].Quantity}");
            return false;
        }

        public void GetFromCatalog(Product[] catalog, int index, int quantity)
        {
            catalog[index].Quantity -= quantity;
        }

        public void CatalogOutput(Product[] catalog)
        {
            for (int i = 0; i < catalog.Length; i++)
            {
                Console.WriteLine($"N:{i + 1}  Название:{catalog[i].Name}  Цена:{catalog[i].Price}  Количество:{catalog[i].Quantity}");
            }
        }
    }
}
