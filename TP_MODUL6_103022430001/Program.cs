// See https://aka.ms/new-console-template for more information
using System;
namespace TP_MODUL6_103022430001
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack track1 = new SayaMusicTrack("Pirates of the Carabian");

            Console.WriteLine("Memulai pengujian overflow...");

            for(int i = 0; i < 250; i++)
            {
                track1.IncreasePlayCount(10000000);

                if(i % 50 == 0)
                {
                    track1.PrintTrackDetails();
                }
            }
            Console.WriteLine("Pengujian selesai.");

            Console.ReadLine();
        }
    }
}