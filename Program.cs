using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor.BL;

namespace TextEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            MessageServices service = new MessageServices();
            FileManager manager = new FileManager();

            MainPresenter presenter = new MainPresenter(form, manager, service);
            
            Application.Run(form);
        }
    }
}
