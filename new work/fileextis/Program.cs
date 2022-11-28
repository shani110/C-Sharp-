using System;
using System.IO;
namespace fileextis
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\data.txt";
            string path2  = ("D:\\data1.txt");

            File.Copy(path, path2, true);
        }
    }
}
