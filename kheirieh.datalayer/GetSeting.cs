using kheirieh.datalayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kheirieh.datalayer
{
    public static class GetSeting
    {
        public static template getdefualttarh(UnitOfWork db)
        {
            int setingtarh = getdefualttarhVal(db); //defualt_tarh
            template tarh;
            if (setingtarh == 0)
            {
                tarh = db.TemplateRepository.GetRandom();
            }
            else
            {
                tarh = db.TemplateRepository.GetByID(setingtarh);
            }
            return tarh;
        }
        public static int getdefualttarhVal(UnitOfWork db)
        {
            return Int32.Parse(db.setingappRepository.GetByID(1).value);
        }

        public static int getLimitTables(UnitOfWork db)
        {
            return Int32.Parse(db.setingappRepository.GetByID(3).value.ToString());
        }

        public static int getDefualtTypeId(UnitOfWork db)
        {
            return Int32.Parse(db.setingappRepository.GetByID(2).value);
        }

        public static string getDefulttemplatePtah(UnitOfWork db = null)
        {
            if (db == null)
            {
                using (db = new UnitOfWork())
                {
                    return db.setingappRepository.GetByID(4).value;
                }
            }
            else
            {
                return db.setingappRepository.GetByID(4).value;
            }
        }
    }
}
