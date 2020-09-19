using System;
using System.Collections.Generic;
using System.IO;

namespace MoveFiles {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Move Files by Doud Systems");
            string srcDir;
            string trgDir;
            ParseArgs(args, out srcDir, out trgDir);
            var files = Directory.EnumerateFiles(srcDir);
            foreach(var file in files) {
                var filename = Path.GetFileName(file);
                var targetFile = Path.Combine(trgDir, filename);
                Console.WriteLine($" - Moved {file}");
                File.Move(file, targetFile);
            }
            Console.WriteLine("Done.");
        }
        static void ParseArgs(string[] args, out string srcDir, out string trgDir) {
            srcDir = args[0];
            trgDir = args[1];
        }
    }
}
