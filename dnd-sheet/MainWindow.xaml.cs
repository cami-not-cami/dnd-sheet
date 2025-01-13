using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dnd_sheet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _aspectRatio = 16.0 / 9.0;
        public MainWindow()
        {
            InitializeComponent();
            
            
        }
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(e.WidthChanged)
            {
                Height =Width / _aspectRatio  ;
            }
            else if(e.HeightChanged)
            {
                Width = Height / _aspectRatio ;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}