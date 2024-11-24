using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class EntityRepository<TEntity> : IEntityRepository<TEntity>
        where TEntity : Entity
    {
        public virtual TEntity GetByID(Guid id)
        {
            // Placeholder for actual implementation
            return Activator.CreateInstance<TEntity>();
        }
    }

}
