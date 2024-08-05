using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2
{
    internal class MyCommand
    {
        public static RoutedUICommand Clock { get; set; }
        static MyCommand()
        {
            Clock = new RoutedUICommand("Clock","Clock", typeof(MainWindow));
        }
    }
}
