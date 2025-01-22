using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Invoices
{
    public class Date: IComparable
    {
        public int _year;
        public int _month;
        public int _day;
        private int value;

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public static Date operator +(Date lhs, int rhs)
        {
            Date newDate = new Date(lhs.Year, lhs.Month, lhs.Day);

            //loop addDate (rhs) times
            for (int i = 0; i < rhs; i++)
            {
                newDate.addDay();
            }
            return newDate;
        }
        public static Date operator +(int lhs, Date rhs)
        {
            Date newDate = new Date(rhs.Year, rhs.Month, rhs.Day);

            //loop addDate (rhs) times
            for (int i = 0; i < lhs; i++)
            {
                newDate.addDay();
            }
            return newDate;
        }
        public int Year
        {
            get { return this._year; }
            set
            {
                int theYear = value;
                //if it's 2 digits and between 1 & 99
                if (Convert.ToString(value).Length == 2 && value > 0 && value < 100)
                {
                    theYear = 2000 + value;

                }
                if (theYear >= 1800 && theYear <= 2200)
                {
                    this._year = theYear;
                }
                else
                {
                    this._year = 2001;
                    //WriteLine($"Year {value} is out of range, using 2001");
                }
            }
        }
        public int Month
        {
            get { return this._month; }
            set
            {
                //if it's between 1 & 12
                if (value >= 1 && value <= 12)
                {
                    this._month = value;
                }
                else
                {
                    this._month = 1;
                    //WriteLine($"Month {value} is out of range, using 1 (January)");
                }
            }
        }
        public int Day
        {
            get { return this._day; }
            set
            {
                int daysInMonth = 1;

                daysInMonth = MonthDays(Month);
                if (value >= 1 && value <= daysInMonth)
                {
                    this._day = value;
                }
                else
                {
                    this._day = 1;
                    //WriteLine($"Day {value} is out of bounds, using 1");
                }
            }
        }
        private int MonthDays(int month)
        {
            int[,] daysForMonth = new int[,]
                {
                    { 1, 31 },
                    { 2, 28 },  // Assume not leap year
                    { 3, 31 },
                    { 4, 30 },
                    { 5, 31 },
                    { 6, 30 },
                    { 7, 31 },
                    { 8, 31 },
                    { 9, 30 },
                    { 10, 31 },
                    { 11, 30 },
                    { 12, 31 }
                };
            int daysInMonth = 1;

            for (int i = 0; i < daysForMonth.GetLength(0); i++)
            {
                int dom = daysForMonth[i, 0];
                if (daysForMonth[i, 0] == 2 && month == 2)
                {
                    daysInMonth = daysInFeb(this._year);
                    break;// Exit loop once month is found
                }
                else if (month == daysForMonth[i, 0])
                {
                    daysInMonth = daysForMonth[i, 1];
                    break;// Exit loop once month is found
                }
            }
            return daysInMonth;
        }
        private int daysInFeb(int yr)
        {
            int result;
            if (yr % 100 == 0)
            {
                if (yr % 400 == 0)
                    result = 29;
                else
                    result = 28;
            }
            else if (yr % 4 == 0)
                result = 29;
            else
                result = 28;
            return result;
        }
        public void addDay()
        {
            int newDay = 1;
            int newMonth = 1;
            int newYear = 2001;

            //get the number of days in the month
            int daysInMonth = MonthDays(Month);

            if (Day + 1 > daysInMonth)//if the next day is greater than the number of days in the month
            {
                newDay = 1;
                if (Month == 12)//New year, month is January
                {
                    newYear = Year + 1;
                    newMonth = 1;
                }
                else//same year, increase month
                {
                    newYear = Year;
                    newMonth = Month + 1;
                }
            }
            else//only increase the day by one
            {
                newDay = Day + 1;
                newMonth = Month;
                newYear = Year;
            }

            //set the properties with the new values
            Year = newYear;
            Month = newMonth;
            Day = newDay;
        }
        public int CompareTo(object date)
        {
            Date date1 = (Date)date;
            if (this.Year > date1.Year)
            {
                return 1;
            }
            else if (this.Year < date1.Year)
            {
                return -1;
            }
            else
            {
                if (this.Month > date1.Month)
                {
                    return 1;
                }
                else if (this.Month < date1.Month)
                {
                    return -1;
                }
                else
                {
                    if (this.Day > date1.Day)
                    {
                        return 1;
                    }
                    else if (this.Day < date1.Day)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public override string ToString()
        {
            return $"{Month}/{Day}/{Year}";
        }

    }
}

