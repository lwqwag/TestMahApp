using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.SimpleChildWindow;

namespace TestMahApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var result = await this.ShowChildWindowAsync<bool>(new MyDialog{ IsModal = true, AllowMove = true }, ChildWindowManager.OverlayFillBehavior.FullWindow);
          
        }
    }
}
