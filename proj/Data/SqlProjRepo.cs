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
        public IEnumerable<Detail> GetAllDetails()
        {
            return _context.Details.ToList();
        }

        public Detail GetDetailById(int id)
        {
            return _context.Details.FirstOrDefault(p => p.Id == id);
        }
    }
}