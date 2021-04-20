using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)    //IUserValidationService idi son eklediğimiz classı implemente ettiğimiz için MVS yaptık
        {
            GamerManager gamerManager = new GamerManager(new MernisValidationService());   
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1996, FirstName = "ÇAĞATAY", LastName = "KURTAY",IdentityNumber=1000000 });
        }
    }
}
