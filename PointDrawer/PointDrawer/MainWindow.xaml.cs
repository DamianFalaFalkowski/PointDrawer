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

namespace PointDrawer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double PointSize = 10;

        private Canvas canvas;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            var canv = new Canvas();
            canv.Width = Convert.ToDouble(SizeTB.Text);
            canv.Height = Convert.ToDouble(SizeTB.Text);
            canv.HorizontalAlignment = HorizontalAlignment.Center;
            canv.VerticalAlignment = VerticalAlignment.Center;
            canvas = canv;
            Grid.SetColumn(canv, 1);
            RootGrid.Children.Add(canv);
        }
       
        private void AddPointButton_Click(object sender, RoutedEventArgs e)
        {
            //Point p = new Point(Convert.ToDouble(PointX.Text), Convert.ToDouble(PointY);
            Rectangle rec = new Rectangle();
            rec.Width = PointSize;
            rec.Height = PointSize;
            rec.Fill = new SolidColorBrush(Colors.Black);
            Canvas.SetLeft(rec, GetRealisticX(Convert.ToDouble(PointX.Text)));
            Canvas.SetTop(rec, GetRealisticY(Convert.ToDouble(PointY.Text)));
            canvas.Children.Add(rec);
        }

        private double GetRealisticX(double primalX)
        {
            return (canvas.Width / 2) + primalX;
        }

        private double GetRealisticY(double primalY)
        {
            return (canvas.Height / 2) - primalY;
        }
    }
}
