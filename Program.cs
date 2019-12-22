using System;

namespace ClassDanObject__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            String NamaAnda;
            Keterangan Orang = new Keterangan();

            Console.Write("Masukkan Nama Anda : "); NamaAnda = Console.ReadLine();

            Orang.Nama(NamaAnda);

            Console.ReadLine();
        }
    }
}
