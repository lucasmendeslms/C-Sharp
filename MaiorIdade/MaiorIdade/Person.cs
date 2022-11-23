using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    public class Person
    {
        public Person() { }

        public Person(String name, DateTime birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        DateTime date = DateTime.Now;

        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private int _age;

        public int Age
        {
            get
            {
                this.CalculateAge();
                return this._age;
            }
        }

        private String _underage;

        public String Underage
        {
            get
            {
                this.CalculateAge();
                return this._underage;
            }
        }

        private String _isBirthDay;

        public String IsBirthDay
        {
            get
            {
                this.isBirthDay();
                return this._isBirthDay;
            }
        }

        private void CalculateAge()
        {
            TimeSpan yearsOld = date.Subtract(this.BirthDate);
            this._age = int.Parse(yearsOld.Days.ToString()) / 365;

            if (this._age >= 18)
            {
                this._underage = $"{this.Name} é maior de idade";
            } 
            
            else
            {
                this._underage = "";
            }

        }

        private void isBirthDay()
        {
            if (_birthDate.Month == date.Month && _birthDate.Day == date.Day)
            {
                this._isBirthDay = $"Hoje é seu aniversário, parabéns {this.Name}";
            }

            else
            {
                this._isBirthDay = "";
            }
        }

        public void ExhibitData()
        {
            Console.WriteLine($"Nome: {this.Name}");
            Console.WriteLine($"Data de aniversário: {this.BirthDate.ToShortDateString()}");
            Console.WriteLine($"Idade: {this.Age}");
            Console.WriteLine(this.IsBirthDay);
            Console.WriteLine(this.Underage);
        }

    }
}
