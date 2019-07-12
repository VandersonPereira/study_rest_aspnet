using RestAspNet.Models;
using RestAspNet.Models.Context;
using RestAspNet.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAspNet.Business.Implementations
{
    public class BookBusiness : IBookBusiness
    {
        private IPersonRepository _repository;

        public BookBusiness(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            throw new NotImplementedException();
        }

        public Person FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Person Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
