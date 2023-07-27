using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umed_Alif_Academy_Day_9_HW_9
{
    public readonly struct ClientInfo
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }

        public ClientInfo(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
