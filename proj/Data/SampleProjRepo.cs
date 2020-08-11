using System.Collections.Generic;
using proj.Models;

namespace proj.Data
{
    public class SampleProjRepo : IProjRepo
    {
        public IEnumerable<Detail> GetAllDetails()
        {
            var Details = new List<Detail>
            {
                new Detail{Id=0,Name="Arsh",uname="user1",password="Hacked"},
                new Detail{Id=0,Name="Arun",uname="user2",password="Hacker"},
                new Detail{Id=0,Name="Perry",uname="user3",password="You"}
            };
            return Details;
        }

        public Detail GetDetailById(int id)
        {
            return new Detail{Id=0,Name="Arsh",uname="user1"};
        }
    }
}