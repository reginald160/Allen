using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;


namespace Allen.Models
{
    public class DBcontext
    {
        public States States { get; set; }
        public Outlets Outlets { get; set; }

        public List<States> dbStates()
        {
            return new List<States>()
            {
                new States(){ StateId =1,  StateName= "Abia",},
                  new States(){ StateId =1,  StateName= "Enugu",},
                    new States(){ StateId =1,  StateName= "Abuja",},
                      new States(){ StateId =1,  StateName= "Lagos",},
                        new States(){ StateId =1,  StateName= "Owerri",}
            };
        }

        public List<Outlets> dbOutlets()
        {
            return new List<Outlets>()
            {
                new Outlets (){ Id = new States () { StateId=1}, Address = "Ziks Avenue",},
                new Outlets  (){ Id = new States () { StateId=1},   Address= "Okpara Avenue",},
                new Outlets  (){ Id = new States () { StateId=2},  Address= "Achala Layou",},
                new Outlets (){ Id = new States () { StateId=2},   Address= "New Heaven",},
                new Outlets (){ Id = new States () { StateId=3}, Address= "Abakpa",},

            };
        }


        public List<States> GetAllStates()
        {
            return dbStates();
        }

        public List<Outlets> GetAllOutLets()
        {
            return dbOutlets();
        }
    }
}
