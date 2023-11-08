using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Tutor_Accounting.Infrastructure
{
    internal static class Helper
    {
        public static async void UpDateTime()
        {
            Fields._currentTime[0] = DateTime.Now.ToString().Split(' ')[1].Remove(5, 3);
            await Task.Delay(1000);
            UpDateTime();
        }

        public static void CloseOtherPanels(object p)
        {
            Grid grid = (Grid)p;
            Grid MainGrid = (Grid)VisualTreeHelper.GetParent(grid);
            for (int i = 0; i < MainGrid.Children.Count; i++)
            {
                Grid g = (Grid)MainGrid.Children[i];
                if (g.Width == 350)
                {
                    double NewHeight = 350 + 200 * i;

                    DoubleAnimation doubleAnimationWidth = new DoubleAnimation();
                    doubleAnimationWidth.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                    doubleAnimationWidth.From = 350;
                    doubleAnimationWidth.To = 30;

                    DoubleAnimation doubleAnimationHeight = new DoubleAnimation();
                    doubleAnimationHeight.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                    doubleAnimationHeight.From = App.Current.MainWindow.Height - 80;
                    doubleAnimationHeight.To = NewHeight;

                    g.BeginAnimation(Grid.WidthProperty, doubleAnimationWidth);
                    g.BeginAnimation(Grid.HeightProperty, doubleAnimationHeight);

                    Fields._panelsList[i] = false; 
                    Fields._sidePanelWidth[i] = 30;
                    break;
                }
            }
        }
    }
}
