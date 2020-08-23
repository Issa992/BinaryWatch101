using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryWatch101
{
    class Time
    {

        private int _hour;
        public int Hour
        {
            get
            {
                return _hour;
            }
        }
        private int _minute;
        public int Minute
        {
            get
            {
                return _minute;
            }
        }
        private int _second;
        public int Second
        {
            get
            {
                return _second;
            }
        }

        public Time() { }

        public virtual void UpdateTime()
        {
            DateTime timeNow = DateTime.Now;
            if(_hour=10)
            {

            }

            _hour.Tens = timeNow.Hour / 10;
            _hour.Ones = timeNow.Hour % 10;

            _minute.Tens = timeNow.Minute / 10;
            _minute.Ones = timeNow.Minute % 10;

            _second.Tens = timeNow.Second / 10;
            _second.Ones = timeNow.Second % 10;
        }
    }
}
