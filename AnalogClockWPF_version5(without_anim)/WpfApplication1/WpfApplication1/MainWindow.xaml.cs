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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            //dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dispatcherTimer.Start();
            /*//00 - 24
            //0 - 60
            //0 - 60
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            //12 h - 360 degr -> 1h - 30d
            //60m - 1h - 30d
            double hourAngle = (DateTime.Now.Hour + (DateTime.Now.Minute / 60d)) * 30;
            Console.WriteLine(hourAngle);

            ((RotateTransform)((TransformGroup)hoursArrow.RenderTransform)
                .Children[1]).Angle = hourAngle;


            //60 - 360 degr -> 1m - 6d
            double minAngle = DateTime.Now.Minute * 6;
            Console.WriteLine(minAngle);

            ((RotateTransform)((TransformGroup)minuteArrow.RenderTransform)
                .Children[1]).Angle = minAngle;

            int sec = DateTime.Now.Second;

            double secAngle = sec * 6;
            Console.WriteLine(secAngle);

            //Sec Transform
            ((RotateTransform)((TransformGroup)secondArrow.RenderTransform)
                .Children[1]).Angle = secAngle;*/

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            double hourAngle = (DateTime.Now.Hour + (DateTime.Now.Minute / 60d)) * 30;
            //Console.WriteLine(hourAngle);
            ((RotateTransform)((TransformGroup)hoursArrow.RenderTransform)
                .Children[1]).Angle = hourAngle;

            double minAngle = DateTime.Now.Minute * 6;
            //Console.WriteLine(minAngle);
            ((RotateTransform)((TransformGroup)minuteArrow.RenderTransform)
                .Children[1]).Angle = minAngle;

            int sec = DateTime.Now.Second;
            double secAngle = sec * 6;
            //Console.WriteLine(secAngle);
            ((RotateTransform)((TransformGroup)secondArrow.RenderTransform)
                .Children[1]).Angle = secAngle;
        }
    }
}
