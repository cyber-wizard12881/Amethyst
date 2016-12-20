using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Amethyst.Domain.Classes;
using Amethyst.Repositories.Interfaces;
using Amethyst.Services.Interfaces;

namespace Amethyst.Services.Classes
{
    public class BirthdaysService : IBirthdaysService
    {
        private readonly IGenericRepository<Birthday> _myEntityRepository;

        public BirthdaysService(IGenericRepository<Birthday> myEntityRepository)
        {
            this._myEntityRepository = myEntityRepository;
        }

        public void CreateMyEntity(Birthday myEntity)
        {
            this._myEntityRepository.Add(myEntity);
        }

        public IEnumerable<Birthday> GetMyEntities(Expression<Func<Birthday, bool>> predicate)
        {
            return this._myEntityRepository.FindBy(predicate);
        }

        public IEnumerable<Birthday> GetAllMyEntities()
        {
            return this._myEntityRepository.GetAll();
        }

        public void UpdateMyEntity(Birthday myEntity)
        {
            this._myEntityRepository.Edit(myEntity);
        }

        public void DeleteMyEntity(Birthday myEntity)
        {
            this._myEntityRepository.Delete(myEntity);
        }
    }
}