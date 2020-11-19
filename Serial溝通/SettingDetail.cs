using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serial溝通
{
    public class SettingDetail
    {
        public int _num = 0;

        public string name="";

        public string type;

        public bool isMustBigger;
        public string mustBigger;
        public bool isMustBiggerAndDelete;

        public bool isMustSmaller;
        public string mustSmaller;
        public bool isMustSmallerAndDelete;

        public bool isWhenBigger;
        public string whenBigger;
        public string whenBiggerThenSend;

        public bool isWhenSmaller;
        public string whenSmaller;
        public string whenSmallerThenSend;

        public bool isWhenEqual;
        public string whenEqual;
        public string whenEqualThenSend;
    }
}
