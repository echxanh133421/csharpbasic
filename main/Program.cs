using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Program
    {
        //bai tap phan1
        public static void baitapphan1()
        {
            Console.Clear();
            Console.WriteLine("\tbai tap phan1:");
            Console.WriteLine("====================================");
            Console.WriteLine("\t|0.thoat{0,20}|", " ");
            Console.WriteLine("\t|1.bai 1{0,20}|", " ");
            Console.WriteLine("\t|2.bai 2{0,20}|", " ");
            Console.WriteLine("\t|3.bai 3{0,20}|", " ");
            Console.WriteLine("====================================");
            Console.WriteLine("\t nhap lua chon:");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("cam on");
                        break;
                    }
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("\tbai1 phan1");
                        Console.WriteLine("Chao cac ban!");
                        Console.WriteLine("Toi ten la: Pham Cong Cuong");
                        Console.WriteLine("MSSV la: 20194828");
                        Console.WriteLine("So den thoai la: 0336147983");
                        Console.WriteLine("--------------------------------");
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("\tbai2 phan1");
                        Console.WriteLine("nhap diem mon toan:");
                        float toan = float.Parse(Console.ReadLine());
                        Console.WriteLine("nhap diem van");
                        float van = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("nhap diem anh:");
                        float anh = System.Single.Parse(Console.ReadLine());
                        Console.WriteLine("nhap diem ly:");
                        float ly = System.Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("nhap diem hoa:");
                        float hoa = float.Parse(Console.ReadLine());
                        Console.WriteLine("nhap diem sinh:");
                        float sinh = Convert.ToSingle(Console.ReadLine());
                        float avg = toan * 3 + (van + ly + anh) * 2 + hoa + sinh;
                        avg = avg / 11;
                        Console.WriteLine("diem trung binh la: {0:0.00}", avg);
                        Console.WriteLine("--------------------------------");
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("\tbai3 phan1");
                        Console.WriteLine("1.y1=2*x^3+5*x^2+7*x+15");
                        Console.WriteLine("2.y2=sin(x)^2+Cos(x)^2+tan(x)^2");
                        Console.WriteLine("3.y3=(x+10)^(x+5)");
                        Console.WriteLine("4.y4=3*e^Cos(x+1)");
                        Console.WriteLine("5.y5=log(x+100)");
                        Console.WriteLine("0.thoat");
                        int choose;

                        Console.WriteLine("nhap lua chon bieu thuc");
                        choose = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("nhap x:");
                        float x = float.Parse(Console.ReadLine());
                        switch (choose)
                        {
                            case 0:
                                {
                                    Console.Clear();
                                    Console.WriteLine("thanks");
                                    break;
                                }
                            case 1:
                                {
                                    Console.Clear();
                                    Console.Write("y1=");
                                    Console.WriteLine(2 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) + 7 * x + 15);
                                    break;
                                }
                            case 2:

                                {
                                    Console.Clear();
                                    Console.Write("y2=");
                                    Console.WriteLine(Math.Pow(Math.Sin(x), 2) + Math.Pow(Math.Cos(x), 2) + Math.Pow(Math.Tan(x), 2));
                                    break;
                                }
                            case 3:
                                {
                                    Console.Clear();
                                    Console.Write("y3=");
                                    Console.WriteLine(Math.Pow(x + 10, x + 5));
                                    break;
                                }
                            case 4:
                                {
                                    Console.Clear();
                                    Console.Write("y4=");
                                    Console.WriteLine(3 * Math.Exp(Math.Cos(x + 1)));
                                    break;
                                }
                            case 5:
                                {
                                    Console.Clear();
                                    Console.Write("y5=");
                                    Console.WriteLine(Math.Log(x + 100));
                                    break;
                                }
                            default:
                                {
                                    Console.Clear();
                                    Console.WriteLine("nhap sai, nhap lai");
                                    break;
                                }
                        }
                        Console.WriteLine("--------------------------------");

                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("nhap lai:");
                        break;
                    }

            }
            Console.WriteLine("an nut bat ki de tro lai");
            Console.ReadKey();
            Console.Clear();

        }
        //bai tap phan2
        public static void baitapphan2()
        {
            Console.Clear();
            Console.WriteLine("\tbai tap phan 2:");
            Console.WriteLine("====================================");
            Console.WriteLine("|\t0.thoat{0,20}|", " ");
            Console.WriteLine("|\t1.bai 1{0,20}|", " ");
            Console.WriteLine("|\t2.bai 2{0,20}|", " ");
            Console.WriteLine("====================================");
            Console.WriteLine("nhap lua chon:");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("cam on");
                        Console.WriteLine("--------------------------------");
                        break;
                    }
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("\tbai1 phan3:");
                        Console.WriteLine("nhap vao 3 so thuc:");
                        float a = float.Parse(Console.ReadLine());
                        float b = float.Parse(Console.ReadLine());
                        float c = float.Parse(Console.ReadLine());

                        if (a < b + c && b < a + c && c < b + a)
                        {
                            Console.WriteLine("3 canh vua nhap la 3 canh cua tam giac");
                            float p = (a + b + c) / 2;
                            Console.WriteLine("chu vi tam gia: C = " + (2 * p));
                            Console.WriteLine("dien tich tam giac : S = " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
                        }
                        else
                        {
                            Console.WriteLine("3 canhh vua nhapa khong phai la 1 tam giac");
                        }
                        Console.WriteLine("--------------------------------");
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("\t bai2 phan2:");
                        Console.WriteLine("nhap vao toa do hai diem:");
                        Console.Write("toa do diem 1:\nx1 = ");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.Write("y1 = ");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.Write("toa do diem 2:\nx2 = ");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.Write("y2 = ");
                        int y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("toa do trung diem:({0},{1})", (float)(x1 + x2) / 2, (float)(y1 + y2) / 2);
                        Console.WriteLine("do dai doan thang: l={0:0.00}", Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
                        Console.WriteLine("--------------------------------");
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("nhap sai , nhap lai:");
                        Console.WriteLine("--------------------------------");
                        break;
                    }
            }
            Console.WriteLine("an nut bat ki de tro lai");
            Console.ReadKey();
            Console.Clear();
        }
        //bai tap phan3
        public static int demchuso(int n)
        {
            int dem = 0;
            while (n != 0)
            {
                n /= 10;
                dem++;
            }
            return dem;
        }
        struct NGAY
        {
            public int ngay;
            public int thang;
            public int nam;
        }

        struct HOPSUA
        {
            public string nhanhieu;
            public float trongluong;
            public NGAY hansudung;
        }

        static void nhap(out HOPSUA hopSua)
        {
            hopSua = new HOPSUA();
            Console.WriteLine("nhap:");
            Console.WriteLine("nhan hieu:");
            hopSua.nhanhieu = Console.ReadLine();
            Console.WriteLine("trong luong:");
            hopSua.trongluong = float.Parse(Console.ReadLine());
            Console.WriteLine("han su dung: ngay/thang/nam");
            hopSua.hansudung.ngay = int.Parse(Console.ReadLine());
            hopSua.hansudung.thang = int.Parse(Console.ReadLine());
            hopSua.hansudung.nam = int.Parse(Console.ReadLine());
        }
        static void xuat(HOPSUA hopSua)
        {
            Console.WriteLine("xuat:");
            Console.WriteLine($"nhan hieu:{hopSua.nhanhieu}");
            Console.WriteLine($"trongluong:{hopSua.trongluong} gam");
            Console.WriteLine($"han su dung:{hopSua.hansudung.ngay}/{hopSua.hansudung.thang}/{hopSua.hansudung.nam}");
        }

        static bool Ktra(int n)
        {
            bool check = false;
            if (Math.Pow((int)Math.Sqrt(n), 2) == n)
            {
                check = true;
            }
            return check;
        }

        struct LuanVan
        {
            public string maluanvan;
            public string tenluanvan;
            public string hotenSV;
            public string GV;
            public short nam;

        }
        static void nhap(ref LuanVan LV)
        {
            Console.WriteLine("nhap :");
            Console.WriteLine("nhap ma luan van:");
            LV.maluanvan = Console.ReadLine();
            Console.WriteLine("nhap ten luan van");
            LV.tenluanvan = Console.ReadLine();
            Console.WriteLine("nhap ten sinh vien:");
            LV.hotenSV = Console.ReadLine();
            Console.WriteLine("nhap ten giao vien");
            LV.GV = Console.ReadLine();
            Console.WriteLine("nhap nam:");
            LV.nam = short.Parse(Console.ReadLine());

        }
        static void xuat(LuanVan Lv)
        {
            Console.WriteLine("xuat:");
            Console.WriteLine(Lv.maluanvan);
            Console.WriteLine(Lv.tenluanvan);
            Console.WriteLine(Lv.hotenSV);
            Console.WriteLine(Lv.GV);
            Console.WriteLine(Lv.nam);
        }
        public static void baitapphan3()
        {
            Console.Clear();
            Console.WriteLine("\tbai tap phan 3:");

            Console.WriteLine("====================================");
            Console.WriteLine("|\t0.thoat{0,20}|", " ");
            Console.WriteLine("|\t1.bai 5{0,20}|", " ");
            Console.WriteLine("|\t2.bai 6{0,20}|", " ");
            Console.WriteLine("|\t3.bai 7{0,20}|", " ");
            Console.WriteLine("|\t4.bai 8{0,20}|", " ");
            Console.WriteLine("====================================");
            Console.WriteLine("nhap lua chon:");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("thanks");
                        Console.WriteLine("--------------------------------");

                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("\tbai8 phan3");
                        Console.WriteLine("nhap so nguyen:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("so chu so cua so nguyen:");
                        Console.WriteLine(demchuso(n));
                        Console.WriteLine("--------------------------------");
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("\tbai6 phan3:");
                        HOPSUA hopSua;
                        nhap(out hopSua);
                        Console.Clear();
                        xuat(hopSua);
                        Console.WriteLine("--------------------------------");
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("\tbai 7 phan3:");
                        for (int i = 1; i <= 100; i++)
                        {
                            if (Ktra(i))
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------");

                        break;
                    }
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("\tbai5 phan3:");
                        LuanVan Lv = new LuanVan();
                        nhap(ref Lv);
                        Console.Clear();
                        xuat(Lv);
                        Console.WriteLine("--------------------------------");

                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("nhap sai , nhap lai:");
                        Console.WriteLine("--------------------------------");
                        break;
                    }
            }
            Console.WriteLine("an nut bat ki de quay lai:");
            Console.ReadKey();
            Console.Clear();
        }

        //bai tap phan 4
        public static void nhap(int[] arr, out int n)
        {
            Console.WriteLine("nhap so luong phan tu:");
            n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("nhap mang:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"arr[{i}]=");
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("nhap sai so luong phan tu");
            }
        }
        public static void nhap(float[] arr, out int n)
        {
            Console.WriteLine("nhap so luong phan tu:");
            n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("nhap mang:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"arr[{i}]=");
                    arr[i] = float.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("nhap sai so luong phan tu");
            }
        }

        public static void xuat(int[] arr,int n)
        {
            Console.WriteLine("mang:");
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static bool ktrasonguyento(int n)
        {
            bool check = false;
            int dem = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 1)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        public static int demsonguyento(int[] arr, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 100 && ktrasonguyento(arr[i]))
                {
                    dem++;
                }
            }
            return dem;
        }

        public static float tongam(float[] arr,int n)
        {
            float sum = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        public static void baitapphan4()
        {
            Console.Clear();
            Console.WriteLine("\tbai tap phan4:");
            Console.WriteLine("================================");
            Console.WriteLine("|\t0.thoat{0,16}|", " ");
            Console.WriteLine("|\t1.bai 1{0,16}|", " ");
            Console.WriteLine("|\t2.bai 2{0,16}|", " ");
            Console.WriteLine("|\t3.bai 3{0,16}|", " ");
            Console.WriteLine("================================");
            Console.WriteLine("\t nhap lua chon:");
            int select = System.Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (select)
            {
                case 0:
                    {
                        Console.WriteLine("thanks");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("\tbai1 phan4");

                        int n;
                        int[] arr = new int[100];
                        Console.WriteLine("nhap:");
                        nhap(arr, out n);
                        Console.WriteLine("so luong phan tu la so nguyen to nho  hon 100 la:{0}", demsonguyento(arr, n));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\tbai 2 phan4:");
                        Console.WriteLine("nhap:");
                        int n;
                        float[] arr = new float[100];
                        nhap(arr,out n);
                        Console.WriteLine("tong ca gia tri am cua mang:" + tongam(arr, n));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\t bai3 phan4:");
                        int n;
                        int[] arr = new int[100];
                        Console.WriteLine("nhap:");
                        nhap(arr, out n);
                        Console.WriteLine("xuat:");
                        xuat(arr, n);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("nhap sai nhap lai:");
                        break;
                    }
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("an nut bat ki de quay lai:");
            Console.ReadKey();
            Console.Clear();

        }
        static void Main(string[] args)
        {
            Console.Title = "bai tap hoan thanh";
            //test
            //float a = 1.35347F;
            //Console.WriteLine("{0:0.00}", a);
            while (true)
            {

                Console.WriteLine("\tgiai cac bai tap:");
                Console.WriteLine("====================================");
                Console.WriteLine("|\t1.phan1{0,20}|", " ");
                Console.WriteLine("|\t2.phan2{0,20}|", " ");
                Console.WriteLine("|\t3.phan3{0,20}|", " ");
                Console.WriteLine("|\t4.phan4{0,20}|", " ");
                Console.WriteLine("|\t0.thoat{0,20}|", " ");
                Console.WriteLine("====================================");
                Console.WriteLine("\tnhap lua chon cua ban:");
                int select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("cam on");
                        Console.WriteLine("nhan nut bat ki de ket thuc");
                        Console.ReadKey();
                        return;
                    case 1:
                        baitapphan1();
                        break;
                    case 2:
                        baitapphan2();
                        break;
                    case 3:
                        baitapphan3();
                        break;
                    case 4:
                        baitapphan4();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("nhap sai ,nhap lai:");
                        Console.WriteLine("an nut bat ki de quay lai:");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
