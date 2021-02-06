using Busines.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrate
{
    public class GameManager : IGameService
    {
        public void GameAdd(Game game)
        {
            Console.WriteLine(game.GameName+" Adlı oyun Eklendi");
        }

        public void GameDelete(Game game)
        {
            Console.WriteLine(game.GameName+" Adlı oyun silindi");
        }

        public void GameUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
