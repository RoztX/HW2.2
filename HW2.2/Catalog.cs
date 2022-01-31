using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{
    internal class Catalog
    {
        private Product[] _catalog = new Product[]
        {
        new Product("Сникерс ", 23, 100),
        new Product("Твикс   ", 12, 100),
        new Product("Марс    ", 14, 100),
        new Product("КитКат  ", 18, 100),
        new Product("Баунти  ", 28, 100),
        new Product("Натс    ", 37, 100),
        new Product("МилкиВэй", 10, 100),
        new Product("Милка   ", 47, 100),
        new Product("Корона  ", 12, 100)
        };

        public Product[] CatalogArray
        {
            get { return _catalog; }
            set { _catalog = value; }
        }
    }
}
