using NameSpace_Dll_Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpace_Dll_Abstraction.Services
{
    internal class DoctorService
    {
        public void FilterByDate(DateTime start, DateTime end)
        {
            var doctors = GetDoctors();

            foreach (Doctor doctor in doctors)
            {
                if (doctor.Birthday > start && doctor.Birthday < end)
                {
                    string result = $"{doctor.Id} , {doctor.Name} , {doctor.Surname} , {doctor.Adress} , {DateTime.Now.Year - doctor.Birthday.Year}";
                    Console.WriteLine(result);
                }
            }

        }
        private Doctor[] GetDoctors()
        {
            Doctor[] Doctors =
            {
                new Doctor
                {
                    Id = 1,
                    Name = "Fidan",
                    Surname = "Beshirova",
                    Adress = "Hezi Aslanov",
                    Birthday = new DateTime(2001, 06, 08)

                },
                new Doctor
                {Id = 2,
                    Name = "Pervin",
                    Surname = "Mirzeyev",
                    Adress = "Bileceri",
                    Birthday = new DateTime(1993, 02, 09)
                },
                new Doctor
                {
                    Id = 3,
                    Name = "Sheref",
                    Surname = "Tenzilli",
                    Adress = "Papanin",
                    Birthday = new DateTime(1997, 09, 04)
                },
                 new Doctor
                {
                    Id = 4,
                    Name = "Cahangir",
                    Surname = "Axundov",
                    Adress = "Xetai",
                    Birthday = new DateTime(2002, 10 , 10),
                },
            };

            return Doctors;
        }

    }
}
