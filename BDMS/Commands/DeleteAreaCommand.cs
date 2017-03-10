using BDMS.ViewModels;
using BusinessModels;
using System;
using System.Windows.Input;
namespace BDMS.Commands
{
    internal class DeleteAreaCommand : ICommand
    {
        private AreaViewModel VM;
        public DeleteAreaCommand(AreaViewModel vm)
        {
            VM = vm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            //return string.IsNullOrEmpty(VM.Customer.Error);
            return true;
        }

        public void Execute(object parameter)
        {
            dynamic area = parameter;
        }
    }
}
