using HospitalMMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMMS.Modules.PersonModels.Models
{
    public class SQLPersonRepository : IPersonRepository
    {
        private readonly AppDbContext context;

        public SQLPersonRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Person Add(Person person)
        {
            context.Persons.Add(person);
            context.SaveChanges();
            return person;
        }

        public Person Delete(int id)
        {
            Person person = context.Persons.Find(id);
            if(person != null)
            {
                context.Persons.Remove(person);
                context.SaveChanges();
            }
            return person;
        }

        public IEnumerable<Person> GetAllPerson()
        {
            return context.Persons;
        }

        public Person GetPerson(int Id)
        {
            return context.Persons.Find(Id);
        }

        public Person Update(Person personChanges)
        {
            var person = context.Persons.Attach(personChanges);
            person.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return personChanges;
        }
    }
}
