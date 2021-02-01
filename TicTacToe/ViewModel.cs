using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace TicTacToe
{
    class ViewModel : INotifyPropertyChanged
    {
        Model model ;

        public Model DataContext { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ViewModel()
        {
             model = new Model();
            Btn1Command = new CommandHandler(Btn1ClickTicTac, canExecute);
            Btn2Command = new CommandHandler(Btn2ClickTicTac, canExecute);
            Btn3Command = new CommandHandler(Btn3ClickTicTac, canExecute);
            Btn4Command = new CommandHandler(Btn4ClickTicTac, canExecute);
            Btn5Command = new CommandHandler(Btn5ClickTicTac, canExecute);
            Btn6Command = new CommandHandler(Btn6ClickTicTac, canExecute);
            Btn7Command = new CommandHandler(Btn7ClickTicTac, canExecute);
            Btn8Command = new CommandHandler(Btn8ClickTicTac, canExecute);
            Btn9Command = new CommandHandler(Btn9ClickTicTac, canExecute);
            ResetCommand = new CommandHandler(Reset, canExecute);
        }
        public ICommand ResetCommand { get; set; }
        public string Btn1 { get; set; }
        public ICommand Btn1Command { get; private set; }

        public string Btn2 { get; set; }
        public ICommand Btn2Command { get; private set; }

        public string Btn3 { get; set; }
        public ICommand Btn3Command { get; private set; }

        public string Btn4 { get; set; }
        public ICommand Btn4Command { get; private set; }

        public string Btn5 { get; set; }
        public ICommand Btn5Command { get; private set; }

        public string Btn6 { get; set; }
        public ICommand Btn6Command { get; private set; }

        public string Btn7 { get; set; }
        public ICommand Btn7Command { get; private set; }

        public string Btn8 { get; set; }
        public ICommand Btn8Command { get; private set; }

        public string Btn9 { get; set; }
        public ICommand Btn9Command { get; private set; }

        private void Btn1ClickTicTac()
        {
            var content=model.BtnClick(Btn1);
            Btn1 = content;
            RaisePropertyChange(nameof(Btn1));
            model.topLeft = content;
            model.checkVictory();
        }

        private void Btn2ClickTicTac()
        {
            var content = model.BtnClick(Btn2);
            Btn2 = content;
            RaisePropertyChange(nameof(Btn2));
            model.topCenter = content;
            model.checkVictory();
        }

        private void Btn3ClickTicTac()
        {
            var content = model.BtnClick(Btn3);
            Btn3 = content;
            RaisePropertyChange(nameof(Btn3));
            model.topRight = content;
            model.checkVictory();
        }

        private void Btn4ClickTicTac()
        {
            var content = model.BtnClick(Btn4);
            Btn4 = content;
            RaisePropertyChange(nameof(Btn4));
            model.middleLeft = content;
            model.checkVictory();
        }

        private void Btn5ClickTicTac()
        {
            var content = model.BtnClick(Btn5);
            Btn5 = content;
            RaisePropertyChange(nameof(Btn5));
            model.middleCenter = content;
            model.checkVictory();
        }

        private void Btn6ClickTicTac()
        {
            var content = model.BtnClick(Btn6);
            Btn6 = content;
            RaisePropertyChange(nameof(Btn6));
            model.middleRight = content;
            model.checkVictory();
        }

        private void Btn7ClickTicTac()
        {
            var content = model.BtnClick(Btn7);
            Btn7 = content;
            RaisePropertyChange(nameof(Btn7));
            model.bottomLeft = content;
            model.checkVictory();
        }

        private void Btn8ClickTicTac()
        {
            var content = model.BtnClick(Btn8);
            Btn8 = content;
            RaisePropertyChange(nameof(Btn8));
            model.bottomCenter = content;
            model.checkVictory();
        }

        private void Btn9ClickTicTac()
        {
            var content = model.BtnClick(Btn9);
            Btn9 = content;
            RaisePropertyChange(nameof(Btn9));
            model.bottomRight = content;
            model.checkVictory();
        }

        public void Reset()
        {
            Btn1 = null;
            RaisePropertyChange(nameof(Btn1));
            Btn2 = null;
            RaisePropertyChange(nameof(Btn2));
            Btn3 = null;
            RaisePropertyChange(nameof(Btn3));
            Btn4 = null;
            RaisePropertyChange(nameof(Btn4));
            Btn5 = null;
            RaisePropertyChange(nameof(Btn5));
            Btn6= null;
            RaisePropertyChange(nameof(Btn6));
            Btn7 = null;
            RaisePropertyChange(nameof(Btn7));
            Btn8 = null;
            RaisePropertyChange(nameof(Btn8));
            Btn9 = null;
            RaisePropertyChange(nameof(Btn9));

            model.Reset();
        }

        public bool canExecute()
        {
           
            return true;

        }
    }
}
