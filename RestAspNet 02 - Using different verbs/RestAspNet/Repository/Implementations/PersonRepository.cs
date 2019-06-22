using RestAspNet.Models;
using RestAspNet.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAspNet.Repository.Implementations
{
    public class PersonRepository : IPersonRepository
    {
        private MySqlContext _context;

        public PersonRepository(MySqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }

        public void Delete(long id)
        {
            var personToDelete = _context.person.SingleOrDefault(p => p.Id.Equals(id));

            try
            {
                if (personToDelete != null) _context.person.Remove(personToDelete);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Person> FindAll() => _context.person.ToList();

        public Person FindById(long id) => _context.person.SingleOrDefault(p => p.Id.Equals(id));

        public Person Update(Person person)
        {
            if (!Exist(person.Id)) return null;

            var personToUpdate = _context.person.SingleOrDefault(p => p.Id.Equals(person.Id));

            try
            {
                _context.Entry(personToUpdate).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }

        public bool Exist(long? id) => _context.person.Any(p => p.Id.Equals(id));
    }
}
