using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_regstration_homework
{
    class ReservationTimes
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool isFull { get; set; }
        public override string ToString()
        {
            if (isFull == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return $"Start time : {Start.ToLongTimeString()} End time : {End.ToLongTimeString()} Availability : Busy";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return $"Start time : {Start.ToLongTimeString()} End time : {End.ToLongTimeString()} Availability : Available";
            }
        }
    }
}
