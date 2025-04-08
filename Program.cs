using System;

namespace CalculadoraSimples
{
    public class Calculadora
    {
        public double Somar(double numeroUm, double numeroDois)
        {
            return numeroUm + numeroDois;
        }

        public double Subtrair(double numeroUm, double numeroDois)
        {
            return numeroUm - numeroDois;
        }

        public double Multiplicar(double numeroUm, double numeroDois)
        {
            return numeroUm * numeroDois;
        }

        public double Dividir(double numeroUm, double numeroDois)
        {
            if (numeroDois == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return numeroUm / numeroDois;
        }

        public double Potenciar(double numeroUm, double numeroDois)
        {
            return Math.Pow(numeroUm, numeroDois);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Soma: " + calc.Somar(10, 5));
            Console.WriteLine("Subtração: " + calc.Subtrair(10, 5));
            Console.WriteLine("Multiplicação: " + calc.Multiplicar(10, 5));
            Console.WriteLine("Divisão: " + calc.Dividir(10, 5));
            Console.WriteLine("Potência: " + calc.Potenciar(2, 3));
        }
    }
}
