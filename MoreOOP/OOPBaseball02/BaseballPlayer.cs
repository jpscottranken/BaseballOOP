using System;

namespace OOPBaseball02
{
    public class BaseballPlayer
    {
        //  Instance variables (data)
        private string  _firstName;
        private string  _lastName;
        private string  _position;
        private int     _homeRuns;
        private decimal _average;

        //  Empty Constructor (a.k.a default constructor)
        public BaseballPlayer()
        {
            //  This will set the values below
            //  (instance variables) to the following:
            //  _firstName will be set to ""
            //  _lastName  will be set to ""
            //  _position  will be set to ""
            //  _homeRuns  will be set to 0
            //  _average   will be set to 0.000M
        }

        //  Overloaded constructor #1
        public BaseballPlayer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;

            //  This will set the values below
            //  (instance variables) to the following:
            //  _position  will be set to ""
            //  _homeRuns  will be set to 0
            //  _average   will be set to 0.000M
        }

        //  Overloaded constructor #2
        public BaseballPlayer(string firstName, string lastName,
                              string position,  int homeRuns,
                              decimal average)
        {
            _firstName = firstName;
            _lastName = lastName;
            _position = position;
            _homeRuns = homeRuns;
            _average  = average;
        }

        //  Properties
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string Position
        {
            get => _position;
            set => _position = value;
        }

        public int HomeRuns
        {
            get => _homeRuns;
            set => _homeRuns = value;
        }

        public decimal Average
        {
            get => _average;
            set => _average = value;
        }
    }
}
