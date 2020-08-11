using System.Collections.Generic;
using proj.Models;

namespace proj.Data
{
    public interface IProjRepo
    {
        IEnumerable<Detail> GetAllDetails();
        Detail GetDetailById(int id);
    }
}