using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIGroupProject
{
    class MainClass
    {
        static void Main(string[] args)
        {
            HashSet<Professor> profs = new HashSet<Professor>();
            HashSet<Course> courses = new HashSet<Course>();
            string file;
            if (args.Length == 0)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "All stuff|*.*";
                dlg.ShowDialog();
                file = dlg.FileName;
                if (file.Trim().Length == 0)
                {
                    return;
                }
                dlg.Dispose();
            }
            else { file = args[0]; }

            string toRead = File.ReadAllText(file);
            string line = "";
            int lineNum = 0;
            int i = 0;

            while (i < toRead.Length)
            {
                if (toRead[i] != '\n')
                    line += toRead[i];
                else
                {
                    if (line.Length != 0)
                    {
                        List<string> info = line.Split(',').ToList();
                        if (lineNum != 0)
                        {
                            Course c = new Course(info[0], Int32.Parse(info[1]));
                            Professor p = new Professor(info[2], Int32.Parse(info[3]));
                            courses.Add(c);
                            profs.Add(p);
                        }
                        line = "";
                    }
                    lineNum++;
                }
                i++;
            }

        }
    }
}
