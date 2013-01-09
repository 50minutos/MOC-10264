using System;
namespace _001_Refactoring
{
    interface IPessoa
    {
        string Acordar();
        int Codigo { get; set; }
        string Comer();
        string Dormir();
        string Nome { get; set; }
    }
}
