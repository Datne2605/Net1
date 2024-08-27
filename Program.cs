using System;
 
namespace PT_Ao
{
    public abstract class Hinh
    {
        public virtual void nhap() { }
        public virtual void Hienthi() { }
        public virtual double dientich()
        { return dientich(); }
    }
    class Tron : Hinh
    {
        private double bk;
        public override void nhap()
        {
            Console.Write("Nhap ban kinh: ");
            bk = double.Parse(Console.ReadLine());
        }
        public override void Hienthi()
        {
            Console.Write("Hinh tron ban kinh = " + bk);
        }
        public override double dientich()
        {
            return bk * bk * Math.PI;
        }
    }
    class Chunhat : Hinh
    {
        private double d, r;
        public override void nhap()
        {
            Console.Write("Nhap chieu dai: ");
            d = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            r = double.Parse(Console.ReadLine());
        }
        public override void Hienthi()
        {
            Console.Write("Hinh chu nhat co chieu dai = {0}, rong = {1}", d, r);
        }
        public override double dientich()
        {
            return d * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hinh[] h = new Hinh[100];
            char chon, loai;
            int N = 0;
            do
            {
                Console.Write("Ban nhap hinh gi (t/c): ");
                loai = char.Parse(Console.ReadLine());
                if (loai == 't')
                {
                    Tron tr = new Tron();
                    tr.nhap();
                    h[N++] = tr;
                }
                else
                {
                    Chunhat cn = new Chunhat();
                    cn.nhap();
                    h[N++] = cn;
                }
                Console.Write("Ban co nhap tiep hay khong (c/k)?: ");
                chon = char.Parse(Console.ReadLine());
                if (chon == 'k' || chon == 'K' || N > 100) break;
            } while (true);
            Console.WriteLine("Danh sach vua nhap la:");
            int m = 0;
            for (int i = 0; i < N; i++)
                if (h[i].dientich() > h[m].dientich()) m = i;
            Console.WriteLine("Hinh co dien tich lon nhat la:");
            h[m].Hienthi();
            Console.WriteLine("Dien tich: " + h[m].dientich());
            Console.ReadKey();
 
        }
    }
}