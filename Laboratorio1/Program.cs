using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario01 = new Usuario("Bob Nelson", 37, 1.7f, 78);
            Usuario usuario02 = new Usuario("Testolfo Rocha", 43, 1.65f, 60);
            Usuario usuario03 = new Usuario("Lisa Leite", 22, 1.72f, 92);

            CalculoIMC(usuario01);
            CalculoIMC(usuario02);
            CalculoIMC(usuario03);

            Console.ReadLine();
        }

        static void CalculoIMC(Usuario usuario_)
        {
            float imc = (usuario_.Peso) / ((usuario_.Altura) * (usuario_.Altura));

            Console.WriteLine();

            if(imc < 18.5f)
            {
                Console.WriteLine("O usuário " + usuario_.Nome + " está abaixo do peso.");
            }
            else if(imc >= 18.5f && imc < 25)
            {
                Console.WriteLine("O usuário " + usuario_.Nome + " está no peso normal.");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("O usuário " + usuario_.Nome + " está com sobrepeso.");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("O usuário " + usuario_.Nome + " está com obesidade grau I.");
            }
            else if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("O usuário " + usuario_.Nome + " está com obesidade grau II.");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("O usuário " + usuario_.Nome + " está com obesidade graus III e IV.");
            }

            if(imc < 18.5f || imc >= 25)
            {
                CalculoMetaDePeso(imc, usuario_.Altura, usuario_.Peso, usuario_.Nome);
            }
        }

        static void CalculoMetaDePeso(float imc_, float altura_, float peso_, String nome_)
        {
            float imcIdeal;
            float pesoIdeal;

            if(imc_ < 18.5f)
            {
                imcIdeal = 18.5f;
            }
            else
            {
                imcIdeal = 25;
            }

            pesoIdeal = imcIdeal * altura_ * altura_;

            if(pesoIdeal > peso_)
            {
                Console.WriteLine("O usuário " + nome_ + " precisa ganhar " + (pesoIdeal - peso_) + " kg para atingir o peso ideal.");
            }
            else
            {
                Console.WriteLine("O usuário " + nome_ + " precisa perder " + (peso_ - pesoIdeal) + " kg para atingir o peso ideal.");
            }

        }
    }
}
