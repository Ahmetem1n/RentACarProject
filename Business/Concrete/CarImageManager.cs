using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [SecuredOperation("admin,employee")]
        public IResult Add(CarImage carImage)
        {
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.Added);
        }

        [SecuredOperation("admin,employee")]
        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.Listed);
        }

        public IDataResult<CarImage> GetById(long imageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.ImageId == imageId), Messages.Get);
        }

        public IDataResult<List<CarImageDetailDto>> GetCarImageDetails()
        {
            return new SuccessDataResult<List<CarImageDetailDto>>(_carImageDal.GetCarImageDetails(), Messages.Listed);
        }

        [SecuredOperation("admin,employee")]
        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Updated);
        }
    }
}
