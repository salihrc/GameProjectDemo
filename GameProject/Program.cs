using Busines.Concrate;
using Entities.Concrate;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.BirthYear = 1985;
            gamer1.FirstName = "Kocakafa";
            gamer1.LastName = "Gınepıgpasa";
            gamer1.IdentityNumber = 12345;
            gamer1.GamerMoney = 1000000;
            Game game1 =new Game();
            game1.Id = 1;
            game1.GameName = "Gınepıglerin En Sevdiği Oyun";
            game1.UnitPrice = 10000;
            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "2020 de olanların kampanyası";
            campaign1.CampaignPrice =123;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "Kocakafa",
                LastName="Gınepıgpasa",
                IdentityNumber=12345,
                GamerMoney=1000000
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignAdd(new Campaign
            {
                Id = 1,
                CampaignName = "2020 de olanların Kampanyası",
                CampaignPrice = 123
            });
            GameManager gameManager = new GameManager();
            gameManager.GameAdd(new Game 
            {
                Id=1,
                GameName="Gınepıglerin En Sevdiği Oyun",
                UnitPrice=10000
            });
            SaleManager saleManager = new SaleManager();
            saleManager.ApplyCampaign(game1,campaign1);
            saleManager.SaleGame(gamer1,game1);

        }
    }
}
