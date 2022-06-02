using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay1.OOP
{
    internal interface ICar
    {
        public List<Car> InitListCar(Car[] cars);
        public List<Car> FindCarByType(List<Car> listCar, EnumCar carType);
        public Car? FindCarByNomor(List<Car> listCar,string nomor);
        public decimal TotalPendapatan(List<Car> listCar,EnumCar carType);
    }
}
