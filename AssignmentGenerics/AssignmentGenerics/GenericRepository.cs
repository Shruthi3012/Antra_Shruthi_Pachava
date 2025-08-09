using AssignmentGenerics.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGenerics
{
    internal class GenericRepository<T> : IRepository<T> where T : Entity
    {

        List<T> _entities;

        public GenericRepository()
        {
           _entities = new List<T>();
        }
        public void Add(T item)
        {
            _entities.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public T GetById(int id)
        {
            //foreach (var entity in _entities)
            //{
            //   if(entity.Id == id) 
            //        return entity;
            //}
            //return null;
            return _entities.FirstOrDefault(e => e.Id == id);
        }

        public void Remove(T item)
        {
            _entities.Remove(item);
        }

        public void Save()
        {
            
        }
    }
}
