using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay1.OOP
{
    internal class CarImpl : ICar
    {
        public Car? FindCarByNomor(List<Car> listCar, string nomor)
        {
            return listCar.Find(x => x.NoPolisi .Equals( nomor));
        }

        public List<Car> FindCarByType(List<Car> listCar, EnumCar carType)
        {
            return listCar.FindAll(x => x.Type .Equals( carType.ToString()));

        }

        public List<Car> InitListCar(Car[] cars)
        {
            List<Car> listCar = new List<Car>();
            listCar.AddRange(cars);
            return listCar;
        }

        public decimal TotalPendapatan(List<Car> listCar, EnumCar carType)
        {
            decimal totalPendapatan = 0M;
            switch (carType)
            {
                case EnumCar.ALL_CAR:
                    totalPendapatan = listCar.Sum(e => e.TotalPendapatan++);
                    break;
                case EnumCar.ANGKOT:
              
                case EnumCar.TAXI:
                  
                case EnumCar.HELICOPTER:
                case EnumCar.SUV:

                case EnumCar.CESSNA:
                    
                case EnumCar.BOAT:
                    totalPendapatan=listCar.Where(e => e.Type.Equals(carType.ToString())).Sum(item=>item.TotalPendapatan++);
                    break;
                default:
                    break;
            }
            return totalPendapatan;
        }
    }
}
