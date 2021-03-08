using System;
using System.Collections.Generic;
using System.Text;
using OyunSatisiDemo.Entities;
using MernisServiceReference;

namespace OyunSatisiDemo.Abstract
{
    public interface IOrderService
    {
        void OrderCustomer(Customer customer,CampaignGame campaignGame);
    }
}
