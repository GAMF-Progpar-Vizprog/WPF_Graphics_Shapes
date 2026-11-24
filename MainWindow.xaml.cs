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

namespace WPFShapes
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			// Háztető
			var poTető = new Polygon();
			poTető.Stroke = Brushes.DarkRed;
			poTető.Fill = Brushes.LightCoral;
			poTető.StrokeThickness = 2;
			double bfx = 20, bfy = 180;
			var p1 = new Point(bfx, bfy + 60);
			var p2 = new Point(bfx + 40, bfy);
			var p3 = new Point(bfx + 150, bfy);
			var p4 = new Point(bfx + 190, bfy + 60);
			var pcSarokPontok = new PointCollection();
			pcSarokPontok.Add(p1); pcSarokPontok.Add(p2);
			pcSarokPontok.Add(p3); pcSarokPontok.Add(p4);
			poTető.Points = pcSarokPontok;
			cvLap.Children.Add(poTető);
			// Ház
			var rcHáz = new Rectangle();
			rcHáz.Width = 170; rcHáz.Height = 80;
			rcHáz.Stroke = Brushes.DarkRed;
			rcHáz.StrokeThickness = 2;
			rcHáz.Fill = Brushes.Beige;
			rcHáz.SetValue(Canvas.LeftProperty, bfx + 10);
			rcHáz.SetValue(Canvas.TopProperty, bfy + 60);
			cvLap.Children.Add(rcHáz);
		}

	}
}
