using DataBaseFirstWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataBaseFirstWpf.Commands
{
    public class DeleteCommand : ICommand
    {
        public DeleteCommand(FilialViewModel filialViewModel)
        {
            FilialViewModel = filialViewModel;
        }

        public event EventHandler CanExecuteChanged;
        public FilialViewModel FilialViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
