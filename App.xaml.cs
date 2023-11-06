namespace Tarea1._3
{
    public partial class App : Application
    {

        static Controller.DataBaseSQLite dataBaseSQLite;

        public static Controller.DataBaseSQLite DataBaseSQLite
        {
            get
            {
                if (dataBaseSQLite == null)
                {
                    dataBaseSQLite = new Controller.DataBaseSQLite(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PM02.db3"));
                }

                return dataBaseSQLite;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}