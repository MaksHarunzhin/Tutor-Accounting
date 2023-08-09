using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutor_Accounting.ViewModels.Base;

namespace Tutor_Accounting.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {

        #region Properties

        private double _columnWidth = 300;
        /// <summary>
        /// Ширина столбца с настройками календаря
        /// </summary>
        public double ColumnWidth
        {
            get => _columnWidth;
            set => Set(ref _columnWidth, value);
        }

        #endregion

        #region Commands



        #endregion

        /// <summary>
        /// Конструктор класса MainWindowViewModel
        /// </summary>
        public MainWindowViewModel()
        {

        }
    }
}
