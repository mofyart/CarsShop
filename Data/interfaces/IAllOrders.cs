using Site_1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site_1.Data.interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
