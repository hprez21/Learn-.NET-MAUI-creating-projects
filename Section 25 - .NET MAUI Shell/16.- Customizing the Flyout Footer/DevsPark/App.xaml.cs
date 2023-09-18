using DevsPark.MVVM.Pages;

namespace DevsPark
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}