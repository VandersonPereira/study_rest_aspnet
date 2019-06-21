using RestAspNet.Models;
using System.Collections.Generic;

namespace RestAspNet.Sevices
{
    public interface IPersonService
    {
        Person Create(Person person); 
        Person FindById(long id); 
        List<Person> FindAll(); 
        Person Update(Person person); 
        void Delete(long id); 
    }
}
