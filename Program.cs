using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TP8
{
    class Program
    {
        static void Main(string[] args)
        {
          string directorio= @"C:\taller2021\emma\repositorios";
          List <string> listaDeArchivos = Directory.EnumerateFiles(directorio).ToList();

          Console.WriteLine("Lista de archivos de mi directorio elegido");
          foreach (string archivoX in listaDeArchivos)
          {
            Console.WriteLine(archivoX);
          }

          if (!File.Exists(directorio + @"\index.csv"))
          {
                File.Create(directorio + @"\index.csv");
          }

            





          

          
        }
    }
}

