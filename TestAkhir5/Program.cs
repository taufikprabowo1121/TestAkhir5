using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAkhir5
{
    class Program
    {
        /*
        static double SafeDivision(double x, double y)
        {
            if(y==0)
            {
                throw new System.DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }
        */

        static void info()
        {
            Console.WriteLine("Menu Kalkulator Silahkan Pilih :");
            Console.WriteLine("A. Pembagian");
            Console.WriteLine("B. Perkalian");
            Console.WriteLine("C. Penggurangan");
            Console.WriteLine("D. Penambahan");
            Console.WriteLine("esc : Untuk Keluar Aplikasi");
            Console.WriteLine("Choose (A/B/C/D/esc) : \n");
            
            
        }
        static void Main(string[] args)
        {
            info();
  
            ConsoleKeyInfo cki = Console.ReadKey();
            while (cki.Key != ConsoleKey.Escape)
            {
                if (cki.Key == ConsoleKey.A)
                {
                    Console.WriteLine("Selamat Datang Di Pembagian");
                    try
                    {
                        Console.Write("Masukan Angka Pertama: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Masukan Angka kedua: ");
                        double b = double.Parse(Console.ReadLine());
                        double total = a / b;
                        Console.WriteLine("Total Perhitungan :" + total);
                        Console.WriteLine("\n");

                    }

                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nException message: {0}", ex.Message);
                        Console.WriteLine("Exception stack trace: {0}", ex.StackTrace);
                    }

                    finally
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        info();
                        cki = Console.ReadKey();
                    }
                }
                /*----------------------------------------- end of if --------------------------------- */
                else if(cki.Key == ConsoleKey.B)
                {
                    Console.WriteLine("Selamat Datang Di Perkalian");
                    try
                    {
                        Console.Write("Masukan Angka Pertama: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Masukan Angka kedua: ");
                        double b = double.Parse(Console.ReadLine());
                        double total = a * b;
                        Console.WriteLine("Total Perhitungan :" + total);
                        Console.WriteLine("\n");

                    }

                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nException message: {0}", ex.Message);
                        Console.WriteLine("Exception stack trace: {0}", ex.StackTrace);
                    }

                    finally
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        info();
                        cki = Console.ReadKey();
                    }
                }
                /* endif of Perkalian */
                else if (cki.Key == ConsoleKey.C)
                {
                    Console.WriteLine("Selamat Datang Di Pengurangan");
                    try
                    {
                        Console.Write("Masukan Angka Pertama: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Masukan Angka kedua: ");
                        double b = double.Parse(Console.ReadLine());
                        double total = a - b;
                        Console.WriteLine("Total Perhitungan :" + total);
                        Console.WriteLine("\n");

                    }

                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nException message: {0}", ex.Message);
                        Console.WriteLine("Exception stack trace: {0}", ex.StackTrace);
                    }

                    finally
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        info();
                        cki = Console.ReadKey();
                    }
                }
                /* endif of Pegurangan */
                else if (cki.Key == ConsoleKey.D)
                {
                    Console.WriteLine("Selamat Datang Di Penambahan");
                    try
                    {
                        Console.Write("Masukan Angka Pertama: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Masukan Angka kedua: ");
                        double b = double.Parse(Console.ReadLine());
                        double total = a + b;
                        Console.WriteLine("Total Perhitungan :" + total);
                        Console.WriteLine("\n");

                    }

                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nException message: {0}", ex.Message);
                        Console.WriteLine("Exception stack trace: {0}", ex.StackTrace);
                    }

                    finally
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        info();
                        cki = Console.ReadKey();
                    }
                }
                /* end of penambahan */
                else
                {
                    Console.WriteLine("Perintah Tidak Di Ketahui");
                 

                

                        Console.ForegroundColor = ConsoleColor.Gray;
                        info();
                        cki = Console.ReadKey();
                    
                }
                /*end perintah tidak di ketahui */

            }
        }
    }
}
