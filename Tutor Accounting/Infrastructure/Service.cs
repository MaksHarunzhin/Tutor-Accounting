using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Tutor_Accounting.Infrastructure
{
    internal static class Service
    {
        #region ShowSidePanelCommand

        public static bool CanShowSidePanelCommandExecute(object p) => true;
        public static void OnShowSidePanelCommandExecuted(object p)
        {
            Grid grid = (Grid)p;
            if (grid.Width == 30)
            {
                Helper.CloseOtherPanels(p);
                if (grid.Height == 350)
                {
                    Fields._panelsList[0] = true;
                    Fields._sidePanelWidth[0] = 350;
                } else if (grid.Height == 550)
                {
                    Fields._panelsList[1] = true;
                    Fields._sidePanelWidth[1] = 350;
                } else
                {
                    Fields._panelsList[2] = true;
                    Fields._sidePanelWidth[2] = 350;
                }

                DoubleAnimation doubleAnimationWidth = new DoubleAnimation();
                doubleAnimationWidth.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                doubleAnimationWidth.From = 30;
                doubleAnimationWidth.To = 350;

                DoubleAnimation doubleAnimationHeight = new DoubleAnimation();
                doubleAnimationHeight.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                doubleAnimationHeight.From = grid.Height;
                doubleAnimationHeight.To = App.Current.MainWindow.Height - 80;

                grid.BeginAnimation(Grid.WidthProperty, doubleAnimationWidth);
                grid.BeginAnimation(Grid.HeightProperty, doubleAnimationHeight);

            } else
            {
                double NewHeight = 0;
                if (Fields._panelsList[0])
                {
                    Fields._panelsList[0] = false;
                    NewHeight = 350;
                } else if (Fields._panelsList[1])
                {
                    Fields._panelsList[1] = false;
                    NewHeight = 550;
                } else
                {
                    NewHeight = 750;
                    Fields._panelsList[2] = false;
                }

                DoubleAnimation doubleAnimationWidth = new DoubleAnimation();
                doubleAnimationWidth.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                doubleAnimationWidth.From = 350;
                doubleAnimationWidth.To = 30;

                DoubleAnimation doubleAnimationHeight = new DoubleAnimation();
                doubleAnimationHeight.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                doubleAnimationHeight.From = App.Current.MainWindow.Height - 80;
                doubleAnimationHeight.To = NewHeight;

                grid.BeginAnimation(Grid.WidthProperty, doubleAnimationWidth);
                grid.BeginAnimation(Grid.HeightProperty, doubleAnimationHeight);

                Fields._sidePanelWidth[0] = 30;
            }
        }

        #endregion

        #region CloseAppCommand

        public static bool CanCloseAppCommandExecute(object p) => true;
        public static void OnCloseAppCommandExecuted(object p)
        {
            Environment.Exit(0);
        }

        #endregion

        #region ResizeButtonCommand

        public static bool CanResizeButtonCommandExecute(object p) => true;
        public static void OnResizeButtonCommandExecuted(object p)
        {
            double indent = Screen.PrimaryScreen.Bounds.Height;
            double ind = Screen.PrimaryScreen.WorkingArea.Height;
            double dif = indent - ind;
            if (Fields._sizeMode[0])
            {
                App.Current.MainWindow.WindowState = WindowState.Normal;
                double width = System.Windows.SystemParameters.PrimaryScreenWidth;
                double height = System.Windows.SystemParameters.PrimaryScreenHeight;
                App.Current.MainWindow.Height = height * 4 / 5;
                App.Current.MainWindow.Width = width * 3.8 / 4;
                App.Current.MainWindow.Top = (height - (height * 4 / 5)) / 2;
                App.Current.MainWindow.Left = (width - (width * 3.8 / 4)) / 2;
                Fields._sizeMode[0] = false;
            }
            else
            {
                App.Current.MainWindow.Height = System.Windows.SystemParameters.PrimaryScreenHeight - dif;
                App.Current.MainWindow.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
                App.Current.MainWindow.Left = 0;
                App.Current.MainWindow.Top = 0;
                Fields._sizeMode[0] = true;
            }
        }

        #endregion

        #region MinimizedWindowCommand

        public static bool CanMinimizedWindowCommandExecute (object p) => true;
        public static void OnMinimizedWindowCommandExecuted (object p)
        {
            App.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        #endregion

    }
}
