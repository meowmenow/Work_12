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

namespace Адовые_объекты__25
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Points Point;
        private Quadro quadro;
        private QuadroFill quadroFill;
        private void Sozidat_Initialized(object sender, EventArgs e)
        {
            Point = new Points(25, 30);
            Point.XYZ(ref cvas);
            quadro = new Quadro(30, 30);
            quadro.XYZ(ref cvas);
            quadroFill = new QuadroFill(30, 30);
            quadroFill.XYZ(ref cvas);
            Point.Hide();
            quadro.Hide();
            quadroFill.Hide();
        }

        private void Letsgo_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int x = Point.x1;
            int y = Point.y1;

            if (e.Key == Key.W)
            {
                if (y - 5 >= -201)
                {
                    Point.MoveXY(x, y - 3);
                    quadro.MoveXY(x, y - 3);
                    quadroFill.MoveXY(x, y - 3);
                }
            }
            if (e.Key == Key.S)
            {
                if (y + 250 <= 460)
                {
                    Point.MoveXY(x, y + 3);
                    quadro.MoveXY(x, y + 3);
                    quadroFill.MoveXY(x, y + 3);
                }
            }
            if (e.Key == Key.A)
            {
                if (x - 5 >= -83)
                {
                    Point.MoveXY(x - 3, y);
                    Point.MoveXY(x - 3, y);
                    Point.MoveXY(x - 3, y);
                }
            }
            if (e.Key == Key.D)
            {
                if (x + 5 <= 225)
                {
                    Point.MoveXY(x + 3, y);
                    Point.MoveXY(x + 3, y);
                    Point.MoveXY(x + 3, y);
                }
            }
            if (e.Key == Key.Up)
            {
                if (y - 5 >= -201)
                {
                    Point.MoveXY(x, y - 3);
                    quadro.MoveXY(x, y - 3);
                    quadroFill.MoveXY(x, y - 3);
                }
            }
            if (e.Key == Key.Down)
            {
                if (y + 250 <= 460)
                {
                    Point.MoveXY(x, y + 3);
                    quadro.MoveXY(x, y + 3);
                    quadroFill.MoveXY(x, y + 3);
                }
            }
            if (e.Key == Key.Left)
            {
                if (x - 5 >= -83)
                {
                    Point.MoveXY(x - 3, y);
                    Point.MoveXY(x - 3, y);
                    Point.MoveXY(x - 3, y);
                }
            }
            if (e.Key == Key.Right)
            {
                if (x + 5 <= 225)
                {
                    Point.MoveXY(x + 3, y);
                    Point.MoveXY(x + 3, y);
                    Point.MoveXY(x + 3, y);
                }
            }

        }

        private void teleport_Click(object sender, RoutedEventArgs e)
        {
            Point.MoveXY(Convert.ToInt32(coord_X.Text), Convert.ToInt32(coord_Y.Text));
            quadro.MoveXY(Convert.ToInt32(coord_X.Text), Convert.ToInt32(coord_Y.Text));
            quadroFill.MoveXY(Convert.ToInt32(coord_X.Text), Convert.ToInt32(coord_Y.Text));
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            Point.Show();
        }

        private void Mongol_Click(object sender, RoutedEventArgs e)
        {
            quadro.Show();
        }

        private void ColorMongol_Click(object sender, RoutedEventArgs e)
        {
            quadroFill.Show();
        }

        private void Hide_Point_Click(object sender, RoutedEventArgs e)
        {
            Point.Hide();
        }

        private void Hide_Mongol_Click(object sender, RoutedEventArgs e)
        {
            quadro.Hide();
        }

        private void Hide_Color_Mongol_Click(object sender, RoutedEventArgs e)
        {
            quadroFill.Hide();
        }

        private void coord_X_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (coord_X.Text.Length == 0)
                tp.IsEnabled = false;
            else
                tp.IsEnabled = true;
        }

        private void coord_Y_TextChanged(object sender, TextChangedEventArgs e)
        {
            {
                if (coord_Y.Text.Length == 0)
                    tp.IsEnabled = false;
                else
                    tp.IsEnabled = true;
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            {
                this.Close();
            }
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваш друг черканул вам в тетради? Не беда! Cоздайте из точки многоугольник, а потом закрасьте его! Разработка от горе-дизайнера Бирюкова Георгия ИСП-23");
        }

        private void Anek_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Карлсон залетел и ждёт малыша");
        }

        private void skyrim_Click(object sender, RoutedEventArgs e)
        {
            Point.Show();
            quadro.Show();
        }

        private void stels_Click(object sender, RoutedEventArgs e)
        {
            Point.Hide();
            quadro.Hide();
            quadroFill.Hide();
        }
    }



    
}
