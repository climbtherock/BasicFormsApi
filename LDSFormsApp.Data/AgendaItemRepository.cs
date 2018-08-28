using LDSFormsApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LDSFormsApp.Data
{
    public class AgendaItemRepository : IAgendaItemRepository
    {
        private readonly LDSFormsAppContext _context;
        public AgendaItemRepository(LDSFormsAppContext context)
        {
            _context = context;
        }

        public IEnumerable<AgendaItem> GetAll()
        {
            return _context.AgendaItems;
        }

        public AgendaItem Add(AgendaItem entity)
        {
            _context.Add<AgendaItem>(entity);
            _context.SaveChanges();
            return entity;
        }
    }

    public interface IAgendaItemRepository
    {
        IEnumerable<AgendaItem> GetAll();
        AgendaItem Add(AgendaItem entity);
    }
}
