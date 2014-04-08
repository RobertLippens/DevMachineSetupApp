using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DevMachineSetupApp
{
    /// <summary>
    /// Interaction logic for CreateAGitHubAccount.xaml
    /// </summary>
    public partial class CreateAGitHubAccount : Page
    {
        public CreateAGitHubAccount()
        {
            InitializeComponent();
        }

        public void OpenGitHubInBrowser(object sender, RoutedEventArgs e)
        {
            var gitHubWindow = new WebBrowser();
            gitHubWindow.Show();
        }

        public void DownloadNewPrograms(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Content = new DownloadNecessaryPrograms();
        }
    }
}
