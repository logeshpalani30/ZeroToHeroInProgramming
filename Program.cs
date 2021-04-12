using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using PlayingwithCSharp.FileHandling;

namespace PlayingwithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string exePath =@"C:\ZeroToHeroInProgramming\image.jfif";
                // System.IO.Path.GetDirectoryName(
                //     System.Reflection.Assembly.GetEntryAssembly().Location);

            ImageFileHandling imageFileHandling = new ImageFileHandling();
            imageFileHandling.ReadFileFromLocal(exePath);

        }
    }
}