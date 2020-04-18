using System.Windows;
using MahApps.Metro.SimpleChildWindow;

namespace TestMahApp
{
    /// <summary>
    /// MyDialog.xaml 的交互逻辑
    /// </summary>
    public partial class MyDialog 
    {
        public MyDialog()
        {
            InitializeComponent();
        }
        private void OkButtonOnClick(object sender, RoutedEventArgs e)
        {
            this.Close(CloseReason.Ok, true);
        }

        private void CloseSec_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close(CloseReason.Cancel, false);
        }
    }
}
