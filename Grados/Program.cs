using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroDeCalifiaciones libro = new LibroDeCalifiaciones();
            libro.AddCalificacion(97);
            //Probando para hacer un push en githud
            Console.WriteLine("solo para githud");
        }
    }
}
