using kheirieh.datalayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kheirieh.datalayer.Services
{
    public class TajTypeRepository : ITajTypeRepository
    {
        private app_kheiriehEntities db;
        public TajTypeRepository(app_kheiriehEntities taj)
        {
            db = taj;
        }

        public IEnumerable<taj> GetByFilterName(string Parametar)
        {
            return db.tajs.Where(p => p.typename.Contains(Parametar)).ToList();
        }
    }
}
