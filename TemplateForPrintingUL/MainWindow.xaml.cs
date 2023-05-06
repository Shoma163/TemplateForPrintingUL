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

namespace TemplateForPrintingUL
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog prnt = new PrintDialog();

            if (prnt.ShowDialog() == true)
            {
                Size pageSize = new Size(prnt.PrintableAreaWidth, prnt.PrintableAreaHeight);
                PrintCanvas.Measure(pageSize);
                PrintCanvas.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));
                prnt.PrintVisual(PrintCanvas, "Printing Canvas");
            }
            Close();
        }
    }
}
