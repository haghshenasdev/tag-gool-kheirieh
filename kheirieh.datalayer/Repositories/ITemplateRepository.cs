using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kheirieh.datalayer.Repositories
{
    public interface ITemplateRepository
    {
        IEnumerable<template> GetByFilterName(string Parametar);
    }
}
