using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Tutor_Accounting.Infrastructure
{
    internal static class Service
    {
        #region ShowSidePanelCommand

        public static bool CanShowSidePanelCommandExecute(object p) => true;
        public static void OnShowSidePanelCommandExecuted(object p)
        {
            if (Fields._sidePanelWidth[0] == 350)
            {
                DoubleAnimation doubleAnimation = new DoubleAnimation();
                doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                doubleAnimation.From = 350;
                doubleAnimation.To = 0;
                Grid grid = (Grid)p;
                grid.BeginAnimation(Grid.WidthProperty, doubleAnimation);

                Fields._sidePanelWidth[0] = 0;
            } else
            {
                DoubleAnimation doubleAnimation = new DoubleAnimation();
                doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                doubleAnimation.From = 0;
                doubleAnimation.To = 350;
                Grid grid = (Grid)p;
                grid.BeginAnimation(Grid.WidthProperty, doubleAnimation);

                Fields._sidePanelWidth[0] = 350;
            }
        }

        #endregion
    }
}
