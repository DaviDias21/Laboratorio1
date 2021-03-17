using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Usuario
    {
        private String nome;
        private int idade;
        private float altura;
        private float peso;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public float Altura { get => altura; set => altura = value; }
        public float Peso { get => peso; set => peso = value; }

        public Usuario(String nome_, int idade_, float altura_, float peso_)
        {
            this.Nome = nome_;
            this.Idade = idade_;
            this.Altura = altura_;
            this.Peso = peso_;
        }
    }
}
