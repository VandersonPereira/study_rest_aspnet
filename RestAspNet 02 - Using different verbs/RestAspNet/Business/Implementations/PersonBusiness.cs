using RestAspNet.Models;
using RestAspNet.Repository.Generic;
using System.Collections.Generic;

namespace RestAspNet.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {
        private IGenerciRepository<Person> _repository;

        public PersonBusiness(IGenerciRepository<Person> repository)
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
