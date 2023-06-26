using System;

namespace OOPBaseball03
{
    public class BaseballPlayer
    {
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
            FirstName = firstName;
            LastName = lastName;

            //  This will set the values below
            //  (instance variables) to the following:
            //  _position  will be set to ""
            //  _homeRuns  will be set to 0
            //  _average   will be set to 0.000M
        }

        //  Overloaded constructor #2
        public BaseballPlayer(string firstName, string lastName,
                              string position, int homeRuns,
                              decimal average)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            HomeRuns = homeRuns;
            Average = average;
        }

        //  Auto-Implemented Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public int HomeRuns { get; set; }

        public decimal Average { get; set; }
    }
}
