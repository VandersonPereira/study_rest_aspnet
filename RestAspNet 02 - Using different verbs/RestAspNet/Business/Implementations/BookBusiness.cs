using RestAspNet.Models;
using RestAspNet.Repository.Generic;
using System.Collections.Generic;

namespace RestAspNet.Business.Implementations
{
    public class BookBusiness : IBookBusiness
    {
        private IGenerciRepository<Book> _repository;

        public BookBusiness(IGenerciRepository<Book> repository)
        {
            _repository = repository;
        }

        public Book Create(Book book) => _repository.Create(book);

        public void Delete(long id) => _repository.Delete(id);

        public List<Book> FindAll() => _repository.FindAll();

        public Book FindById(long id) => _repository.FindById(id);

        public Book Update(Book book) => _repository.Update(book);
    }
}
