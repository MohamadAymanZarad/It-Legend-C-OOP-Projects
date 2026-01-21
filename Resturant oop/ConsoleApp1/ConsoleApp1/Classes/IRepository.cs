using System;
using System.Collections.Generic;
using System.Text;

namespace ResturantApp_oop.Classes
{
    internal interface IRepository<t> where t : class
    {
        public List<t> GetAll();
        public t GetById(int id);
        public bool Add(t enitty);
        public bool Edit(t enitty);
        public bool Delete(int id);
    }
}
