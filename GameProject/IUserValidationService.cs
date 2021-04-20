using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject //Soyut
{
    interface IUserValidationService //4
    {
        bool Validate(Gamer gamer);  //voidi bool yaptık çünkü true-false çalıştırmak istiyoruz
    }
}
