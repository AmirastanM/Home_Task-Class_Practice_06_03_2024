using ClassPractice_05_03_2024.Helpers.Responcses;
using ClassPractice_05_03_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_05_03_2024.Services.Interface
{
    public interface IEmployyeService 
    {
        public Employyee[] GetAll();

        EmployyeeResponse GetById(Employyee[] employyees, int? id);

        EmployyeeResponse FoundByName(Employyee[] employyees, string name);

        EmployyeeResponse FoundBySurname(Employyee[] employyees, string surname);
    }
}
