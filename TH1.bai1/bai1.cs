using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH1.bai1
{
    class Diem
    {
        private double x;
        private double y;
        public Diem()
        {
            x = 0;
            y = 0;
        }
        public Diem(double ox,double oy)
        {
            x = ox;
            y = oy;
        }
        public void nhap()
        {
            Console.Write("Hoanh do la : ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Tung do la : ");
            y = double.Parse(Console.ReadLine());
        }
        public void hienThi()
        {
            Console.WriteLine("Toa do la : ({0},{1})", x, y);
        }
        public double Khoangcach(double d1,double d2)
        {
            double kc = Math.Sqrt((x-d1)* (x - d1)+(y-d2)* (y - d2));
            return kc;
        }
    }
}
