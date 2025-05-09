using DomainLayer.Model;
using Repositorylayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicelayer.Sevices
{
    public class MolelSubjectGpaSirvec : ICoustmsServices<SubjectGpa>
    {
        private readonly IRrepositry<SubjectGpa> _repositry;

        public MolelSubjectGpaSirvec(IRrepositry<SubjectGpa> repositry)
        {
            _repositry = repositry; 
        }
        public void Delete(SubjectGpa entity)
        {
            _repositry.Delete(entity);
            _repositry.saveChagnes();
        }

        public SubjectGpa Get(int id)
        {
            return _repositry.Get(id);
        }

        public IEnumerable<SubjectGpa> GetAll()
        {
            return _repositry.GetAll();
        }

        public void Insert(SubjectGpa entity)
        {
            _repositry.Insert(entity);
            _repositry.saveChagnes();
        }

        public void Remove(SubjectGpa entity)
        {
            _repositry.Remove(entity);
            _repositry.saveChagnes();   
        }

        public void Update(SubjectGpa entity)
        {
            _repositry.Update(entity);
            _repositry.saveChagnes();
        }
    }
}
