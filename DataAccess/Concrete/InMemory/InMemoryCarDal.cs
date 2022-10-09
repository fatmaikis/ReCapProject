using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=2, ColorId=3, ModelYear=2019, DailyPrice=500, Description=" Kırmızı Mercedes" },
                new Car{CarId=2, BrandId=3, ColorId=4, ModelYear=2015, DailyPrice=600, Description=" Mavi BMV" },
                new Car{CarId=3, BrandId=4, ColorId=5, ModelYear=2022, DailyPrice=1500, Description=" Siyah Audi " },
                new Car{CarId=4, BrandId=5, ColorId=6, ModelYear=2010, DailyPrice=200, Description=" Beyaz Tofaş" }
        };


        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.CarId == car.CarId);

            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Insert(Car entity)
        {
            throw new NotImplementedException();
        }

       
        public void Update(Car car)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul.
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        
        
        }

        
    }
}
