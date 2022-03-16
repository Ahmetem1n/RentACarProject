using Business.Abstract;
using Business.Constants;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CardManager : ICardService
    {
        ICardDal _cardDal;

        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }

        public IResult Add(Car card)
        {
            _cardDal.Add(card);
            return new SuccessResult(Messages.Added);
        }

        public IResult Add(Car card)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Car card)
        {
            _cardDal.Delete(card);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Delete(Car card)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_cardDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Car> GetById(int cardId)
        {
            return new SuccessDataResult<Car>(_cardDal.Get(b => b.CardId == cardId), Messages.Get);
        }

        public IResult Update(Car card)
        {
            _cardDal.Update(card);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Update(Car card)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> ICardService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Car> ICardService.GetById(int cardId)
        {
            throw new NotImplementedException();
        }
    }
}
