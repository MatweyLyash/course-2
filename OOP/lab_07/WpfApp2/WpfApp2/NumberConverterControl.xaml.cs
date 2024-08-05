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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для NumberConverterControl.xaml
    /// </summary>
    public partial class NumberConverterControl : UserControl
    {
        public NumberConverterControl()
        {
            DecNumConv = "0";
            HexNumConv = "0";
            InitializeComponent();
        }

        private static int DecNum = 0;
        private static string HexNum = "0";

        public static readonly DependencyProperty DecNumConvProperty = DependencyProperty.Register("DecNumConv", typeof(string), typeof(NumberConverterControl),
                new FrameworkPropertyMetadata(
                    "0",
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    ValuePropertyChanged,
                    new CoerceValueCallback(ValueCoerce)), new ValidateValueCallback(ValidateValue));

        public static readonly DependencyProperty HexNumConvProperty = DependencyProperty.Register("HexNumConv", typeof(string), typeof(NumberConverterControl),
                new FrameworkPropertyMetadata(
                    "0",
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    ValuePropertyChanged_2,
                    new CoerceValueCallback(ValueCoerce_2)), new ValidateValueCallback(ValidateValue_2));

        private static void ValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HexNum = DecNum.ToString("X");
        }

        private static void ValuePropertyChanged_2(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DecNum = Convert.ToInt32(HexNum, 16);
        }

        private static object ValueCoerce(DependencyObject d, object baseValue)
        {
            DecNum = Convert.ToInt32(baseValue);
            return baseValue;
        }

        private static object ValueCoerce_2(DependencyObject d, object baseValue)
        {
            return baseValue;

        }

        public string DecNumConv
        {
            get { return (string)GetValue(DecNumConvProperty); }
            set { SetValue(DecNumConvProperty, value); }
        }

        public string HexNumConv
        {
            get { return (string)GetValue(HexNumConvProperty); }
            set { SetValue(HexNumConvProperty, value); }
        }

        private static bool ValidateValue(object value)
        {
            try
            {
                string currentValue = Convert.ToUInt32(value).ToString("X");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool ValidateValue_2(object value)
        {
            try
            {
                int currentValue = Convert.ToInt32(Convert.ToString(value), 16);
                return true;
            }
            catch
            {
                return false;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HexBox.Text = NumberConverterControl.HexNum;
            DecimalBox.Text = Convert.ToString(DecNum);
        }
    }
}
