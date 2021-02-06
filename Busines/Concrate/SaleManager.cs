using Busines.Abstract;
using Entities.Concrate;
using GameProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrate
{
    public class SaleManager : ISaleService
    {
        decimal Sale = 0;
        decimal Campaign = 0;
        public void ApplyCampaign(Game game, Campaign campaign)
        {
            Campaign= game.UnitPrice-campaign.CampaignPrice ;
            game.UnitPrice = Campaign;
            Console.WriteLine(game.GameName+" Adlı Oyununda "+campaign.CampaignName + " Kampanyası Mevcut " + game.GameName + "'in Yeni Fiyatı:\n" + game.UnitPrice); 
        }

        public void SaleGame(Gamer gamer, Game game)
        {
            Sale = gamer.GamerMoney - game.UnitPrice;
            gamer.GamerMoney = Sale;
            Console.WriteLine(" Satın alma işlemi gerçekleştirildi Kalan paranız:\n"+gamer.GamerMoney);
            
        }
    }
}


