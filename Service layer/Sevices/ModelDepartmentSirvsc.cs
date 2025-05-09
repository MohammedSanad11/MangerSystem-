using DomainLayer.Model;
using Repositorylayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicelayer.Sevices
{
    public class ModelDepartmentSirvsc : ICoustmsServices<Department>
    {
        private readonly IRrepositry<Department> _repostoriy;

        public ModelDepartmentSirvsc(IRrepositry<Department> repositry)
        {
            _repostoriy = repositry;
        }

        public void Delete(Department entity)
        {
            _repostoriy.Delete(entity);
            _repostoriy.saveChagnes();
        }

        public Department Get(int id)
        {
          return _repostoriy.Get(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return _repostoriy.GetAll();
        }

        public void Insert(Department entity)
        {
           _repostoriy.Insert(entity);
            _repostoriy.saveChagnes();     
        }

        public void Remove(Department entity)
        {
            _repostoriy?.Remove(entity);
            _repostoriy?.saveChagnes();
        }

        public void Update(Department entity)
        {
            _repostoriy.Update(entity);
            _repostoriy.saveChagnes();
        }
    }
}
