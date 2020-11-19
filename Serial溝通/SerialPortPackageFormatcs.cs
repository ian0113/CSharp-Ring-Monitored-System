using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serial溝通
{
    public class SerialPortPackageFormatcs
    {
        public int _package = 0;
        public bool _isSetStartMsg = false;
        public string _startMsg = "";
        public bool _isSetEndMsg = false;
        public string _endMsg = "";
        public List<SettingDetail> _settingDetails = new List<SettingDetail>();
    }
}

