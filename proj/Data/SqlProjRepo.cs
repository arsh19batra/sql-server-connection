using System;
using System.Collections.Generic;
using System.Linq;
using proj.Models;

namespace proj.Data
{
    public class SqlProjRepo : IProjRepo
    {
        private readonly ProjContext _context;

        public SqlProjRepo(ProjContext context)
        {
            _context=context;
        }

        public void CreateDetail(Detail dtl)
        {
            if(dtl == null)
            {
                throw new ArgumentNullException(nameof(dtl));
            }
            _context.Details.Add(dtl);
        }

        public void DeleteDetail(Detail dtl)
        {
            if(dtl == null)
            {
                throw new ArgumentNullException(nameof(dtl));
            }
            _context.Details.Remove(dtl);
        }

        public IEnumerable<Detail> GetAllDetails()
        {
            return _context.Details.ToList();
        }

        public Detail GetDetailById(int id)
        {
            return _context.Details.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateDetail(Detail dtl)
        {
            
        }
    }
}