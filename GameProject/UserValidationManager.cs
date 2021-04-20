using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject  //Somut
{
    class UserValidationManager : IUserValidationService       //5
    {
        public bool Validate(Gamer gamer) //void bool yapılır
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName == "ÇAĞATAY"&& gamer.LastName =="KURTAY" && gamer.IdentityNumber == 1000000 && gamer.Id==1 )
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
