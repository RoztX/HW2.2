using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{
    internal class Order
    {
        private Product[] _order = new Product[10];
        public Product[] OrderArray
        {
            get { return _order; }
            set { _order = value; }
        }
    }
}
