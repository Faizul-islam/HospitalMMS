using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.PersonModels.Models
{
    public interface IPersonRepository
    {
        Person GetPerson(int Id);
        IEnumerable<Person> GetAllPerson();
        Person Add(Person person);
        Person Update(Person personChanges);
        Person Delete(int id);

    }
}
