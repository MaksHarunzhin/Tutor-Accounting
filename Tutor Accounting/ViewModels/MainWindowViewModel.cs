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

        public ObservableCollection<string> CurrentTime
        {
            get => Fields._currentTime;
            set => Set(ref Fields._currentTime, value);
        }

        public ObservableCollection<bool> SizeMode
        {
            get => Fields._sizeMode;
            set => Set(ref Fields._sizeMode, value);
        }

        #endregion

        #region Commands

        public ICommand ShowSidePanelCommand { get; }

        public ICommand CloseAppCommand { get; }

        public ICommand ResizeWindowCommand { get; }

        public ICommand MinimizedWindowCommand { get; }

        #endregion

        /// <summary>
        /// Конструктор класса MainWindowViewModel
        /// </summary>
        public MainWindowViewModel()
        {
            Helper.UpDateTime();
            ShowSidePanelCommand = new ActionCommand(Service.OnShowSidePanelCommandExecuted, Service.CanShowSidePanelCommandExecute);
            CloseAppCommand = new ActionCommand(Service.OnCloseAppCommandExecuted, Service.CanCloseAppCommandExecute);
            ResizeWindowCommand = new ActionCommand(Service.OnResizeButtonCommandExecuted, Service.CanResizeButtonCommandExecute);
            MinimizedWindowCommand = new ActionCommand(Service.OnMinimizedWindowCommandExecuted, Service.CanMinimizedWindowCommandExecute);
        }
    }
}
