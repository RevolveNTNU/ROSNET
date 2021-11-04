﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using ROSbag_ReadWrite;

namespace ShowCase
{
    class Program
    {

        static void Main(string[] args)
        {
        string currentDirectory = Directory.GetCurrentDirectory();
        string path = Regex.Replace(currentDirectory, "ROSbag-ReadWrite.*", "ROSbag-ReadWrite/bags/acc19-11.bag");

            Reader.Read(path);
            Console.ReadKey();
        }
    }
}
