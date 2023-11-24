using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart) 
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            order.orderDetails = new List<OrderDetail>();
            appDBContent.Order.Add(order);
            var items = shopCart.listShopItems;
           
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarID = el.car.Id,
                    orderID = order.id,
                    price = el.car.Price
                };
                order.orderDetails.Add(orderDetail);
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
