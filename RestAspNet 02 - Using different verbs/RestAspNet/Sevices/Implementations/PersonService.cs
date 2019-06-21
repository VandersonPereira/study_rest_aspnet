using RestAspNet.Models;
using System;
using System.Collections.Generic;

namespace RestAspNet.Sevices.Implementations
{
    public class PersonService : IPersonService
    {
        public Person Create(Person person) => person;

        public void Delete(long id){}

        public List<Person> FindAll()
        {
            return new List<Person>
            {
                new Person
                {
                    Id = 01,
                    FirstName = "Zézinho",
                    LastName = "Goró",
                    Address = "Rua dos Bobos, número 0",
                    Gender = "Masculino"
                },
                new Person
                {
                    Id = 02,
                    FirstName = "Debóra",
                    LastName = "Unicornio",
                    Address = "Rua das Imaginações, número 123",
                    Gender = "Feminino"
                },
                new Person
                {
                    Id = 03,
                    FirstName = "Kenzo",
                    LastName = "Lasanha",
                    Address = "Rua dos OWWW, número 201452021452147863366",
                    Gender = "Masculino"
                },
                new Person
                {
                    Id = 04,
                    FirstName = "Adriano",
                    LastName = "Cabeludo",
                    Address = "Rua dos Rockeiros, número 666",
                    Gender = "Indefinido"
                }
            };
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 01,
                FirstName = "Zézinho",
                LastName = "Goró",
                Address = "Rua dos Bobos, número 0",
                Gender = "Masculino"
            };
        }

        public Person Update(Person person) => person;
    }
}
