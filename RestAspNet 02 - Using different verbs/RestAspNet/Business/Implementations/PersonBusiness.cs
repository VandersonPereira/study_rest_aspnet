using RestAspNet.Models;
using RestAspNet.Models.Context;
using RestAspNet.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAspNet.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {
        private IPersonRepository _repository;

        public PersonBusiness(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person) => _repository.Create(person);

        public void Delete(long id) => _repository.Delete(id);

        public List<Person> FindAll() => _repository.FindAll();

        public Person FindById(long id) => _repository.FindById(id);

        public Person Update(Person person) => _repository.Update(person);
    }
}
