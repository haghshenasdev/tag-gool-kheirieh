using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kheirieh.datalayer.Repositories
{
    public interface ITajTypeRepository
    {
        IEnumerable<taj> GetByFilterName(string Parametar);
    }
}
