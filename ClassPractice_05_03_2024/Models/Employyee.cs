using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_05_03_2024.Models
{
    public class Employyee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email{ get; set; }
        public string Address { get; set; }
        public DateTime Birthday{ get; set; }

    }
}
