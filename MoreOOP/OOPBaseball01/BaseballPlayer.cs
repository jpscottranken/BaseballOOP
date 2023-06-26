using OOPBaseball01;
using System;

namespace OOPBaseball01
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
            _lastName  = lastName;

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
            _lastName  = lastName;
            _position  = position;
            _homeRuns  = homeRuns;
            _average   = average;
        }

        //  Getters (read-only accessors)
        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public string GetPosition()
        {
            return _position;
        }

        public int GetHomeRuns()
        {
            return _homeRuns;
        }

        public decimal GetAverage()
        {
            return _average;
        }

        //  Setters (mutators)
        public void SetFirstName(string fn)
        {
            _firstName = fn;
        }

        //  Setters (mutators)
        public void SetLastName(string ln)
        {
            _lastName = ln;
        }

        //  Setters (mutators)
        public void SetPosition(string p)
        {
            _position = p;
        }

        //  Setters (mutators)
        public void SetHomeRuns(int hr)
        {
            _homeRuns = hr;
        }

        //  Setters (mutators)
        public void SetAveragee(decimal avg)
        {
            _average = avg;
        }
    }
}


