using Microsoft.Win32;
using System;
using System.Reflection;
using System.Windows.Input;

namespace AssemblyBrowser.Commands
{
    public class LoadAssemblyCommand : ICommand
    {
        public LoadAssemblyCommand(Action<string> action)
        {
            OnFileChooseExecute += action;
        }

        public event EventHandler CanExecuteChanged;//p

        public bool CanExecute(object parameter)//p
        {
            return true;
        }

        public void Execute(object parameter)//p
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Assembly.GetEntryAssembly().Location,
                Filter = "dll files (*.dll)|*.dll",
                RestoreDirectory = true
            };


            if (openFileDialog.ShowDialog() == true)
                OnFileChooseExecute?.Invoke(openFileDialog.FileName);            
        }

        private event Action<string> OnFileChooseExecute;
    }
}