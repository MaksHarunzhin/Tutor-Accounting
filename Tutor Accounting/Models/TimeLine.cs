using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor_Accounting.Models
{
    internal class TimeLine
    {
        private bool _oneday = true;
        public bool OneDay
        {
            get
            {
                return _oneday;
            }
            set
            {
                ResetTimeLine();
                _oneday = value;
            }
        }
        private bool _threedays = false;
        public bool ThreeDays
        {
            get
            {
                return _threedays;
            }
            set
            {
                ResetTimeLine();
                _threedays = value;
            }
        }
        private bool _week = false;
        public bool Week
        {
            get
            {
                return _week;
            }
            set
            {
                ResetTimeLine();
                _week = value;
            }
        }
        private bool _month = false;
        public bool Month
        {
            get
            {
                return _month;
            }
            set
            {
                ResetTimeLine();
                _month = value;
            }
        }
        private bool _year = false;
        public bool Year
        {
            get
            {
                return _year;
            }
            set
            {
                ResetTimeLine();
                _year = value;
            }
        }
        private bool _years = false;
        public bool Years
        {
            get
            {
                return (_years);
            }
            set
            {
                ResetTimeLine();
                _years = value;
            }
        }

        private void ResetTimeLine()
        {
            OneDay = false;
            ThreeDays = false;
            Week = false;
            Month = false;
            Year = false;
            Years = false;
        }

        public TimeLine()
        {

        }
    }
}
