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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Tutor_Accounting.Views.MyUserControls
{
    /// <summary>
    /// Логика взаимодействия для WorkZone.xaml
    /// </summary>
    public partial class WorkZone : UserControl
    {
        public WorkZone()
        {
            InitializeComponent();
        }

        private void Border_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            Border border = sender as Border;
            double delta = e.Delta;
            var ScaleTransform = (ScaleTransform)((TransformGroup)border.RenderTransform).Children.First(tr => tr is ScaleTransform);

            var TranslateTransform = (TranslateTransform)((TransformGroup)border.RenderTransform).Children.First(tr => tr is TranslateTransform);

            Point relative = e.GetPosition(border);
            double absoluteX;
            double absoluteY;

            absoluteX = relative.X * ScaleTransform.ScaleX + TranslateTransform.X;
            absoluteY = relative.Y * ScaleTransform.ScaleY + TranslateTransform.Y;
            if (delta > 0)
            {
                if (ScaleTransform.ScaleY >= 1)
                {
                    return;
                }

                ScaleTransform.ScaleX += 0.02;
                ScaleTransform.ScaleY += 0.02;
            } else
            {
                if (ScaleTransform.ScaleY <= 0.2)
                {
                    return;
                }
                ScaleTransform.ScaleX -= 0.02;
                ScaleTransform.ScaleY -= 0.02;
            }

            TranslateTransform.X = absoluteX - relative.X * ScaleTransform.ScaleX;
            TranslateTransform.Y = absoluteY - relative.Y * ScaleTransform.ScaleY;

        }
    }
}
