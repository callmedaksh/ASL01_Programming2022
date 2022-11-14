using System;

namespace BusinessLogic
{
    public class Student
    {
        private string _name;

        private DateTime _dateOfBirth;

        public Student(string name, DateTime dateOfBirth)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Name should be not null or whitespace");

            _name = name;

            //homework - to create a guard 
            _dateOfBirth = dateOfBirth;
        }

        public string Name
        {
            get => _name;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(value), "Name should be not null or whitespace");

                _name = value;
            }
        }

        public int Age => DateTime.Now.Year - DateOfBirth.Year;

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;

            set
            {
                //check is your homework

                _dateOfBirth = value;
            }
        }

        public bool IsBrithDayToday => 
            DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day == DateOfBirth.Day;

        //THIS IS JAVA!  DON'T DO IT... 

        //public string GetName()
        //{
        //    return _name;
        //}
        //public void SetName(string name)
        //{
        //    if (string.IsNullOrWhiteSpace(name))
        //        throw new ArgumentNullException(nameof(name), "Name should be not null or whitespace");

        //    _name = name;
        //}
        //public int GetAge()
        //{
        //    return _age;
        //}
        //public void SetAge(int age)
        //{
        //    if (age < 1 || age > 100)
        //        throw new ArgumentOutOfRangeException(nameof(age), "Age should within 1-100 range");

        //    _age = age;
        //}
        //public DateTime GetDateOfBirth()
        //{
        //    return _dateOfBirth;
        //}
        //public void SetDateOfBirth(DateTime dateOfBirth)
        //{
        //    //check as homework
        //    _dateOfBirth = dateOfBirth;
        //}
    }
}
