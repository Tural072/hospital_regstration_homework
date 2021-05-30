using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_regstration_homework
{
    abstract class Human
    {
        public string Name { get; set; }
        public string Surename { get; set; }
        public override string ToString()
        {
            return $@"Name : {Name} 
Surename : {Surename}";
        }
    }
}
