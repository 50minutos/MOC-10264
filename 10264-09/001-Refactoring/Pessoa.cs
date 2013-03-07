using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_Refactoring
{
    class Pessoa : _001_Refactoring.IPessoa 
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private char sexo;

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public Pessoa(int codigo, string nome, char sexo)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.sexo = sexo;
        }

        public void Acordar()
        {
            Console.WriteLine("Acordar");
        }

        public void Comer()
        {
            Console.WriteLine("Comer");
        }

        public void Dormir()
        {
            Console.WriteLine("Dormir"); 
        }
    }
}
