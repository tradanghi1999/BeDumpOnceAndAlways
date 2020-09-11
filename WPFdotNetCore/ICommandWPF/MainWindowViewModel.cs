using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ICommandWPF
{
    public class MainWindowViewModel: ViewModelBase
    {
        public MyCommand CMD
        { get; set; }
        public MainWindowViewModel()
        {
            CMD = new MyCommand(DoMyCommand);
        }

        private void DoMyCommand(object parameter)
        {
            MessageBox.Show("OK");
        }
    }

    public class MyCommand : ICommand
    {
        Action<object> _execute;
        public MyCommand(Action<object> execute)
        {
            _execute = execute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) =>
            _execute(parameter);
    }
}
