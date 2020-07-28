using System;
using System.IO.Compression;

namespace IOCompressionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFolder = @"C:\Users\Pavlo\source\repos\IOCompressionProject\bin\Debug\Папка с папкой"; // исходная папка
            string zipFile = @"C:\Users\Pavlo\source\repos\IOCompressionProject\bin\Debug\Папка для архива\ZIPfile.zip"; // сжатый файл (требует удаления, если уже существует)
            string targetFolder = @"C:\Users\Pavlo\source\repos\IOCompressionProject\bin\Debug\Папка для рапакованной папки"; // папка, куда распаковывается файл (требует удаления, если уже существует)

            ZipFile.CreateFromDirectory(sourceFolder, zipFile);
            Console.WriteLine($"Папка «{sourceFolder}» архивирована в файл «{zipFile}»\n\n");

            ZipFile.ExtractToDirectory(zipFile, targetFolder);
            Console.WriteLine($"Файл «{zipFile}» распакован в папку «{targetFolder}»");

            Console.ReadLine();
        }
    }
}