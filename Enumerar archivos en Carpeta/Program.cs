using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerar_archivos_en_Carpeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string extension_a_enumerar = ".";

            // Directorio desde donde corre el programa
            string path = AppDomain.CurrentDomain.BaseDirectory;

            // Consigue en un array de strings todos los directorios de los archivos de la dirección que paso como argumento
            string[] archivos_encontrados = Directory.GetFiles(path);

            // Contador de archivos
            int n = 0;

            Console.WriteLine("Ingrese la extensión de archivos que quiere enumerar");
            extension_a_enumerar += Console.ReadLine();
            

            // Loopeo el array de string
            foreach (var archivo in archivos_encontrados)
            {
                FileInfo fi = new FileInfo(archivo);
                // Consigo la extension del archivo más información https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-get-a-file-extension-in-C-Sharp/
                string extension = fi.Extension;
                

                if (extension == (extension_a_enumerar))
                {
                    
                    n++;
                    if(!File.Exists(Path.GetDirectoryName(fi.FullName) + "\\" + n + ".nsp"))
                    {
                        System.IO.File.Move(fi.FullName, Path.GetDirectoryName(fi.FullName) + "\\" + n + ".nsp");
                    }
                    
                }

                

                // Path.FileName regresa sólo el nombre y extensión de archivo
                //Console.WriteLine(Path.GetFileName(archivo));
                
            }

            Console.WriteLine("\nTotal de archivos de extensión " + extension_a_enumerar + " encontrados: " + n);
            //for (int i = 0; i < archivos_encontrados.Length; i++)
            //{

            //    if (Path.GetFileName(archivos_encontrados[i]) != "Enumerar archivos en Carpeta.exe" || Path.GetFileName(archivos_encontrados[i]) != "Enumerar archivos en Carpeta.exe.config" || Path.GetFileName(archivos_encontrados[i]) != "Enumerar archivos en Carpeta.pdb")
            //        File.Move(archivos_encontrados[i], Path.GetDirectoryName(path) + "\\" + (i + 1).ToString());
            //    else Console.WriteLine(archivos_encontrados[i]);
            //}


            // Resolver el problema consiguiendo el index y sumando 1 a eso y convertirlo en string
            //foreach (string archivo in archivos_encontrados)
            //{
            //    Array.FindIndex()
            //}

            Console.ReadLine();
        }
    }
}
