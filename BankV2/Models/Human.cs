using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankV2.Models
{
    abstract public class Human
    {
        public string FirstName { get; set; } 
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
