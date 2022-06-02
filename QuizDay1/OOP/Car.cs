using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay1.OOP
{
    internal class Car
    {
        private string noPolisi;
            private string tahun;

        private string type;
        private decimal totalPendapatan;

        public Car(string noPolisi, string tahun, string type)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            this.type = type;
        }
        public Car(string noPolisi,string tahun)
        {
            this.noPolisi=noPolisi;
            this.tahun = tahun;
        }

        public override string? ToString()
        {
            return $"Car NoPolisi:{this.noPolisi} tahun:{this.tahun} type:{this.type} totalPendapatan:{this.totalPendapatan}";
        }

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public string Tahun { get => tahun; set => tahun = value; }
        public string Type { get => type; set => type = value; }
        public decimal TotalPendapatan { get => totalPendapatan; set => totalPendapatan = value; }

    }
}
