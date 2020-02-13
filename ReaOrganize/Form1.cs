using QSFileReader;
using System;
using System.IO;
using System.Windows.Forms;

namespace ReaOrganize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean didSomething = true;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            string[] exts = new string[] { "*.wav" };



            // find something NOT in RR directory

            PathProcessor pathProc = new PathProcessor(
                            delegate(string path, Boolean load)
                            {
                                try
                                {
                                    string conatiningDir = Path.GetDirectoryName(path);
                                    // is in RR?
                                    Boolean isRR = false;
                                    for (int i = 1; i <= 9; i++)
                                    {
                                        if (conatiningDir.EndsWith("\\RR" + i)) { isRR = true; break; }
                                    }
                                    if (isRR) return (true);

                                    // no
                                    _processFile(path);
                                    didSomething = true;
                                    return (false);//stop?
                                }
                                catch
                                {
                                }

                                return (false);
                            }, exts);

            didSomething = true;
            while (didSomething)
            {
                didSomething = false;
                pathProc.Process(fileFieldAndBrowser1.FileName, true);
            }


            string filename = fileFieldAndBrowser1.FileName;
            textBox1.AppendText(filename);
            textBox1.AppendText(Environment.NewLine);

        }



        void _processFile(string filename)
        {
            // get the folder the file is in
            string path = System.IO.Path.GetDirectoryName(filename);
            // do per code
            moveToSub(path, "CL_HT", "Close");
            moveToSub(path, "RM_HT", "Room");
            moveToSub(path, "OH_HT", "Overhead");
        }



        private void moveToSub(string path, string p, string groupSub)
        {
            textBox1.AppendText("CODE:" + p);
            textBox1.AppendText(Environment.NewLine);

            DirectoryInfo di = null;

            textBox1.AppendText(Environment.NewLine);
            // get files that match code
            for (int i = 1; i < 100; i++)
            {
                string rrFilt = "*" + p + "*_RR" + i + "*.wav";
                string[] fileList = System.IO.Directory.GetFiles(path, rrFilt);
                if (fileList == null || fileList.Length <= 0) break;

                // make group sub
                string sub = System.IO.Path.Combine(path, groupSub);
                textBox1.AppendText("DIR:" + sub);
                if (!System.IO.Directory.Exists(sub))
                    di = System.IO.Directory.CreateDirectory(System.IO.Path.Combine(path, groupSub));

                DirectoryInfo rrDI = Directory.CreateDirectory(System.IO.Path.Combine(sub, "RR" + i.ToString()));

                foreach (var item in fileList)
                {
                    System.IO.File.Move(item, System.IO.Path.Combine(rrDI.FullName, Path.GetFileName(item)));
                }
            }
        }






    }
}
