using ArganaRestaurant.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ArganaRestaurant.Commands
{
    public abstract class CommandBase : ICommand
    {

        private readonly DataService dataService;

        public event EventHandler? CanExecuteChanged;


        

        public virtual bool CanExecute(object? parameter)
        {
            return true;
        }


        public abstract void Execute(object? parameter);


        protected void OnCanExecutedChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
