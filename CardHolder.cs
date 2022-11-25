using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMachine
{
    internal class CardHolder
    {
        string _cardNumber;
        int _pin;
        string _firstName;
        string _lastName;
        double _balance;

        public CardHolder(string cardNumber, int pin, string firstName, string lastName, double balance)
        {
            _cardNumber = cardNumber;
            _pin = pin;
            _firstName = firstName;
            _lastName = lastName;
            _balance = balance;
        }
        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }
        public int Nip
        {
            get { return _pin; }
            set { _pin = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public double Balance
        {
            get { return _balance; }
            set
            {
                _balance = value;
            }
        }
    }
}
