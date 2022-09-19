using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kheirieh.utility
{
    public class MarhoomName
    {
        public string addmarhoom(string name, bool marhoomeh = false)
        {
            if (!name.Contains("مرحوم") && !name.Contains("مرحومه"))
            {
                name = name.Trim();
                name = ((!marhoomeh) ? ("مرحوم " + name) : ("مرحومه " + name));
            }

            return name;
        }
    }
}
