using kheirieh.datalayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kheirieh.datalayer.Services
{
    public class PersonRepository : IPersonRepository
    {
        private app_kheiriehEntities db;
        public PersonRepository(app_kheiriehEntities person)
        {
            db = person;
        }

        public IEnumerable<person> GetByFilterName(string Parametar)
        {
            return db.persons.Where(p => p.name.Contains(Parametar)).ToList();
        }
    }
}
