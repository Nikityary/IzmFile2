using System;
using System.IO;

namespace FileIzm2
{
    internal class IzmFileNew
    {
        public string java(string path = @"C:\Users")
        {
            FileInfo g = new FileInfo(path);
            string nl = ($"{g.LastWriteTime}");
            return nl;
        }
    }
}
