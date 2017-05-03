using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._2804.HomeTask_FileSystemTree_
{
    class FileSystemTree
    {
        string path;//= Directory.GetCurrentDirectory();
        public DirectoryInfo dI;// = new DirectoryInfo(path);
        DirectoryInfo[] dirs;
        DirectoryInfo[] temp;
        bool hasSubFolders = true;
        StringBuilder pad = new StringBuilder();        

        public FileSystemTree()
        {
            path = Directory.GetCurrentDirectory();
            dI = new DirectoryInfo(path);
            dirs = dI.GetDirectories();
            temp = dirs;
            //pad.Append('-');
        }
        public void ShowDirs()
        {
            while (hasSubFolders)
            {
                ShowDir();
            }

        }
        public void ShowDir()
        {
            foreach (var dir in temp)
            {
                Console.WriteLine(dir.Name);
                if (dir.GetDirectories() != null)
                {
                    hasSubFolders = true;
                    temp = dir.GetDirectories();
                }
                else
                {
                    hasSubFolders = false;
                }
            }
        }
        public void ShowDirRecurs()
        {            
            foreach (var dir in temp)
            {
                
                Console.WriteLine(pad + dir.Name);
                if (dir.GetDirectories() != null)
                {pad.Append('-');
                    temp = dir.GetDirectories();
                    ShowDirRecurs();                    
                }
            }

            if (pad.Length != 0)
                pad.Remove(0, 1);
        }
    }
}