using System;
using System.Collections.Generic;
using System.Text;
using OyunSatisiDemo.Abstract;
using OyunSatisiDemo.Entities;
using MernisServiceReference;

namespace OyunSatisiDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(CampaignGame campaign)
        {
            Console.WriteLine("Kampanya Ekleme işlemi tamamlandı");
        }

        public void Delete(CampaignGame campaign)
        {
            Console.WriteLine("Kampanya silme işlemi tamamlandı");
        }

        public void Update(CampaignGame campaign)
        {
            Console.WriteLine("Kampanya güncelleme işlemi tamamlandı");
        }
    }
}
