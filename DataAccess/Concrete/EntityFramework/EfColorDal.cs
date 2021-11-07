using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (ReCapProjectContext reCapProjectContext = new ReCapProjectContext())
            {
                var addedEntity = reCapProjectContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                reCapProjectContext.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapProjectContext reCapProjectContext = new ReCapProjectContext())
            {
                var deletedEntity = reCapProjectContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                reCapProjectContext.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (ReCapProjectContext reCapProjectContext = new ReCapProjectContext())
            {
                return reCapProjectContext.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapProjectContext reCapProjectContext = new ReCapProjectContext())
            {
                return filter == null ? reCapProjectContext.Set<Color>().ToList() : reCapProjectContext.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (ReCapProjectContext reCapProjectContext = new ReCapProjectContext())
            {
                var updatedEntity = reCapProjectContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                reCapProjectContext.SaveChanges();
            }
        }
    }
}
