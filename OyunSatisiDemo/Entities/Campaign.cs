using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace OyunSatisiDemo.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDetails { get; set; }
    }

  public class CampaignGame :Campaign   //inherit
    {
        public string CampaignGameName { get; set; }    //Kampanyaya Dahil Olan Oyunun Adı
        public int CampaignGamePrice { get; set; }      //Fiyat

    }
}
