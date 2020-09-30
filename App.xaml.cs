using System.Diagnostics;
using System.Windows;

namespace ExplorationSingleInstance
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application, ISingleInstanceApp
    {
        public bool ReceiveArguments(string args)
        {
            Debug.WriteLine(args);

            return true;
        }
    }
}