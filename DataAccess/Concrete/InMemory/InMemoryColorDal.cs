using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
               new Color{ColorId = 1, ColorName = "Siyah"},
               new Color{ColorId = 2, ColorName = "Kırmızı" },
               new Color{ColorId = 3, ColorName = "Mavi" }
            };
        }

        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Color getCarsByColorId(int colorId)
        {
            Color color = _colors.SingleOrDefault(c => c.ColorId == colorId);
            return color;
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
