using System;
using System.Windows.Forms;

namespace ScreenUp
{
    public class Console
    {
        public static string log;
        public static string cache;

        public static void Write(string obj)
        {
            Generate.GenerateTimeStamp();

            log += Generate.TimeStamp + obj + Environment.NewLine;
        }
    }

    public class ConsoleInput
    {
        public static string Input; 

        public static void SetInput(string obj)
        {
            Input = obj;    
        }

        public static void ProofInput()
        {
            if (Input != null)
            {
                if (Input.Contains("--"))
                {
                    if (Input.Contains("save") != Input.Contains(" "))
                    {
                        ConsoleInput.SaveLog();
                    }
                    if (Input.Contains("clear") != Input.Contains(" "))
                    {
                        Console.log = null;
                    }
                }
            }
        }

        public static void SaveLog()
        {                                                                                                                                                                                                               
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Export Log";
            sfd.Filter = "RT Log File (*.lrt)|*.lrt";
            sfd.FileName = DateTime.Now.DayOfYear.ToString();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, Cryption.Encrypt(Console.log));
            }
        }

        public static void OpenLog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Import Log";
            ofd.Filter = "RT Log File (*.lrt)|*.lrt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(ofd.FileName);

                Console.cache = Console.log;
                Console.log = null;
                Console.log = Cryption.Decrypt(text);
            }
        }
    }
}