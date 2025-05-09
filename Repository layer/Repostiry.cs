using DomainLayer.Data;
using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorylayer
{
    public class Repostiry<T> : IRrepositry<T> where T : BaceEntity
    {

        #region property
        private readonly MangementSystemDbContext _mangementsystemdbcontext;
        private readonly DbSet<T> _dbSet;


        #endregion
        public Repostiry(MangementSystemDbContext mangementsystemdbcontext)
        {
            _mangementsystemdbcontext = mangementsystemdbcontext;
            _dbSet = _mangementsystemdbcontext.Set<T>();
        }
        #region Constructor

        #endregion
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _dbSet.Remove(entity);
            _mangementsystemdbcontext.SaveChanges();
        }
        public T Get(int Id)
        {
            return _dbSet.Find(Id);
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable();
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _dbSet.Add(entity);
            _mangementsystemdbcontext.SaveChanges();
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _dbSet.Remove(entity);
            _mangementsystemdbcontext.SaveChanges();
        }

        public void saveChagnes()
        {
            _mangementsystemdbcontext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _dbSet.Update(entity);
            _mangementsystemdbcontext.SaveChanges();
        }
    }
}
