using System;
using OyunSatisiDemo.Entities;
using OyunSatisiDemo.Abstract;
using OyunSatisiDemo.Concrete;
using MernisServiceReference;
using OyunSatisiDemo.Adapters;

namespace OyunSatisiDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.id = 1;
            customer1.FirstName = "Yusuf";
            customer1.LastName = "KOÇAK";
            customer1.BirthYear = 1997;
            customer1.NationalityId =11111111111;

            CustomerManager customermanager = new CustomerManager(new MernisServiceAdapter());
            customermanager.Add(customer1);

            Console.WriteLine();

            CampaignGame campaignGame1 = new CampaignGame() {Id=1,CampaignName="Büyük Şubat İndirimi",
                CampaignDetails="%50 ye varan indirimler,seni bekler ;)",
                CampaignGameName="GTA 5",CampaignGamePrice=30};

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaignGame1);

            Console.WriteLine();


            OrderManager order1 = new OrderManager();
            order1.OrderCustomer(customer1, campaignGame1);

            Console.ReadLine();


        }
    }
}
