using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

        public Order Retrive(int id)
        {
            Order order = new Order(id);

            if (order.OrderId == 2)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 7, 13, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        public bool Save (int id)
        {
            return true;
        }
    }
}
