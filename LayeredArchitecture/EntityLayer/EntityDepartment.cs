using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDepartment
    {
        private int Id; 
        private string name;
        private string description;

        public int Id1 { get => Id; set => Id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
