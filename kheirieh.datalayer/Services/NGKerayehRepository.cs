using kheirieh.datalayer.Repositories;
using kheirieh.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace kheirieh.datalayer.Services
{
    public class NGKerayehRepository : IKerayehRepository
    {
        private app_kheiriehEntities db;
        public NGKerayehRepository(app_kheiriehEntities Kerayeh)
        {
            db = Kerayeh;
        }

        public List<KerayehJoin> joink()
        {
            return db.kerayehs.Join(
                db.persons,
                k => k.usertraf,
                p => p.id,
                 (k, p) => new { k, p }
                ).Join(
                db.marhooms,
                k2 => k2.k.marhom,
                m => m.id,
                (k2, m) => new KerayehJoin
                {
                    id = k2.k.id,
                    marhom = m.name,
                    usertraf = k2.p.name,
                    amountpay = k2.k.amountpay,
                    ispardakht = k2.k.ispardakht,
                    count = k2.k.count,
                    date = k2.k.date
                }
                ).OrderByDescending(k => k.id).ToList();
        }

        public KerayehJoin joinbyid(int id)
        {
            return db.kerayehs.Where(k => k.id == id).Join(
                    db.persons,
                    k => k.usertraf,
                    p => p.id,
                     (k, p) => new { k, p }
                    ).Join(
                    db.marhooms,
                    k2 => k2.k.marhom,
                    m => m.id,
                    (k2, m) => new { k2, m }
                    ).Join(
                    db.templates,
                    k3 => k3.k2.k.tarh,
                    t => t.id,
                    (k3, t) => new { k3, t }
                    ).Join(
                    db.tajs,
                    k4 => k4.k3.k2.k.type,
                    ty => ty.id,
                    (k4, ty) => new KerayehJoin
                    {
                        id = k4.k3.k2.k.id,
                        marhom = k4.k3.m.name,
                        usertraf = k4.k3.k2.p.name,
                        amountpay = k4.k3.k2.k.amountpay,
                        ispardakht = k4.k3.k2.k.ispardakht,
                        type = ty.typename,
                        tarh = k4.t.name,
                        count = k4.k3.k2.k.count,
                        date = k4.k3.k2.k.date
                    }
                    ).ToList().FirstOrDefault();
        }
    }
}
