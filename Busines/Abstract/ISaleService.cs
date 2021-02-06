using Busines.Concrate;
using Entities.Concrate;
using GameProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface ISaleService
    {
        void SaleGame(Gamer gamer,Game game);
        void ApplyCampaign(Game game,Campaign campaign);
    }
}
