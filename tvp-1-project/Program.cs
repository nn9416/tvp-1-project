using System;
using System.Windows.Forms;

namespace tvp_1_project
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppSettings.CreateDirectories();
            AppSettings.CreateAdmin();

            var loginView = new View.FLogin();
            var loginRepository = new Model.LoginRepository();
            var loginPresenter = new Presenter.PLogin(loginView, loginRepository);

            if (loginView.ShowDialog() == DialogResult.OK)
            {
                //var mainView = new View.FMain();
                //var mainRepository = new Model.DataRepository();
                //var mainPresenter = new Presenter.PMain(mainView, mainRepository);
                //Application.Run(mainView);
            }
        }
    }
}
