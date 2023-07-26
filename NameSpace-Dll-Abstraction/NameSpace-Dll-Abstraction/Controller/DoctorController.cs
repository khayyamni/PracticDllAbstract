using NameSpace_Dll_Abstraction.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpace_Dll_Abstraction.Controller
{
    internal class DoctorController
    {
        private DoctorService _doctorService;

        public DoctorController()
        {
            _doctorService = new DoctorService();
        }
        public void FilterByDate()
        {
            DateTime start = new DateTime(1992, 09, 04);

            DateTime end = new DateTime(2000, 09, 04);

            _doctorService.FilterByDate(start, end);
        }
    }
}
