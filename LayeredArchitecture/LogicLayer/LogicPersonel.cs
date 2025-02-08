using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> Lists()
        {
            return DALPersonel.PersonelList();

        }

        public static int ListPersonelAdd(EntityPersonel p)
        {
            if (p.Name != "" && p.LastName != "" && p.Salary<= 1000 && p.Name.Length >= 3)
            {
                    return DALPersonel.PersonelAdd(p);   
            }

            else
            {
                return -1;
            }
        }

        public static bool RemoveProcess(int per)
        {
            if (per>=1)
            {
               return  DALPersonel.PersonelRemove(per);
            }

            else
            {
                return false;
            }
        }

        public static bool UpPersonel(EntityPersonel per)
        {
            if(per.Name.Length >= 3 && per.Name != "" && per.Salary >1000)
            {
                return DALPersonel.UpdatePersonel(per);
            }

            else
            {
                return false;
            }
                
        }  
    }
}
