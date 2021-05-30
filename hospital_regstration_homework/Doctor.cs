using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_regstration_homework
{
    class Doctor : Human
    {
        public List<ReservationTimes> Rt { get; set; }
        public int WorkExperience { get; set; }
        public override string ToString()
        {
            return $@"{base.ToString()}  
Work experience : {WorkExperience} 
";
        }
        public bool Reserv(int index, string name)
        {
            if (Rt[index - 1].isFull == false)
            {
                
                Rt[index - 1].isFull = true;
                Rt[index - 1].Name = name;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This time is busy");
                return false;
            }
    }
        }
}
