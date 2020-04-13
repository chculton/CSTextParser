using System;
using System.IO;
using System.Collections.Generic;

namespace CSFileParser
{
    class Program
    {
        string tokeniser;
        List<string> parsedData;

        static void Main(string[] args)
        {
            string workingPath = Environment.CurrentDirectory;
            string projectPath = Directory.GetParent(workingPath).Parent.FullName;
            string filePath = Directory.GetParent(projectPath).Parent.FullName + "\\FileToParse.txt";

            Program currentProgram = new Program();
            currentProgram.tokeniser = ":";
            currentProgram.parsedData = new List<string>();
            currentProgram.parseFile(filePath, currentProgram.parsedData);

            for (int i = 0; i < currentProgram.parsedData.Count; i++)
            {
                Console.WriteLine(currentProgram.parsedData[i]);
            }
        }

        void parseFile(string _filePath, List<string> _storage)
        {
            string[] fileLines = File.ReadAllLines(_filePath);

            for (int i = 0; i < fileLines.Length; i++)
            {
                string[] tempArray = fileLines[i].Split(tokeniser);
                _storage.Add(tempArray[1]);
            }
        }
    }
}
