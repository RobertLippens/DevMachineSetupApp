using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.IO;

namespace DevMachineSetupApp
{
    /// <summary>
    /// Interaction logic for CreateHomeDirectory.xaml
    /// </summary>
    public partial class CreateHomeDirectory : Page
    {
        public CreateHomeDirectory()
        {
            InitializeComponent();
        }

        public void SetupAGitHubAccount(object sender, RoutedEventArgs e)
        {
            if (FileNameIsInvalid())
                this.ErrorSection.Text = "Folder Name contains invalid characters or is empty.\n  Please verify the folder name is alphanumeric.";
            else
            {
                Directory.CreateDirectory(string.Format("C:\\{0}", FolderNameTextbox.Text));
                Window.GetWindow(this).Content = new CreateAGitHubAccount();
            }
        }

        public bool FileNameIsInvalid() {
            Match checkForInvalidChars = Regex.Match(FolderNameTextbox.Text, @"\W|_",RegexOptions.IgnoreCase);

            return (string.IsNullOrEmpty(FolderNameTextbox.Text) || checkForInvalidChars.Success);
        }
    }
}
