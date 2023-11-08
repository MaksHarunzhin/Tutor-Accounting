using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutor_Accounting.Models;

namespace Tutor_Accounting.Infrastructure
{
    internal static class Fields
    {
        public static ObservableCollection<double> _sidePanelWidth = new ObservableCollection<double> { 30, 30, 30 };

        public static ObservableCollection<string> _currentTime = new ObservableCollection<string> { DateTime.Now.ToString().Split(' ')[1].Remove(5, 3) };

        public static ObservableCollection<bool> _sizeMode = new ObservableCollection<bool> { false };

        public static ObservableCollection<bool> _panelsList = new ObservableCollection<bool> { false, false, false };

        public static TimeLine TimeLine = new TimeLine();

    }
}
