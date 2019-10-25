using POCAttribute.Models;
using System;
using System.IO;

namespace POCAttribute
{
    class Program
    {
        private static readonly string 
            FilePath = @"C:\Proj\HackathonVALIA\src\POCAttribute\POCAttribute\Sample Files\example.txt";
        static void Main(string[] args)
        {
            string line;
            StreamReader file = new StreamReader(FilePath);

            while ((line = file.ReadLine()) != null)
            {
                Empregado empregado = new Empregado(line);
                Console.WriteLine(empregado.Nome);
                Console.WriteLine();
                Console.WriteLine(empregado.Matricula);
                Console.WriteLine();
                Console.WriteLine(empregado.DataNascimento);
                Console.WriteLine();
            }

            file.Close();
            Console.ReadKey();
        }
    }
}
