using System;
using System.Windows.Media;
using _002_TresCamadas_M_V_VM.Helpers;

namespace _002_TresCamadas_M_V_VM.Models
{
    public class Person : NotificationObject
    {
        public Person(string name, int age, bool isMarried, double height, DateTime birthDate, Color favColor)
        {
            Name = name;
            Age = age;
            IsMarried = isMarried;
            Height = height;
            BirthDate = birthDate;
            FavoriteColor = new SolidColorBrush(favColor);
        }

        #region Name

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        #endregion

        #region Age

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age == value) return;
                _age = value;
                RaisePropertyChanged(() => Age);
            }
        }

        #endregion

        #region IsMarried

        private bool _isMarried;
        public bool IsMarried
        {
            get { return _isMarried; }
            set
            {
                if (_isMarried == value) return;
                _isMarried = value;
                RaisePropertyChanged(() => IsMarried);
            }
        }

        #endregion

        #region Height

        private double _height;
        public double Height
        {
            get { return _height; }
            set
            {
                if (_height == value) return;
                _height = value;
                RaisePropertyChanged(() => Height);
            }
        }

        #endregion

        #region BirthDate

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (_birthDate == value) return;
                _birthDate = value;
                RaisePropertyChanged(() => BirthDate);
            }
        }

        #endregion

        #region FavoriteColor

        private SolidColorBrush _favoriteColor;
        public SolidColorBrush FavoriteColor
        {
            get { return _favoriteColor; }
            set
            {
                if (_favoriteColor == value) return;
                _favoriteColor = value;
                RaisePropertyChanged(() => FavoriteColor);
            }
        }

        #endregion
    }
}
