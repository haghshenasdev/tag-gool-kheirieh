using kheirieh.datalayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;

namespace kheirieh.datalayer.Services
{
    public class MarhoomRepository : IMarhoomRepository
    {
        private app_kheiriehEntities db;

        public MarhoomRepository(app_kheiriehEntities marhoom)
        {
            db = marhoom;
        }
        public IEnumerable<marhoom> GetByFilterName(string Parameter)
        {
            return db.marhooms.Where(m => m.name.Contains(Parameter)).ToList();
        }
    }
}
