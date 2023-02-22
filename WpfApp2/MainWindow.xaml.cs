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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void r_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var buttonToDelete = sender as Button;
            var buttonName= buttonToDelete.Content;
            foreach (var ilk in bir.Children)
            {
                var ikiStack = ilk as StackPanel;
                foreach (var d in ikiStack.Children)
                {
                    if (d is Button btn)
                    {
                        if(btn.Content==buttonName) 
                        {
                            this.Title =$"{btn.Content} was deleted";
                            ikiStack.Children.Remove(btn);
                            break;
                        }
                    }
                }
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var rnd = new Random();
            var clr = Color.FromRgb((byte)rnd.Next(),(byte)rnd.Next(),(byte)rnd.Next());
            if(sender is Button click)
            {
                click.Background= new SolidColorBrush(clr);
            }
        }
    }
    
}
