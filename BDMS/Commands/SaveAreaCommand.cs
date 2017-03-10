﻿using BDMS.ViewModels;
using System;
using System.Windows.Input;
namespace BDMS.Commands
{
    internal class SaveAreaCommand : ICommand
    {
        private AreaViewModel VM;
        public SaveAreaCommand(AreaViewModel vm)
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
            VM.SaveChanges();
        }
    }
}
