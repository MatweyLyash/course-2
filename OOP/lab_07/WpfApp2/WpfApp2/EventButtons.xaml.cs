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
    /// Логика взаимодействия для EventButtons.xaml
    /// </summary>
    public partial class EventButtons : UserControl
    {
        public EventButtons()
        {
            InitializeComponent();
        }

        public static readonly RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent(
             "Click",
             RoutingStrategy.Bubble,
             typeof(RoutedEventHandler),
             typeof(EventButtons));

        public static readonly RoutedEvent ClickEvent2 = EventManager.RegisterRoutedEvent(
            "Click2",
            RoutingStrategy.Direct,
            typeof(RoutedEventHandler),
            typeof(EventButtons));

        public static readonly RoutedEvent ClickEvent3 = EventManager.RegisterRoutedEvent(
            "Click3",
         RoutingStrategy.Tunnel,
         typeof(RoutedEventHandler),
         typeof(EventButtons));


        public event RoutedEventHandler Click
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        public event RoutedEventHandler Click2
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        public event RoutedEventHandler Click3
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }


        protected virtual void OnClick()
        {
            RoutedEventArgs args = new RoutedEventArgs(ClickEvent);
            RaiseEvent(args);
        }
        
        protected virtual void OnMouseDown()
        {
            RoutedEventArgs args = new RoutedEventArgs(ClickEvent2);
            RaiseEvent(args);
        }
        protected virtual void PreviewMouseDown()
        {
            RoutedEventArgs args = new RoutedEventArgs(ClickEvent3);
            RaiseEvent(args);
        }

        private void Bubbling_MouseDown(object sender, RoutedEventArgs e)
        {
            BubblingTextBlock.Text += "sender: " + sender.ToString() + "\n";
            OnClick();
        }
        private void Direct_MouseDown(object sender, RoutedEventArgs e)
        {
            DirectTextBlock.Text += "sender: " + sender.ToString() + "\n";
            OnMouseDown();
        }
        private void Tunelling_MouseDown(object sender, RoutedEventArgs e)
        {
            TunellingTextBlock.Text += "sender: " + sender.ToString() + "\n";
            PreviewMouseDown();
        }
    }
}
