using System;
using System.IO;
using System.Text;

namespace Experimento1
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\teste";
            string arquivo = "C:\\teste\\teste.txt";
            //CriarPasta
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine(folderPath);
            }
            //Verificar Se Existe
            if (Directory.Exists(folderPath))
            {
                Console.WriteLine("Esta Pasta já existe: " + folderPath);
            }
            
            //Escrever texto no ficheiro
            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Bem-Vindo!!");
                    Console.WriteLine("Ficheiro" + arquivo + "criado com sucesso!");

                }
            }
            else
            {
                Console.WriteLine("Ficheiro Já Existe!");
                File.Delete(arquivo);
            }
        }
    }
}
