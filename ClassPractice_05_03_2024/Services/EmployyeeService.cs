using ClassPractice_05_03_2024.Helpers.Responcses;
using ClassPractice_05_03_2024.Models;
using ClassPractice_05_03_2024.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassPractice_05_03_2024.Services.EmployyeeService;


namespace ClassPractice_05_03_2024.Services
{

    public class EmployyeeService : IEmployyeService
    {
             
            public Employyee[] GetAll()
            {
                Employyee employee1 = new()
                {
                    Id = 1,
                    Name = "Rashad",
                    Surname = "Aghayev",
                    Age = 21,
                    Email = "rashad@gmail.com",
                    Address = "Ordubad",
                    Birthday = DateTime.Now.AddYears(-21),

                };

                Employyee employee2 = new()
                {
                    Id = 2,
                    Name = "Rufat",
                    Surname = "Ismayilov",
                    Age = 22,
                    Email = "rufat@gmail.com",
                    Address = "Baki",
                    Birthday = new DateTime(2003, 9, 4),

                };

                Employyee employee3 = new()
                {
                    Id = 3,
                    Name = "Cavid",
                    Surname = "Bashirov",
                    Age = 30,
                    Email = "cavid@gmail.com",
                    Address = "Siyezen",
                    Birthday = DateTime.Now.AddYears(-30),

                };

                Employyee employee4 = new()
                {
                    Id = 4,
                    Name = "Amirastan",
                    Surname = "Mereyev",
                    Age = 33,
                    Email = "Amirastan@gmail.com",
                    Address = "Xezer",
                    Birthday = DateTime.Now.AddYears(-33),

                };

                Employyee employee5 = new()
                {
                    Id = 5,
                    Name = "Esgerxan",
                    Surname = "Bayramov",
                    Age = 27,
                    Email = "esgerxan@gmail.com",
                    Address = "Berde",
                    Birthday = DateTime.Now.AddYears(-27),

                };

                Employyee employee6 = new()
                {
                    Id = 6,
                    Name = "Behruz",
                    Surname = "Aliyev",
                    Age = 21,
                    Email = "bahruz@gmail.com",
                    Address = "Ordubad",
                    Birthday = DateTime.Now.AddYears(-21),

                };

                Employyee employee7 = new()
                {
                    Id = 7,
                    Name = "Rashad",
                    Surname = "Aghayev",
                    Age = 21,
                    Email = "rashad@gmail.com",
                    Address = "Ordubad",
                    Birthday = DateTime.Now.AddYears(-21),

                };
                Employyee employee8 = new()
                {
                    Id = 8,
                    Name = "Ismayil",
                    Surname = "Ceferli",
                    Age = 24,
                    Email = "ismayil@gmail.com",
                    Address = "Ehmedli",
                    Birthday = DateTime.Now.AddYears(-24),

                };

                return new Employyee[] { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8 };
            }

        

        public EmployyeeResponse GetById(Employyee[] employyees, int? id)
        {
            if(id == null)
            {
                return new EmployyeeResponse { ErrorMessage = "Id can't null" };
            }
            return new EmployyeeResponse { Employyee = employyees.FirstOrDefault(m => m.Id == id) };
        }


        public EmployyeeResponse FoundByName(Employyee[] employyees, string name)
        {
            if(name == null)
            {
                return new EmployyeeResponse { ErrorMessage = "Name notfound" };
            }
            return new EmployyeeResponse { Employyee = employyees.FirstOrDefault(m => m.Name == name) };
        }


        public EmployyeeResponse FoundBySurname(Employyee[] employyees, string surname)
        {
            if (surname == null)
            {
                return new EmployyeeResponse { ErrorMessage = "Surname notfound" };
            }
            return new EmployyeeResponse { Employyee = employyees.FirstOrDefault(m => m.Surname == surname) };
        }




    }
    }
    
