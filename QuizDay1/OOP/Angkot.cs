using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay1.OOP
{
    internal class Angkot : Car
    {
        private decimal hargaTiket;
        private int totalPenumpang;
        public Angkot(string noPolisi, string tahun, string type, decimal hargaTiket, int totalPenumpang) : base(noPolisi, tahun, type)
        {
            this.hargaTiket = hargaTiket;
            this.totalPenumpang = totalPenumpang;

            TotalPendapatan = decimal.Multiply(hargaTiket, totalPenumpang);
        }
        public Angkot(string noPolisi, string tahun, decimal hargaTiket,int totalPenumpang) : base(noPolisi, tahun)
        {
            this.hargaTiket = hargaTiket;
            this.totalPenumpang = totalPenumpang;
            Type = "ANGKOT";
            TotalPendapatan = decimal.Multiply(hargaTiket, totalPenumpang);
        }

        public override string? ToString()
        {
            return $"{base.ToString()} hargaTiket:{this.hargaTiket} totalPenumpang:{this.totalPenumpang}";
        }

        public decimal HargaTiket { get => hargaTiket; set => hargaTiket = value; }
        public int TotalPenumpang { get => totalPenumpang; set => totalPenumpang = value; }
    }
}
