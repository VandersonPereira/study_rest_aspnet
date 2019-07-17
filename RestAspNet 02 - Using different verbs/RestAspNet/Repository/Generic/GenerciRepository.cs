using Microsoft.EntityFrameworkCore;
using RestAspNet.Models.Base;
using RestAspNet.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAspNet.Repository.Generic
{
    public class GenerciRepository<T> : IGenerciRepository<T> where T : BaseEntity
    {
        private MySqlContext _context;
        private DbSet<T> _dataSet;

        public GenerciRepository(MySqlContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public T Create(T entity)
        {
            try
            {
                _dataSet.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Delete(long id)
        {
            var entityToDelete = _dataSet.SingleOrDefault(p => p.Id.Equals(id));

            try
            {
                if (entityToDelete != null)
                    _dataSet.Remove(entityToDelete);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exist(long? id)
        {
            return _dataSet.Any(p => p.Id.Equals(id));
        }

        public List<T> FindAll()
        {
            return _dataSet.ToList();
        }

        public T FindById(long id)
        {
            return _dataSet.SingleOrDefault(p => p.Id.Equals(id));
        }

        public T Update(T entity)
        {
            if (!Exist(entity.Id)) return null;

            var personToUpdate = _dataSet.SingleOrDefault(p => p.Id.Equals(entity.Id));

            try
            {
                _context.Entry(personToUpdate).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }
    }
}
