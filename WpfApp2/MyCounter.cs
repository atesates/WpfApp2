using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2
{
    public class MyCounter:INotifyPropertyChanged
    {
        private int _Counter;

        private CommandCounter myCommnad;
        public MyCounter()
        {
            myCommnad = new CommandCounter(this);   
        }
        public ICommand CommandCounterAction//btn click, keydown (action)
        {
            get { return myCommnad; }   
        }
        public int Counter //textbox (binding)
        { 
            get { return _Counter; } set { _Counter = value; } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Increment() 
        { 
            Counter++; 
            PropertyChanged(this, new PropertyChangedEventArgs("Counter"));
        
        }  
    }
    public class CommandCounter : ICommand
    {
        private MyCounter myCounter;

        public CommandCounter(MyCounter o)
        {
            myCounter = o;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
           myCounter.Increment();   
        }
    }
}
