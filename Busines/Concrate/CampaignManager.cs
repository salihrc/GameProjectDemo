using Busines.Abstract;
using Entities.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrate
{
    

    public class CampaignManager : ICampaignService
    {
        
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"Kampanyası Eklendi");
        }

        public void CampaignDelete(Campaign campaign,Game game)
        {
            Console.WriteLine(campaign.CampaignName+"Kampanyası Silindi"+game.GameName+"'in Fiyatı:\n"+game.UnitPrice);
        }

        public void CampaignUpdate(Campaign campaign1,Campaign campaign2)
        {
           
            Console.Write("Kampanya Güncellendi"+campaign1.CampaignName+"Kampanyası Artık:");
            campaign1 = campaign2;
            Console.WriteLine(campaign1.CampaignName + "Kampanyasına Dönüştü Yeni Fiyat:\n" + campaign1.CampaignPrice);
        }
    }
}
