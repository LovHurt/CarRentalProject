//using Business.Concrete;
//using Business.Constants;
//using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;
//using Entities.Concrete;

//namespace ConsoleUI
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("Our cars' details are listed below");

//            //CarManager carManager = new CarManager(new EfCarDal());

//            //foreach (var c in carManager.GetCarDetails().Data)
//            //{
//            //    Console.WriteLine(c.BrandName +", "+ c.ColorName + ", " + c.DailyPrice + ", " + c.Description + ", " + c.ModelYear);
//            //}

//            UserManager userManager = new UserManager(new EfUserDal());

//            //User user3 = new User
//            //{
//            //    Email = "yertre@ertert.com", FirstName = "can", LastName = "kan",
//            //    Password = "22222222222"
//            //};

//            userManager.Delete(6);

//            //Console.WriteLine(user3.FirstName + " " + user3.LastName + " " + user3.Email);

//            Console.ReadLine();

//        }
//    }
//}