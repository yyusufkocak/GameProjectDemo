using OyunSatisiDemo.Concrete;
using OyunSatisiDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace OyunSatisiDemo.Abstract
{
   public interface ICampaignService
    {
        void Add(CampaignGame campaign);
        void Delete(CampaignGame campaign);
        void Update(CampaignGame campaign);
    }
}
