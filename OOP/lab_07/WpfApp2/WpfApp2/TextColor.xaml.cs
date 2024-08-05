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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для TextColor.xaml
    /// </summary>
    public partial class TextColor : UserControl
    {
        private static byte c = 0;

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color", typeof(string), typeof(TextColor),
                new FrameworkPropertyMetadata(
                    "0",
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    ValuePropertyChanged,
                    ValueCoerce), new ValidateValueCallback(ValidateValue));

        private static void ValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            c = Convert.ToByte(e.NewValue);
        }

        private static object ValueCoerce(DependencyObject d, object baseValue)
        {
            try
            {
                Byte currentValue = Convert.ToByte(baseValue);
                return currentValue.ToString();
            }
            catch
            {
                return "255";
            }

        }

        public string Color {
            get { return (string)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        public TextColor()
        {
            Color = "0";
            InitializeComponent();
        }

        private static bool ValidateValue(object value)
        {
            try
            {
                UInt32 currentValue = Convert.ToUInt32(value);
                return true;
            }
            catch
            {
                return false;

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            ButtonC.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(Convert.ToByte(c) ,90, 120, 20));
        }
    }
}
