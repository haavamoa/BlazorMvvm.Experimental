using System.Windows.Input;
using BlazorMvvm.Experimental.Helpers;

namespace BlazorMvvm.Experimental.ViewModels
{
    public class CounterViewModel
    {
        public CounterViewModel()
        {
            IncrementCounterCommand = new DelegateCommand(_ => Counter++);
            DecrementCounterCommand = new DelegateCommand(_ => Counter--);
        }

        public int Counter { get; private set; }

        public ICommand DecrementCounterCommand { get; set; }
        public ICommand IncrementCounterCommand { get; }
    }
}