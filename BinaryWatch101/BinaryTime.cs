using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryWatch101
{
   public class BinaryTime : Time
    {
        private int _binaryHour;
        public int BinaryHour
        {
            get
            {
                return _binaryHour;
            }
        }

        private int _binaryMinute;
        public int BinaryMinute
        {
            get
            {
                return _binaryMinute;
            }
        }

        private int _binarySecond;
        public int BinarySecond
        {
            get
            {
                return _binarySecond;
            }
        }

        public BinaryTime() : base() { }

        public BinaryTime(int binaryHour, int binaryMinute, int binarySecond)
        {
            _binaryHour = binaryHour;
            _binaryMinute = binaryMinute;
            _binarySecond = binarySecond;
        }

        public override void UpdateTime()
        {
            base.UpdateTime();

            ConvertToBinary();
        }

        private void ConvertToBinary()
        {
            //_binaryHour.Ones = Int32.Parse(Convert.ToString(Hour.Ones, 2));
            //_binaryHour.Tens = Int32.Parse(Convert.ToString(Hour.Tens, 2));

            //_binaryMinute.Ones = Int32.Parse(Convert.ToString(Minute.Ones, 2));
            //_binaryMinute.Tens = Int32.Parse(Convert.ToString(Minute.Tens, 2));

            //_binarySecond.Ones = Int32.Parse(Convert.ToString(Second.Ones, 2));
            //_binarySecond.Tens = Int32.Parse(Convert.ToString(Second.Tens, 2));
        }
    }
}

