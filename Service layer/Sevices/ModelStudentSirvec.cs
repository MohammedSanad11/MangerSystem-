using DomainLayer.Model;
using Repositorylayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicelayer.Sreibce
{
    public class ModelStudentSirvec : ICoustmsServices<Student>
    {
        private readonly IRrepositry<Student> _repostoriy;

        public ModelStudentSirvec(IRrepositry<Student> repostoriy)
        {
            _repostoriy = repostoriy;  
        }

        public void Delete(Student entity)
        {
            _repostoriy.Delete(entity);
            _repostoriy.saveChagnes();
        }


        public Student Get(int id)
        {
            return _repostoriy.Get(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _repostoriy.GetAll();
        }

        public void Insert(Student entity)
        {
            _repostoriy.Insert(entity);
            _repostoriy.saveChagnes();
        }

        public void Remove(Student entity)
        {
            _repostoriy.Remove(entity);
            _repostoriy.saveChagnes();
        }


        public void Update(Student entity)
        {
            _repostoriy.Update(entity);
            _repostoriy.saveChagnes();
        }
    }
}
