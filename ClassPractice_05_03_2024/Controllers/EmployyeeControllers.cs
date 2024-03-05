using ClassPractice_05_03_2024.Models;
using ClassPractice_05_03_2024.Services;
using ClassPractice_05_03_2024.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_05_03_2024.Controllers
{
    public class EmployyeeControllers
    {
        private readonly IEmployyeService _employyeService;

        public EmployyeeControllers()
        {
            _employyeService = new EmployyeeService();
        }

        public void GetAll()
        {
            var employyees = _employyeService.GetAll();
            foreach (var employee in employyees)
            {
                string result = $"{employee.Name} {employee.Surname}" +
                    $" {employee.Address} {employee.Email} {employee.Age} " +
                    $"{employee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }
        }

        public void GetById()
        {
            int? id = 3;
            var response = _employyeService.GetById(_employyeService.GetAll(), id);
            if (response.ErrorMessage is null)
            {
                string result = $"{response.Employyee.Name} {response.Employyee.Surname}" +
                $" {response.Employyee.Address} {response.Employyee.Email} {response.Employyee.Age} " +
                    $"{response.Employyee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }

        }
        public void FoundByName()
        {
            string name = "Amirastan";
            var response = _employyeService.FoundByName(_employyeService.GetAll(), name);
            if (response.ErrorMessage is null)
            {
                string result = $"{response.Employyee.Name} {response.Employyee.Surname}" +
                $" {response.Employyee.Address} {response.Employyee.Email} {response.Employyee.Age} " +
                    $"{response.Employyee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
                }


        public void FoundBySurname()
        {
            string surname = "";
            var response = _employyeService.FoundBySurname(_employyeService.GetAll(), surname);
            if (response.ErrorMessage is null)
            {
                string result = $"{response.Employyee.Name} {response.Employyee.Surname}" +
                $" {response.Employyee.Address} {response.Employyee.Email} {response.Employyee.Age} " +
                    $"{response.Employyee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }

        }
        }
    }
