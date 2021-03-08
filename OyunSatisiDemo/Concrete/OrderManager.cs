using OyunSatisiDemo.Abstract;
using OyunSatisiDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace OyunSatisiDemo.Concrete
{
    public class OrderManager : IOrderService
    {
        public void OrderCustomer(Customer customer, CampaignGame campaignGame)
        {
            Console.WriteLine(customer.FirstName+ " isimli müşteri "
                +campaignGame.CampaignName+" kampanyasından faydalanarak "
              +campaignGame.CampaignGameName+" ürününü aldı.");
        }
    }
}
