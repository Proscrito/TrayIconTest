using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var icoForAppFile = "Resources\\iconfinder_calendar_285670.ico";

            var mainNotify = new NotifyIcon();
            var mainContextMenu = new ContextMenu();

            var mainIOptions = new MenuItem("Настройки", OptionsClick);
            var mainIBase = new MenuItem("База абонентов", BaseClick);
            var mainIAbout = new MenuItem("О программе", AboutClick);
            var mainIExit = new MenuItem("Выход", ExitClick);

            mainContextMenu.MenuItems.AddRange(new MenuItem[] { mainIOptions, mainIBase, mainIExit });


            mainNotify.Icon = new Icon(icoForAppFile);
            mainNotify.Text = "Напоминалка";
            mainNotify.ContextMenu = mainContextMenu;
            mainNotify.Visible = true;

            mainNotify.BalloonTipTitle = "Меню менеджера дней рождений";
            mainNotify.BalloonTipIcon = ToolTipIcon.Info;

            Application.Run();
            mainNotify.Visible = false;

            // Application.Run(new contacts());
        }

        private static void AboutClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void ExitClick(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Закрыть программу ? ", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            { Application.Exit(); }
        }
        private static void BaseClick(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            menuItem.Enabled = false;

            Thread.Sleep(TimeSpan.FromSeconds(2));

            menuItem.Enabled = true;
        }

        private static void OptionsClick(object sender, EventArgs e)
        {
            //options oFrmO = new options();
            //MenuItem j = (MenuItem)Sender;
            //j.Enabled = false;
            //oFrmO.ShowDialog();
            //j.Enabled = true;
            //oFrmO.Dispose();
        }
    }
}
