using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService  //3
    {
        IUserValidationService userValidationService;
      IUserValidationService _userValidationService;   //ınjection 

        public GamerManager(IUserValidationService userValidationService) //GamerManagerin içinde bir soyut doğrulama var demektir bu kod blogu
        {
            _userValidationService = userValidationService;
        }



        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)    //Constructor--- new dediğimiz zaman çalışan yapılardır.Programcs de new diyoruz
            {
                Console.WriteLine("Kayıt olundu");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız");
            }

        }

        public void Delete(Gamer gamer)
        {
          Console.WriteLine("Kayıt Silindi");
         }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
