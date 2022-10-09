
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryCarDal;

CarManager carManager = new CarManager(new EfCarDal());
var result = carManager.GetCarDetails();

    if (true)
    {
        foreach (var car in result.Data)
        {
        Console.WriteLine(car.CarName + " " + car.BrandName);
        }
    }

    else
{
    Console.WriteLine(result.Message);
}




//BrandTest();

//ColorTest();

//static void BrandTest()
//{
//    BrandManager brandManager = new BrandManager(new EfBrandDal());
//    foreach (var brand in brandManager.GetAll())
//    {
//        Console.WriteLine(brand.BrandName);
//    }
//}

//static void ColorTest()
//{
//    ColorManager colorManager = new ColorManager(new EfColorDal());
//    foreach (var color in colorManager.GetAll())
//    {
//        Console.WriteLine(color.ColorId);
//    }
//}