using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_regstration_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surename;
            string email;
            string phonenumber;
            int select;
            void EnterUserInfo()
            {
                Console.WriteLine("Enter your name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter your surename : ");
                surename = Console.ReadLine();
                Console.WriteLine("Enter your email : ");
                email = Console.ReadLine();
                Console.WriteLine("Enter your phone number : ");
                phonenumber = Console.ReadLine();
            }
            void ChooseDepartment()
            {
                Console.WriteLine("1)Pediatrea");
                Console.WriteLine("2)Traumatalogy");
                Console.WriteLine("3)Dentistry");
                select = int.Parse(Console.ReadLine());
            }
            Doctor doctor = new Doctor()
            {
                Name = "Tural",
                Surename = "Tahirli",
                WorkExperience = 20,
                Rt = new List<ReservationTimes>
                 {
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 9, 0, 0),
                     End = new DateTime(2021, 05, 22, 11, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 12, 0, 0),
                     End = new DateTime(2021, 05, 22, 14, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 15, 0, 0),
                     End = new DateTime(2021, 05, 22, 17, 0, 0),
                     isFull = false
                 }

                 }

            };
            Doctor doctor1 = new Doctor()
            {
                Name = "Elvin",
                Surename = "Camalzade",
                WorkExperience = 10,
                Rt = new List<ReservationTimes>
                 {
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 9, 0, 0),
                     End = new DateTime(2021, 05, 22, 11, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 12, 0, 0),
                     End = new DateTime(2021, 05, 22, 14, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 15, 0, 0),
                     End = new DateTime(2021, 05, 22, 17, 0, 0),
                     isFull = false
                 }

                 }
            };
            Doctor doctor2 = new Doctor()
            {
                Name = "Cavid",
                Surename = "Mahsunov",
                WorkExperience = 15,
                Rt = new List<ReservationTimes>
                 {
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 9, 0, 0),
                     End = new DateTime(2021, 05, 22, 11, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 12, 0, 0),
                     End = new DateTime(2021, 05, 22, 14, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 15, 0, 0),
                     End = new DateTime(2021, 05, 22, 17, 0, 0),
                     isFull = false
                 }

                 }
            };
            Doctor doctor3 = new Doctor()
            {
                Name = "Murad",
                Surename = "Sadixli",
                WorkExperience = 20,
                Rt = new List<ReservationTimes>
                 {
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 9, 0, 0),
                     End = new DateTime(2021, 05, 22, 11, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 12, 0, 0),
                     End = new DateTime(2021, 05, 22, 14, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 15, 0, 0),
                     End = new DateTime(2021, 05, 22, 17, 0, 0),
                     isFull = false
                 }

                 }
            };
            Doctor doctor4 = new Doctor()
            {
                Name = "Ibadzade",
                Surename = "Eli",
                WorkExperience = 25,
                Rt = new List<ReservationTimes>
                 {
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 9, 0, 0),
                     End = new DateTime(2021, 05, 22, 11, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 12, 0, 0),
                     End = new DateTime(2021, 05, 22, 14, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 15, 0, 0),
                     End = new DateTime(2021, 05, 22, 17, 0, 0),
                     isFull = false
                 }

                 }
            };
            Doctor doctor5 = new Doctor()
            {
                Name = "Elxan",
                Surename = "Atayev",
                WorkExperience = 30,
                Rt = new List<ReservationTimes>
                 {
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 9, 0, 0),
                     End = new DateTime(2021, 05, 22, 11, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 12, 0, 0),
                     End = new DateTime(2021, 05, 22, 14, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 15, 0, 0),
                     End = new DateTime(2021, 05, 22, 17, 0, 0),
                     isFull = false
                 }

                 }
            };
            Doctor doctor6 = new Doctor()
            {
                Name = "Jhon",
                Surename = "Jhonlu",
                WorkExperience = 35,
                Rt = new List<ReservationTimes>
                 {
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 9, 0, 0),
                     End = new DateTime(2021, 05, 22, 11, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 12, 0, 0),
                     End = new DateTime(2021, 05, 22, 14, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 15, 0, 0),
                     End = new DateTime(2021, 05, 22, 17, 0, 0),
                     isFull = false
                 }

                 }
            };
            Doctor doctor7 = new Doctor()
            {
                Name = "Ulfet",
                Surename = "Babayev",
                WorkExperience = 40,
                Rt = new List<ReservationTimes>
                 {
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 9, 0, 0),
                     End = new DateTime(2021, 05, 22, 11, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 12, 0, 0),
                     End = new DateTime(2021, 05, 22, 14, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 15, 0, 0),
                     End = new DateTime(2021, 05, 22, 17, 0, 0),
                     isFull = false
                 }

                 }
            };
            Doctor doctor8 = new Doctor()
            {
                Name = "James",
                Surename = "James",
                WorkExperience = 45,
                Rt = new List<ReservationTimes>
                 {
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 9, 0, 0),
                     End = new DateTime(2021, 05, 22, 11, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 12, 0, 0),
                     End = new DateTime(2021, 05, 22, 14, 0, 0),
                     isFull = false
                 },
                 new ReservationTimes
                 {
                     Start = new DateTime(2021, 05, 22, 15, 0, 0),
                     End = new DateTime(2021, 05, 22, 17, 0, 0),
                     isFull = false
                 }

                 }
            };
            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(doctor);
            doctors.Add(doctor1);
            doctors.Add(doctor2);
            Pediatrea pediatreas = new Pediatrea()
            {
                Doctors = doctors
            };
            List<Doctor> doctors1 = new List<Doctor>();
            doctors1.Add(doctor3);
            doctors1.Add(doctor4);
            Traumatology traumatologes = new Traumatology()
            {
                Doctors = doctors1
            };
            List<Doctor> doctors2 = new List<Doctor>();
            doctors2.Add(doctor5);
            doctors2.Add(doctor6);
            doctors2.Add(doctor7);
            doctors2.Add(doctor8);
            Dentistry dentistres = new Dentistry()
            {
                Doctors = doctors2
            };

            void Menu()
            {
                Console.ForegroundColor = ConsoleColor.White;
                EnterUserInfo();
                User user = new User()
                {
                    Name = name,
                    Surename = surename,
                    Email = email,
                    PhoneNumber = phonenumber
                };
                ChooseDepartment();
                if (select == 1)
                {
                    ShowDoctors.ShowPediatreaDoctors(pediatreas);
                    Console.WriteLine("Choose doctor : ");
                    int choose = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Your doctor {doctors[choose - 1].Name}");
                    ShowDoctors.ShowReservationTimes(doctors[choose - 1].Rt);
                    int reservetimes = int.Parse(Console.ReadLine());
                    if (doctors[choose - 1].Reserv(reservetimes, user.Name))
                    {
                        Console.WriteLine($"Hormetli {user.Name}  siz {doctors[choose - 1].Rt[reservetimes - 1].Start} saatinda {doctors[choose - 1].Name } hekimin qebuluna yazildiniz!");
                    }
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    JsonF.JsonSerializer(doctors[choose-1].Rt);
                    Menu();
                }
                else if (select == 2)
                {
                    ShowDoctors.ShowTraumatologyDoctors(traumatologes);
                    Console.WriteLine("Choose doctor : ");
                    int choose = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Your doctor {doctors1[choose - 1].Name}");
                    ShowDoctors.ShowReservationTimes(doctors1[choose - 1].Rt);
                    int reservetimes = int.Parse(Console.ReadLine());
                    if (doctors1[choose - 1].Reserv(reservetimes, user.Name))
                    {
                        Console.WriteLine($"Hormetli {user.Name}  siz {doctors1[choose - 1].Rt[reservetimes - 1].Start} saatinda {doctors1[choose - 1].Name } hekimin qebuluna yazildiniz!");
                    }
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    JsonF.JsonSerializer(doctors1[choose-1].Rt);
                    Menu();
                }
                else if (select == 3)
                {
                    ShowDoctors.ShowDentistryDoctors(dentistres);
                    Console.WriteLine("Choose doctor : ");
                    int choose = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Your doctor {doctors2[choose - 1].Name}");
                    ShowDoctors.ShowReservationTimes(doctors2[choose - 1].Rt);
                    int reservetimes = int.Parse(Console.ReadLine());
                    if (doctors2[choose - 1].Reserv(reservetimes, user.Name))
                    {
                        Console.WriteLine($"Hormetli {user.Name}  siz {doctors2[choose - 1].Rt[reservetimes - 1].Start} saatinda {doctors2[choose - 1].Name } hekimin qebuluna yazildiniz!");
                    }
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    JsonF.JsonSerializer(doctors2[choose-1].Rt);
                    Menu();
                }
            }
            Menu();

        }
    }
}
