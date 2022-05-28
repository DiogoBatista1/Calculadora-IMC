using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basics 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua altura?");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quanto você pesa?");
            double peso = Convert.ToDouble(Console.ReadLine());

            altura = altura / 100;
            
            double resultado = peso / (altura * altura);
            string NewResultado = resultado.ToString("0.00");
            switch(resultado)
            {
                case <= 16: 
                    Console.WriteLine($"O seu IMC é de {NewResultado}, você está muito abaixo do peso. \n O que pode acontecer: \n Queda de cabelo, infertilidade, ausência menstrual.");
                    break;
                case <= 18:
                    Console.WriteLine($"O seu IMC é de {NewResultado}, você está abaixo do peso. \n O que pode acontecer: \n Fadiga, stress, ansiedade.");
                    break;
                case <= 24:
                    Console.WriteLine($"O seu IMC é de {NewResultado}, o seu peso está normal. \n O que pode acontecer: \n Menor risco de doenças cardíacas e vasculares");
                    break;
                case <= 29:
                    Console.WriteLine($"O seu IMC é de {NewResultado}, você está acima do peso. \n O que pode acontecer: \n Fadiga, má circulação, varizes");
                    break;
                case <= 34:
                    Console.WriteLine($"O seu IMC é de {NewResultado}, você está com obesidade grau I. \n O que pode acontecer: \n Diabetes, angina, infarto, aterosclerose");
                    break;
                case <= 39:
                    Console.WriteLine($"O seu IMC é de {NewResultado}, você está com obesidade grau II. \n O que pode acontecer: \n Apneia do sono, falta de ar");
                    break;
                case <= 40:
                    Console.WriteLine($"O seu IMC é de {NewResultado}, você está com obesidade grau III. \n O que pode acontecer: \n Refluxo, dificuldade para se mover, escaras, diabetes, infarto, AVC");
                    break;
                default:
                    Console.WriteLine($"O seu imc é de {NewResultado}");
                    break;
            }       
        }
    }
}