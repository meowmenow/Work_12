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
    class Points
    {
        private int x;
        private int y;
        protected Polygon tochka;
        private Brush color;

        public Points(int x1, int y1)
        {
            x = x1;
            y = y1;
            tochka = new Polygon();
            tochka.Stroke = Brushes.Aquamarine;
            tochka.Fill = Brushes.Aquamarine;
            tochka.StrokeThickness = 3;
            tochka.Margin = new Thickness(x, y, 0, 0);
            tochka.Points.Add(new Point(100, 100));
            tochka.Points.Add(new Point(105, 100));
            tochka.Points.Add(new Point(105, 105));
            tochka.Points.Add(new Point(100, 105));

        }
        public void XYZ(ref Canvas canvas)
        {
            canvas.Children.Add(tochka);
        }
        public int x1
        {
            get { return x; }
            set { x = value; }
        }
        public int y1
        {
            get { return y; }
            set { x = value; }
        }
        public void Show()
        {
            tochka.Visibility = Visibility.Visible;
        }
        public void Hide()
        {
            tochka.Visibility = Visibility.Hidden;
        }
        public void MoveXY(int newx, int newy)
        {
            x = newx; y = newy;
            tochka.Margin = new Thickness(x, y, 0, 0);
        }


    }
    class Quadro : Points
    {
        private int x;
        private int y;
        protected Polygon polygonq;
        private Polygon polygon;
        private Brush color;
        public Quadro(int x1, int y1) : base(x1, y1)
        {
            x = x1;
            y = y1;
            polygonq = new Polygon();
            polygonq.Stroke = Brushes.Aquamarine;
            polygonq.StrokeThickness = 5;
            polygonq.Points.Add(new Point(200, 200));
            polygonq.Points.Add(new Point(400, 200));
            polygonq.Points.Add(new Point(350, 100));
            polygonq.Points.Add(new Point(150, 100));

        }
        public new void XYZ(ref Canvas canvas)
        {
            canvas.Children.Add(polygonq);
        }
        public int x1
        {
            get { return x; }
            set { x = value; }

        }
        public int y1
        {
            get { return y; }
            set { y = value; }
        }
        public new void Show()
        {
            polygonq.Visibility = Visibility.Visible;
        }
        public new void Hide()
        {
            polygonq.Visibility = Visibility.Hidden;
        }
        public new void MoveXY(int xCord, int yCord)
        {
            x1 = xCord;
            y1 = yCord;
            polygonq.Margin = new Thickness(x, y, 0, 0);
        }


    }
    class QuadroFill : Points
    {
        private int x;
        private int y;
        protected Polygon polygonq;
        private Polygon polygon;
        private Brush color;
        public QuadroFill(int x1, int y1) : base(x1, y1)
        {
            x = x1;
            y = y1;
            polygonq = new Polygon();
            polygonq.Stroke = Brushes.Aquamarine;
            polygonq.Fill = Brushes.Aqua;
            polygonq.StrokeThickness = 5;
            polygonq.Points.Add(new Point(200, 200));
            polygonq.Points.Add(new Point(400, 200));
            polygonq.Points.Add(new Point(350, 100));
            polygonq.Points.Add(new Point(150, 100));

        }
        public new void XYZ(ref Canvas canvas)
        {
            canvas.Children.Add(polygonq);
        }
        public int x1
        {
            get { return x; }
            set { x = value; }

        }
        public int y1
        {
            get { return y; }
            set { y = value; }
        }
        public new void Show()
        {
            polygonq.Visibility = Visibility.Visible;
        }
        public new void Hide()
        {
            polygonq.Visibility = Visibility.Hidden;
        }
        public new void MoveXY(int xCord, int yCord)
        {
            x1 = xCord;
            y1 = yCord;
            polygonq.Margin = new Thickness(x, y, 0, 0);
        }
    }
}

