using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tutor_Accounting.ViewModels.Base;
using Tutor_Accounting.Infrastructure.Commands;
using Tutor_Accounting.Infrastructure;
using System.Collections.ObjectModel;

namespace Tutor_Accounting.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {

        #region Properties

        public ObservableCollection<double> SidePanelWidth
        {
            get => Fields._sidePanelWidth;
            set => Set(ref Fields._sidePanelWidth, value);
        }

        #endregion

        #region Commands

        public ICommand ShowSidePanelCommand { get; }

        #endregion

        /// <summary>
        /// Конструктор класса MainWindowViewModel
        /// </summary>
        public MainWindowViewModel()
        {
            ShowSidePanelCommand = new ActionCommand(Service.OnShowSidePanelCommandExecuted, Service.CanShowSidePanelCommandExecute);
        }
    }
}
