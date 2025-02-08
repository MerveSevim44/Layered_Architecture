using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int? id;
        private string name;
        private string lastName;
        private string city;
        private string task;
        private int? salary;

        public int Id { get => id ?? 0; set => id = value ; } // Every one  is a property
        public string Name { get => name; set => name = value ?? string.Empty; }
        public string LastName { get => lastName; set => lastName = value ?? string.Empty; }
        public string City { get => city; set => city = value ?? string.Empty; }
        public string Task { get => task; set => task = value ?? string.Empty   ; }
        public int Salary { get => salary ?? 0; set => salary = value; }  //this struct is a encapsulation for all of column
    }
}
