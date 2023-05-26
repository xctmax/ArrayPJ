using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPJ
{
    internal class Arr
    {
        static void NhapMang(int[] arr,int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("Nhap gia tri cua a["+i+"]:" );
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void XuatMang(int[] arr,int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + "    " );
            }
        }
        static void SapXepNoiBot(int[] arr,int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
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
        static void SapXepLuaChon(int[] arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                int minIndex = i;
                for (int j = 0; j < length; j++)
                {
                    if (arr[minIndex] < arr[j])
                    {
                        int temp = arr[minIndex];
                        arr[minIndex] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void Main()
        {
            Console.Write("Nhap kich thuoc mang:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            NhapMang(arr, length);
            Console.WriteLine( "Sap xep noi bot:");
            SapXepLuaChon(arr, length);
            Console.WriteLine( "Mang:" );
            XuatMang(arr, length);
        }
    }
}
