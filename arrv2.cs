using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProject
{
    class Program
    {
        //Ham nhap mang
        static void NhapMang(int[] arr,int length)
        {
            Console.WriteLine("Nhap mang:");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Nhap gia tri a[{i}]:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //Ham xuat mang
        static void XuatMang(int[] arr,int length)
        {
            Console.WriteLine("Xuat mang :");
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] +"       ");
            }
            Console.WriteLine();
        }
        //Ham xuat tinh nang hien tai
        static void TinhNang()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("1. Sap xep noi bot (Buble Sort):");
            Console.WriteLine("2. Sap xep lua chon (Selection Sort):");
            Console.WriteLine("3. Tim so nguyen to trong mang da nhap:");
            Console.WriteLine("4. Tim so chinh phuong trong mang da nhap:");
            Console.WriteLine("5. Tim kiem vi tri gia tri phan tu ban muon:");
            Console.WriteLine("6. Tim kiem vi tri gia tri phan tu ban muon sau khi da sap xep mang:");
        }
        //Ham nhap lua chon
        static int LuaChon()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("Nhap lua chon cua ban:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            return num;
        }
        //Ham Sap xep noi bot
        static void SapXepNoiBot(int[] arr,int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        //Ham Sap xep lua chon
        static void SapXepLuaChon(int[] arr,int length)
        {
            for (int i = 0; i < length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        int temp = arr[j];
                        arr[j] = arr[minIndex];
                        arr[minIndex] = temp;
                    };
                }
            }
        }
        //Ham Xuat ra So nguyen to co trong mang
        static void SoNguyenTo(int[] arr,int length)
        {
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] <=2 && arr[i] >=0)
                {
                    Console.Write(arr[i] + "        ");
                }
                else if (arr[i] > 2)
                {
                    for (int j = 1; j <= arr[i]; j++)
                    {
                        if (arr[i] % j == 0)
                        {
                            dem++;
                        };
                    };
                    if (dem <= 2)
                    {
                        Console.Write(arr[i] + "        ");
                    };
                };
                
            };
        }
        //Ham Xuat ra So chinh phuong co trong mang
        static void SoChinhPhuong(int[] arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (   (float)Math.Sqrt(arr[i]) == (int)Math.Sqrt(arr[i])   )
                {
                    Console.Write(arr[i]+"          ");
                };
            }
        }
                //Ham Tim kiem vi tri de sum 2 phan tu = target
        static void Target(int[] arr,int length)
        {
            Console.Write("Nhap gia tri target:");
            int target = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                int pt1 = target - arr[i];
                for (int j = 0; j < length; j++)
                {
                    if (pt1 == arr[j])
                    {
                        Console.WriteLine(i + "   " + j);
                    }
                }
            }
        }
        //Tim kiem vi tri gia tri phan tu ban muon sau khi da sap xep mang
        static void SearchTargetSorted(int[] arr,int length)
        {
            Console.Write("Nhap gia tri target:");
            int target = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                if (arr[i] == target)
                {
                    Console.Write( i + "    ");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap kich co mang:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            NhapMang(arr, length);
            XuatMang(arr, length);
            Console.ForegroundColor = ConsoleColor.Cyan;
            TinhNang();
            Console.ResetColor();
            do
            {
                switch (LuaChon())
            {
                case 1:
                    Console.WriteLine("Sap xep noi bot:");
                    SapXepNoiBot(arr, length);
                    Console.ForegroundColor = ConsoleColor.White;
                    XuatMang(arr, length);
                    Console.ResetColor();
                    break;
                case 2:
                    Console.WriteLine("Sap xep lua chon:");
                    SapXepLuaChon(arr,length);
                    Console.ForegroundColor = ConsoleColor.White;
                    XuatMang(arr, length);
                    Console.ResetColor();
                    break;
                case 3:
                    Console.WriteLine("Tim so nguyen to:");
                    Console.ForegroundColor = ConsoleColor.White;
                    SoNguyenTo(arr, length);
                    Console.ResetColor();
                    break;
                case 4:
                    Console.WriteLine("Tim so chinh phuong:");
                    Console.ForegroundColor = ConsoleColor.White;
                    SoChinhPhuong(arr, length);
                    Console.ResetColor();
                    break;
                case 5:
                    Console.WriteLine("Tim kiem vi tri gia tri phan tu ban muon:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Target(arr, length);
                    Console.ResetColor();
                    break;
                case 6:
                    Console.WriteLine("Tim kiem vi tri gia tri phan tu ban muon sau khi da sap xep mang:");
                    Console.ForegroundColor = ConsoleColor.White;
                    SearchTargetSorted(arr, length);
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nhap lai !");
                    Console.ResetColor();
                    break;
            }

            } while (true);
            
        }
    }
}
