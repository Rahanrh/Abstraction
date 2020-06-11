using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*MatKul matkul;
            matkul = new SO();
            matkul.Jadwal();

            Console.WriteLine();
            matkul = new HS();
            matkul.Jadwal();*/

            IMataKuliah matkul;
            matkul = new SO();
            matkul.Jadwal();

            Console.WriteLine();
            matkul = new HS();
            matkul.Jadwal();
            Console.ReadKey();
        }
    }
}
