using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;


namespace Lab1Malynovskyi
{
    internal class BirthVM:INotifyPropertyChanged
    {
        private readonly BirthMod _birthMod = new BirthMod();

        public DateTime DateBirth
        {
            get
            {
                return _birthMod.Birth;
            }
            set
            {
                _birthMod.Birth = value;
                if (!_birthMod.Valid)
                {
                    MessageBox.Show("You entered invalid date!", "DatePickerError", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (_birthMod.IsBirth)
                    {
                        MessageBox.Show("Happy birthday!");
                    }
                }
            }
        }

        public string Age
        {
            get
            {
                return _birthMod.Age;
            }
        }

        public string WestZodiac
        {
            get
            {
                return _birthMod.WestZodiac;
            }
        }

        public string ChineseZodiac
        {
            get
            {
                return _birthMod.ChineseZodiac;       
            }
        } 

        internal BirthVM()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}