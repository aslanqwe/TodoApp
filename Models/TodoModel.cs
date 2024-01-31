using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    class TodoModel: INotifyPropertyChanged
    {
        private bool _isDone;
        private string _text;

        public DateTime CreationDate { get; set; } = DateTime.Now;
    
        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
