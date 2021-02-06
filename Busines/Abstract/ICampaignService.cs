using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface ICampaignService
    {
        void CampaignAdd(Campaign campaign);
        void CampaignUpdate(Campaign campaign1,Campaign campaign2);
        void CampaignDelete(Campaign campaign,Game game);
    }
}
