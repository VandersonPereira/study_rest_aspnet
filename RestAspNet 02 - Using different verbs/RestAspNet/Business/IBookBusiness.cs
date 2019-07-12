using RestAspNet.Models;
using System.Collections.Generic;

namespace RestAspNet.Business
{
    public interface IBookBusiness
    {
        Person Create(Book book); 
        Person FindById(long id); 
        List<Person> FindAll(); 
        Person Update(Book book); 
        void Delete(long id); 
    }
}
