using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_regstration_homework
{
    class ShowDoctors
    {
        public static void ShowPediatreaDoctors(Pediatrea pediatrea)
        {
            for (int i = 0; i < pediatrea.Doctors.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {pediatrea.Doctors[i]}");
            }
        }
        public static void ShowDentistryDoctors(Dentistry dentistry)
        {
            for (int i = 0; i < dentistry.Doctors.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {dentistry.Doctors[i]}");
            }
        }
        public static void ShowTraumatologyDoctors(Traumatology traumatology)
        {
            for (int i = 0; i < traumatology.Doctors.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {traumatology.Doctors[i]}");
            }
        }
        public static void ShowReservationTimes(List<ReservationTimes> reservationTimes)
        {
            for (int i = 0; i < reservationTimes.Count; i++)
            {
                Console.WriteLine($"{i+1}) {reservationTimes[i]}");
            }
        }
    }
}
