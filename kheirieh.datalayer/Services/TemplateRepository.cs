using kheirieh.datalayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kheirieh.datalayer.Services
{
    public class TemplateRepository : ITemplateRepository
    {
        private app_kheiriehEntities db;
        public TemplateRepository(app_kheiriehEntities template)
        {
            db = template;
        }

        public IEnumerable<template> GetByFilterName(string Parametar)
        {
            return db.templates.Where(p => p.name.Contains(Parametar)).ToList();
        }
    }
}
