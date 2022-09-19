using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using kheirieh.utility;

namespace kheirieh.datalayer.Repositories
{
    public interface IKerayehRepository
    {
        List<KerayehJoin> joink();
        KerayehJoin joinbyid(int id);
    }
}
