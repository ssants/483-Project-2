using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Model : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;

#region op
        public enum CurrentOp { ADD, SUB, MULT, DIV, NONE };

        private CurrentOp _op;
        public CurrentOp Op
        {
            get { return _op; }
            set
            {
                _op = value;
                OpString = _op.ToString();
            }
        }

        public void setCurrentOp(string op)
        {
            if (op == "ADD") Op = Model.CurrentOp.ADD;
            else if (op == "SUB") Op = Model.CurrentOp.SUB;
            else if (op == "MULT") Op = Model.CurrentOp.MULT;
            else Op = Model.CurrentOp.DIV;
        }

        private string _opString;
        public string OpString
        {
            get { return _opString; }
            set
            {
                _opString = value;
                OnPropertyChanged("OpString");
            }
        }


        #endregion

        private int _firstNum;
        public string FirstNum
        {
            get { return _firstNum.ToString(); }
            set
            {
                try
                {
                    _firstNum = int.Parse(value);
                }
                catch
                {

                }
            }
        }

        private int _secondNum;
        public string SecondNum
        {
            get { return _secondNum.ToString(); }
            set
            {
                try
                {
                    _secondNum = int.Parse(value);
                }
                catch
                {

                }
            }
        }

        private float _resultNum;
        public string ResultNum
        {
            get { return _resultNum.ToString(); }
            set
            {
                try
                {
                    _resultNum = float.Parse(value);
                }
                catch
                {

                }
                OnPropertyChanged("ResultNum");
            }
        }

        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public Model()
        {
            Op = CurrentOp.NONE;
        }

        public void calculate()
        {
            switch (Op)
            {
                case CurrentOp.ADD:
                    ResultNum = "" + (_firstNum + _secondNum);
                    break;

                case CurrentOp.SUB:
                    ResultNum = "" + (_firstNum - _secondNum);
                    break;

                case CurrentOp.MULT:
                    ResultNum = "" + (_firstNum * _secondNum);
                    break;

                case CurrentOp.DIV:
                    ResultNum = "" + (_firstNum / _secondNum);
                    break;

            }
        }
    }
}
