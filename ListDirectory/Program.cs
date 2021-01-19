using System;
using System.IO;

namespace ListDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                // No arguments, show help and exit.
                Console.WriteLine("No arguments. Get help below.\n");
                ShowHelp();
            }
            else if (!Directory.Exists(FixedPath(args[0])))
            {
                // Directory not exists, print error and exit.
                Console.WriteLine("Directory {0} not exists.", FixedPath(args[0]));
            }
            else
            {
                // Everything ok, walk the tree.
                var rootDir = new DirectoryInfo(FixedPath(args[0]));
                WalkTheTree(rootDir);
            }
        }

        // Fix the problem with arguments ending with \" in paths.
        private static string FixedPath(string dirPath)
        {
            if (dirPath.EndsWith("\""))
            {
                dirPath = dirPath.Substring(0, dirPath.Length - 1);
            }
            return dirPath;
        }

        private static void ShowHelp()
        {
            Console.WriteLine("Lists all files in all subdirectories in human friendly form." +
                "\n\nListDirectory [drive:][path]" +
                "\n\n  [drive:][path]" +
                "\n              Specifies drive, directory to list.\n");
        }

        private static void WalkTheTree(DirectoryInfo rootDir)
        {
            Console.WriteLine(rootDir.FullName + "kuku");
        }
    }
}
