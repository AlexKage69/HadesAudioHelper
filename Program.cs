using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HadesAudioHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is generating the VO.h.");
            Header();
            Console.ReadLine();
        }
        /***
         * Allows to generate VO.h using Fmod Bank Tools.zip-2-0-0-1-4-1565765483 Generated VO.txt
         * Directory for VO.txt to become a VO.h
         */
        public static void Header()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\HadesModding\Fmod Bank Tools.zip-2-0-0-1-4-1565765483\wav\VO\VO.txt");
            string[] results = new string[lines.Count() + 6];
            Console.WriteLine("Finish {0} Audio.",lines.Count());
            int index = 0;
            results[0] = "#ifndef _VO_H";
            results[1] = "#define _VO_H";
            results[2] = "";
            foreach (var line in lines)
            {
                results[index + 3] = "#define " + line.ToUpper().Substring(0, line.Length - 4) + " " + index;
                index++;
            }
            results[index + 3] = "";
            results[index + 4] = "#endif";
            results[index + 5] = "";
            string path = @"E:\Games\Hades\AudioTest\Fmod Bank Tools.zip-2-0-0-1-4-1565765483\VO.h";
            if (!File.Exists(path))
            {
                File.Delete(path);
            }
            File.WriteAllLines(path, results);
        }
        /***
         * Allows to rename all audio from Vo-****.ogg to ****.ogg
         * Directory to change for all the Audio you extracted to rename them like the original.
         */
        public static void Renamer()
        {
            string filepath = @"C:\HadesModding\python-fsb5_win64\python-fsb5\out\";
            DirectoryInfo d = new DirectoryInfo(filepath);

            foreach (var file in d.GetFiles("*.ogg"))
            {
                if (file.Name.StartsWith("VO-"))
                {
                    var newName = file.Name.Substring(3);
                    Console.WriteLine(file.DirectoryName + "\\" + newName);
                    Directory.Move(file.FullName, file.DirectoryName + "\\" + newName);
                }
            }
        }
    }
}
