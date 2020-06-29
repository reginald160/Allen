using CodeBitesAcademyEFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitesAcademyEFC.User
{
    public class UserRepo : Iuser
    {
        
        private readonly DataContext _dataContext;
        public UserRepo(DataContext _context) => _dataContext = _context;

        public void AddUser(Account user)
        {
            _dataContext.SystemUserTabl.Add(user);
            _dataContext.SaveChanges();
        }

        public Account Delete(int Id)
        {
            Account user = _dataContext.SystemUserTabl.Find(Id);

            if (user != null)
            {
                _dataContext.SystemUserTabl.Remove(user);
                _dataContext.SaveChanges();
            }
            return user;
        }

        public void Edit(Account user)
        {

            _dataContext.Update(user);
            _dataContext.SaveChanges();
        }


        public  bool Authentification (string username, string password)
        {
            var pass = _dataContext.SystemUserTabl.Where(T => T.Username == username && T.Password == password);
            if (pass.Count() > 0)
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
