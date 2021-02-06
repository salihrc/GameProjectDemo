using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IGameService
    {
        void GameAdd(Game game);
        void GameDelete(Game game);
        void GameUpdate();
    }
}
