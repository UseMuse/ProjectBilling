using ProjectBilling.ViewModels.Contracts;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace ProjectBilling.Commands
{
    public class UpdateCommand : ICommand
    {
        private const int ARE_EQUAL = 0;
        private const int NONE_SELECTED = -1;
        private readonly IProjectsViewModel _vm;

        public UpdateCommand(IProjectsViewModel viewModel)
        {
            _vm = viewModel;
            _vm.PropertyChanged += vm_PropertyChanged;
        }

        private void vm_PropertyChanged(object sender,
            PropertyChangedEventArgs e)
        {
            if (String.CompareOrdinal(e.PropertyName, ProjectsViewModel.SELECTED_PROJECT_PROPERRTY_NAME) == ARE_EQUAL)
            {
                CanExecuteChanged(this, new EventArgs());
            }
        }

        public bool CanExecute(object parameter)
        {
            if (_vm.SelectedProject == null)
                return false;
            return ((ProjectViewModel)_vm.SelectedProject).ID
                   > NONE_SELECTED;
        }

        public event EventHandler CanExecuteChanged
            = delegate { };

        public void Execute(object parameter)
        {
            _vm.UpdateProject();
        }
    }
}