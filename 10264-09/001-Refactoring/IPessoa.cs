using System;
namespace _001_Refactoring
{
    interface IPessoa
    {
        int Codigo { get; set; }
        string Nome { get; set; }
        char Sexo { get; set; }

        void Acordar();
        void Comer();
        void Dormir();
    }
}
