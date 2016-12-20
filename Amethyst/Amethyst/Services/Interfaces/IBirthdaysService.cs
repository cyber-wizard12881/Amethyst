using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Amethyst.Domain.Classes;

namespace Amethyst.Services.Interfaces
{
    public interface IBirthdaysService
    {
        void CreateMyEntity(Birthday myEntity);
        IEnumerable<Birthday> GetMyEntities(Expression<Func<Birthday, bool>> predicate);
        IEnumerable<Birthday> GetAllMyEntities();
        void UpdateMyEntity(Birthday myEntity);
        void DeleteMyEntity(Birthday myEntity);
    }
}
