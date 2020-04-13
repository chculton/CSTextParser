using System;
using System.IO;

namespace CSFileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filePath = Environment.CurrentDirectory;
            //string filePAth = Path.Combine(Path.GetFullPath);
            //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "//FileToParse.txt");
            //string filePath = Path.GetFullPath("//FileToParse.txt");
            //filePath += "//FileToParse.txt";
            //string filePath = AppDomain.CurrentDomain.BaseDirectory + @"/FileTpParse.txt";
            //string filePath = System.IO.Directory.GetFiles("../../FileTpParse.txt");
            string workingPath = Environment.CurrentDirectory;
            string projectPath = Directory.GetParent(workingPath).Parent.FullName;
            string filePath = Directory.GetParent(projectPath).Parent.FullName + "\\FileToParse.txt";

            Program currentProgram = new Program();
            currentProgram.parseFile(filePath);

            Console.WriteLine(filePath);
        }

        void parseFile(string _filePath)
        {
            string[] fileLines = File.ReadAllLines(_filePath);
        }
    }
}
