using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_regstration_homework
{
    class User:Human
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return $"Email : {Email} Phone number : {PhoneNumber}";
        }
    }
}
