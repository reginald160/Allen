using CodeBitesAcademyEFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitesAcademyEFC.User
{
   public interface Iuser
    {
      public  bool Authentification(string _username, string _password);

        public void AddUser(Account user);

        public Account Delete(int id);

        void Edit(Account user);
        
    }
}
