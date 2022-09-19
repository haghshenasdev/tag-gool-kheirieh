using System;
using kheirieh.datalayer.Services;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using kheirieh.datalayer.Repositories;

namespace kheirieh.datalayer.Context
{
    public class UnitOfWork : IDisposable
    {
        app_kheiriehEntities db = new app_kheiriehEntities();

        private IMarhoomRepository _NGmarhoomRepository;
        public IMarhoomRepository NGmarhoomRepository
        {
            get
            {
                if (_NGmarhoomRepository == null)
                {
                    _NGmarhoomRepository = new MarhoomRepository(db);
                }
                return _NGmarhoomRepository;
            }
        }

        private IPersonRepository _NGPersonRepository;
        public IPersonRepository NGPersonRepository
        {
            get
            {
                if (_NGPersonRepository == null)
                {
                    _NGPersonRepository = new PersonRepository(db);
                }
                return _NGPersonRepository;
            }
        }

        private ITajTypeRepository _NGTajTypeRepository;
        public ITajTypeRepository NGTajTypeRepository
        {
            get
            {
                if (_NGTajTypeRepository == null)
                {
                    _NGTajTypeRepository = new TajTypeRepository(db);
                }
                return _NGTajTypeRepository;
            }
        }

        private ITemplateRepository _NGTemplateRepository;
        public ITemplateRepository NGTemplateRepository
        {
            get
            {
                if (_NGTemplateRepository == null)
                {
                    _NGTemplateRepository = new TemplateRepository(db);
                }
                return _NGTemplateRepository;
            }
        }

        private IKerayehRepository _NGKerayehRepository;
        public IKerayehRepository NGKerayehRepository
        {
            get
            {
                if (_NGKerayehRepository == null)
                {
                    _NGKerayehRepository = new NGKerayehRepository(db);
                }
                return _NGKerayehRepository;
            }
        }

        private GenericRepository<marhoom> _marhomRepository;
        public GenericRepository<marhoom> MarhomRepository
        {
            get
            {
                if (_marhomRepository == null)
                {
                    _marhomRepository = new GenericRepository<marhoom>(db);
                }
                return _marhomRepository;
            }
        }

        private GenericRepository<person> _personRepository;
        public GenericRepository<person> PersonRepository
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new GenericRepository<person>(db);
                }
                return _personRepository;
            }
        }

        private GenericRepository<taj> _tajRepository;
        public GenericRepository<taj> TajRepository
        {
            get
            {
                if (_tajRepository == null)
                {
                    _tajRepository = new GenericRepository<taj>(db);
                }
                return _tajRepository;
            }
        }

        private GenericRepository<template> _templateRepository;
        public GenericRepository<template> TemplateRepository
        {
            get
            {
                if (_templateRepository == null)
                {
                    _templateRepository = new GenericRepository<template>(db);
                }
                return _templateRepository;
            }
        }

        private GenericRepository<kerayeh> _kerayehRepository;
        public GenericRepository<kerayeh> KerayehRepository
        {
            get
            {
                if (_kerayehRepository == null)
                {
                    _kerayehRepository = new GenericRepository<kerayeh>(db);
                }
                return _kerayehRepository;
            }
        }

        private GenericRepository<setingapp> _setingappRepository;
        public GenericRepository<setingapp> setingappRepository
        {
            get
            {
                if (_setingappRepository == null)
                {
                    _setingappRepository = new GenericRepository<setingapp>(db);
                }
                return _setingappRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
