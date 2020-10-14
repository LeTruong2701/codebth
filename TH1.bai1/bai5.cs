using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH1.bai1
{
    class MaTran
    {
        private int m, n;
        private int[,] a;
        public MaTran()
        {
            m = n = 2;
            a = new int[m, n];
        }
        public MaTran(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];
        }
        public MaTran(MaTran t2)
        {
            this.m = t2.m;
            this.n = t2.n;
            this.a = new int[m, n];
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                    this.a[i, j] = t2.a[i, j];
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin cho cac phan tu cua ma tran");
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        public void Hien()
        {
            Console.WriteLine("Cac phan tu cua ma tran la");
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                    Console.Write("{0}\t", a[i, j]);
                Console.WriteLine();
            }
        }
        public MaTran Tong(MaTran t2)
        {
            if (this.m == t2.m && this.n == t2.n)
            {
                MaTran t = new MaTran(this.m, this.n);
                for (int i = 0; i < t.m; ++i)
                    for (int j = 0; j < t.n; ++j)
                        t.a[i, j] = this.a[i, j] + t2.a[i, j];
                return t;
            }
            else return null;
        }
        public MaTran Hieu(MaTran t2)
        {
            if (this.m == t2.m && this.n == t2.n)
            {
                MaTran t = new MaTran(this.m, this.n);
                for (int i = 0; i < t.m; ++i)
                    for (int j = 0; j < t.n; ++j)
                        t.a[i, j] = this.a[i, j] - t2.a[i, j];
                return t;
            }
            else return null;
        }
    }
}
