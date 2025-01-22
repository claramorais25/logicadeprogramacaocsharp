using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            char letras = 'A';
            string nome = "Joao";
            float temperatura = 36.5f;
            double salario = 12345.67;
            bool estaChovendo = true;

            // Alterando as variaveis
            letras = 'B';
            nome = "Maria";
            temperatura = 37.0f;
            salario = 15000.50;
            estaChovendo = false;

            // Constante
            const char simbolo = '$';
            const string saudacao = "Bem-vindo ao C#!";
            const float pi = 3.14159f;
            const double altura = 1.75;
            const bool eVerdade = false;

            //char simbolo = '#';

            Console.WriteLine("valores originais:");
            Console.WriteLine($"Letra: {letras}");
            Console.WriteLine($"Nome: {nome} ");
            Console.WriteLine($"temperatura: {temperatura}");
            Console.WriteLine($"salario: {salario}");
            Console.WriteLine($"Está Chovendo? {estaChovendo}");
            Console.WriteLine($"Simbolo: {simbolo} ");
            Console.WriteLine($"saudação: {saudacao}");
            Console.WriteLine($"Pi: {pi}");
            Console.WriteLine($"Altura: {altura} ");
            Console.WriteLine($"é verdade? {eVerdade} ");
            Console.ReadLine();
        }
    }
}
