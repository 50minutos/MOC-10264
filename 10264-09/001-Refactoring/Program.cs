using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Escrever();
            Escrever();
            Escrever();

            var p = new Pessoa(1, "ADÃO", 'M');

            p.Acordar();
            p.Comer();
            p.Dormir();

            Aguardar();
        }

        private static void Escrever()
        {
            Console.WriteLine("qualquer coisa");
        }

        private static void Aguardar()
        {
            Console.ReadKey();
        }
    }
}
