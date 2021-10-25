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

namespace WpfDataBinding
{

    class Car
    {
        public int Speed { get; set; }

        public Color Color { get; set; }

        public Car(int speed, Color color)
        {
            Speed = speed;
            Color = color;
        }
    }

    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Car> list = new List<Car>()
            {
                new Car(1, Color.FromRgb(255, 0, 0)),
                new Car(2, Color.FromRgb(255, 0, 0)),
                new Car(3, Color.FromRgb(255, 0, 0)),
            };

            this.DataContext = list;
        }
    }
}
