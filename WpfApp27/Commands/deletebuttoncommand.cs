using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp27.ViewModel;

namespace WpfApp27.Commands
{
    public class deletebuttoncommand : ICommand
    {
        AdminforumVM vm;
        public deletebuttoncommand(AdminforumVM vim)
        {
            vm = vim;

        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            vm.delete();
        }
    }
}
