namespace WpfTemplates
{
    public class Test
    {
        private readonly MainWindow _mainWindow;

        public Test(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            _mainWindow.S();
        }
    }
}
