using LDSFormsApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LDSFormsApp.Data
{
    public class MeetingRepository : IMeetingRepository
    {
        private readonly LDSFormsAppContext _context;
        public MeetingRepository(LDSFormsAppContext context)
        {
            _context = context;
        }

        public IEnumerable<Meeting> GetAll()
        {
            return _context.Meetings.OrderBy(x => x.Date);
        }

        public Meeting Get(int id)
        {
            return _context.Meetings.SingleOrDefault(x => x.Id == id);
        }

        public Meeting Add(Meeting entity)
        {
            _context.Add<Meeting>(entity);
            _context.SaveChanges();
            return entity;
        }
    }

    public interface IMeetingRepository
    {
        IEnumerable<Meeting> GetAll();
        Meeting Get(int id);
        Meeting Add(Meeting entity);
    }
}
