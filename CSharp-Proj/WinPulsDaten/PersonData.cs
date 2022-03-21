using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPulsDaten
{
    struct PersonData
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Password { get; private set; }
        public string ConfPassword { get; private set; }
        public float Wight { get; private set; }
        public float Size { get; private set; }
        public string Gender { get; private set; }
        public DateTime Age { get; private set; }
        public float HpMax { get; private set; }

        public PersonData(string firstname, string lastname, string password, string confPassword, float wight, float size, string gender, DateTime age, float hpMax)
        {
            Firstname = firstname;
            Lastname = lastname;
            Password = password;
            ConfPassword = confPassword;
            Wight = wight;
            Size = size;
            Gender = gender;
            Age = age;
            HpMax = hpMax;
        }
    }
}
