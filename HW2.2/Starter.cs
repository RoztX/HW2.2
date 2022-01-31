using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{
    internal class Starter
    {
        private readonly Catalog _сatalog;
        private readonly Order _order;
        private readonly CatalogService _catalogService;
        private readonly OrderService _orderService;

        public Starter()
        {
            _сatalog = new Catalog();
            _order = new Order();
            _orderService = new OrderService();
            _catalogService = new CatalogService();
        }

        public void Run()
        {
            bool continueShopping = true;
            while (continueShopping)
            {
                _catalogService.CatalogOutput(_сatalog.CatalogArray);
                Console.WriteLine("Введите номер интересующего вас товара: ");
                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                if (_catalogService.AvailabilityProductInCatalog(_сatalog.CatalogArray, index))
                {
                    Console.WriteLine("Укажите нужное количество данного товара :");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    if (_catalogService.AvailabilityProductInCatalog(_сatalog.CatalogArray, index, quantity))
                    {
                        _catalogService.GetFromCatalog(_сatalog.CatalogArray, index, quantity);
                        _orderService.AddToOrder(_order.OrderArray, _сatalog.CatalogArray[index], quantity);
                    }
                }

                Console.WriteLine("Продолжить покупки ?(y/n)");
                var permission = Console.ReadLine().ToLower();
                while (permission != "y" && permission != "n")
                {
                    Console.WriteLine("Введено неизвестное значение. Введите пожалуйста \"Y\"  \"N\"");
                    permission = Console.ReadLine().ToLower();
                }

                if (permission == "n")
                {
                    continueShopping = false;
                }
            }

            _orderService.OrderOutput(_order.OrderArray);
        }
    }
}
