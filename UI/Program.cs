using System;
using System.Windows.Forms;
using System.IO;

namespace UI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run((new Common()).GetMainForm());
            }
            catch (Exception e)
            {
                Program.Log(e.ToString());   
            }
        }

        public static void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + Path.DirectorySeparatorChar + "crash.log"))
            {
                sw.WriteLine("[" + DateTime.Now.ToString() + "] " + message);
                MessageBox.Show("Програма некоректно завершила роботу.\nІнформація про завершення програми збережена у файлі crash.log", "Завершення програми", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}