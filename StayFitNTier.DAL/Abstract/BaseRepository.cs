using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.Abstract
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        StayFitDbContext context;
        DbSet<T> _object;
        public BaseRepository()
        {
            context = new StayFitDbContext();
            _object = context.Set<T>();
            
        }  
        /// <summary>
        /// Gets class by given Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            return _object.Find(id);
        }
        /// <summary>
        /// Adds class.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Insert(T p)
        {
            _object.Add(p);
            return context.SaveChanges() > 0;
        }
        /// <summary>
        /// List class.
        /// </summary>
        /// <returns></returns>
        public List<T> List()
        {
            return _object.ToList();
        }                
    }
}
