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
                OnPropertyChanged("OpBox");
            }
        }
        #endregion

        private float _firstNum;
        public float FirstNum
        {
            get { return _firstNum; }
            set
            {
                _firstNum = value;
            }
        }

        private float _secondNum;
        public float SecondNum
        {
            get { return _secondNum; }
            set
            {
                _secondNum = value;
            }
        }

        private float _resultNum;
        public float ResultNum
        {
            get { return _resultNum; }
            set
            {
                _resultNum = value;
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
    }
}
