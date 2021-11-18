using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab13_WpfApp
{
    class MyCommands
    {
        public static RoutedUICommand Close { get; set; }
        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.A, ModifierKeys.Control, "Ctrl+A"));
            Close = new RoutedUICommand("Close", "Close", typeof(MyCommands), inputs);
        }
    }
}