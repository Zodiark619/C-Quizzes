using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay1.OOP
{
    internal class SUV:Car
    {
        private decimal sewa;
        private decimal biayaSupir;

        public SUV(string noPolisi, string tahun,decimal sewa,decimal biayaSupir) : base(noPolisi, tahun)
        {
            this.sewa = sewa;
            this.biayaSupir = biayaSupir;
            Type = "SUV";
            TotalPendapatan = sewa + biayaSupir;
        }

        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal BiayaSupir { get => biayaSupir; set => biayaSupir = value; }
    }
}
