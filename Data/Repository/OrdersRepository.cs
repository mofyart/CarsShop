using Site_1.Data.interfaces;
using Site_1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site_1.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDbContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDbContent, ShopCart shopCart)
        {
            this.appDbContent = appDbContent;
            this.shopCart = shopCart;
        }


        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDbContent.Order.Add(order);
            appDbContent.SaveChanges();

            var items = shopCart.listShopItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarID = el.car.id,
                    orderID = order.id,
                    price = el.car.price
                };
                appDbContent.OrderDetail.Add(orderDetail);
            }
            appDbContent.SaveChanges();
        }
    }
}
