using DomainLayer.Model;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorylayer;


namespace Servicelayer.Sreibce
{
    public class ModelResultSirvec : ICoustmsServices<Resules1>
    {
        private readonly IRrepositry<Resules1> _repostoriy;

        public ModelResultSirvec(IRrepositry<Resules1> repostoriy)
        {
            _repostoriy = repostoriy;
        }
        public void Delete(Resules1 entity)
        {
            _repostoriy.Delete(entity);
            
        }

        public Resules1 Get(int id)
        {
          return  _repostoriy.Get(id);
        }

        public IEnumerable<Resules1> GetAll()
        {
            return _repostoriy.GetAll();
           
        }

        public void Insert(Resules1 entity)
        {
           _repostoriy.Insert(entity);
 
        }

        public void Remove(Resules1 entity)
        {
            _repostoriy.Remove(entity);
        
        }

        public void saveChagnes(Resules1 entity)
        {
            _repostoriy.saveChagnes();       
        }
        public void Update(Resules1 entity)
        {
            _repostoriy.Update(entity);
            
        }
    }
}
