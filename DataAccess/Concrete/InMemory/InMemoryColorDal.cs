using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Color getCarsByColorId(int colorId)
        {
            Color color = _colors.SingleOrDefault(c => c.ColorId == colorId);
            return color;
        }
    }
}
