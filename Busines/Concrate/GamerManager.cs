using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this._userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" Kayıtınız Gerçekleşti");
            }
            else
            {
                Console.WriteLine("Doğrulama Hatası :\n Kayıt Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıtınız Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıtınız Güncellendi");
        }
    }
}
