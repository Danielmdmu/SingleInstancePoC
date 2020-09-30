using System;

namespace ExplorationSingleInstance
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new App();
            var singleInstanceController = new SingleInstanceController("{44A3AF74-F591-455C-81C8-B798FD6701ED}", args, app);

            //app.InitializeComponent();
            app.Run(new MainWindow());

            singleInstanceController.StopServer();
            Environment.Exit(0);
        }
    }
}