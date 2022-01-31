using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{
    internal class OrderService
    {
        public void AddToOrder(Product[] order, Product product, int quantity)
        {
            int index = Array.IndexOf(order, null);
            order[index] = new Product(product.Name, product.Price, quantity);
            Console.WriteLine($"Ваш товар {order[index].Name} добавлен в корзину в количестве {order[index].Quantity} шт.");
        }

        public void OrderOutput(Product[] order)
        {
            var sum = 0;
            Console.WriteLine("Ваш заказ :");
            int orderSize = Array.IndexOf(order, null);
            for (int i = 0; i < orderSize; i++)
            {
                Console.WriteLine($"Товар : {order[i].Name} в количестве {order[i].Quantity} по цене {order[i].Price}шт.");
                sum += order[i].Quantity * order[i].Price;
            }

            Console.WriteLine($"Итоговая сумма: {sum}$");
        }
    }
}
