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
using System.Drawing;
using System.Drawing.Printing;
using static System.Net.Mime.MediaTypeNames;

namespace DKR_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();    
            image1.Visibility = Visibility.Hidden;
            image2.Visibility = Visibility.Hidden;
            image3.Visibility = Visibility.Hidden;
            image4.Visibility = Visibility.Hidden;
            image5.Visibility = Visibility.Hidden;
        }
        

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            image1.Visibility = Visibility.Visible;
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            image2.Visibility = Visibility.Visible;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            image3.Visibility = Visibility.Visible;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            image4.Visibility = Visibility.Visible;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            image5.Visibility = Visibility.Visible;
        }
        int p = 6; 
        int lx = 5, ly = 5; 
        
        int i;

        
        int X = 50, Y = 50;
        private void DrawPart(Graphics g, int lx, int ly)
        {
            g.DrawLine(Pens.Black, X, Y, X + lx, Y + ly);
            X = X + lx;
            Y = Y + ly;
        }
        void a(int i, Graphics g)
        {
            if (i > 0)
            {
                d(i - 1, g);
                
                DrawPart(g, +lx, 0);
                a(i - 1, g);
                
                
                DrawPart(g, 0, ly);
                a(i - 1, g);
                DrawPart(g, -lx, 0);
                c(i - 1, g);
            }
        }
        void b(int i, Graphics g)
        {
            if (i > 0)
            {
                c(i - 1, g);
                DrawPart(g, -lx, 0);
                b(i - 1, g);
                DrawPart(g, 0, -ly);
                b(i - 1, g);
                DrawPart(g, lx, 0);
                d(i - 1, g);
            }
        }


        public int widht = 250;
        private void up_Click(object sender, RoutedEventArgs e)
        {
            image1.Width +=50;
            image1.Height+=50;
            image2.Width += 50;
            image2.Height += 50;
            image3.Width += 50;
            image3.Height += 50;
            image4.Width += 50;
            image4.Height += 50;


        }

        void c(int i, Graphics g)
        {
            if (i > 0)
            {

                b(i - 1, g);
                DrawPart(g, 0, -ly);
                c(i - 1, g);
                DrawPart(g, -lx, 0);
                c(i - 1, g);
                DrawPart(g, 0, ly);
                a(i - 1, g);
            }
        }

        void d(int i, Graphics g)
        {
            if (i > 0)
            {
                a(i - 1, g);
                DrawPart(g, 0, ly);
                d(i - 1, g);
                DrawPart(g, lx, 0);
                d(i - 1, g);
                DrawPart(g, 0, -ly);
                b(i - 1, g);
            }
        }
    }
}
