using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetBackgroundGradient();
            UpdateButtonState();
            StyleComboBox.SelectedIndex = 0;
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            UpdateButtonState();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void StyleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (StyleComboBox.SelectedIndex)
            {
                case 0:
                    TextBox1.FontFamily = new FontFamily("TimesNewRoman");
                    TextBox1.FontSize = 12;
                    TextBox1.Foreground = Brushes.Black;
                    TextBox2.FontFamily = new FontFamily("TimesNewRoman");
                    TextBox2.FontSize = 12;
                    TextBox2.Foreground = Brushes.Black;
                    break;
                case 1:
                    TextBox1.FontFamily = new FontFamily("TimesNewRoman");
                    TextBox1.FontSize = 16;
                    TextBox1.Foreground = Brushes.Black;
                    TextBox2.FontFamily = new FontFamily("TimesNewRoman");
                    TextBox2.FontSize = 16;
                    TextBox2.Foreground = Brushes.Black;
                    break;
                case 2:
                    TextBox1.FontFamily = new FontFamily("TimesNewRoman");
                    TextBox1.FontSize = 12;
                    TextBox1.Foreground = Brushes.Blue;
                    TextBox2.FontFamily = new FontFamily("TimesNewRoman");
                    TextBox2.FontSize = 12;
                    TextBox2.Foreground = Brushes.Green;
                    break;
            }
        }

        private void SetBackgroundGradient()
        {
            LinearGradientBrush brush = new LinearGradientBrush();
            brush.StartPoint = new Point(0, 0);
            brush.EndPoint = new Point(1, 1);
            brush.GradientStops.Add(new GradientStop(Colors.LightBlue, 0));
            brush.GradientStops.Add(new GradientStop(Colors.LightGray, 1));
            TextBox1.Background = brush;
            TextBox2.Background = brush;
        }

        private void UpdateButtonState()
        {
            CloseButton.IsEnabled = string.IsNullOrEmpty(TextBox1.Text) && string.IsNullOrEmpty(TextBox2.Text);
        }
    }
}