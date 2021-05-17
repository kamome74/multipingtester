using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multi_Ping_Tester
{
    public class SettingData
    {
        private int interval;
        private int timeout;
        private int payload;
        private string alarm_sound;
        private Boolean isalarm;

        public Boolean setInterval(int i)
        {
            try {
                interval = i;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean setTimeout(int i)
        {
            try
            {
                timeout = i;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean setPayload(int i)
        {
            try
            {
                payload = i;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean setSound(string path)
        {
            try
            {
                alarm_sound = path;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean setAlarm(Boolean b) {
            try {
                isalarm = b;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getInterval()
        {
            return interval;
        }

        public int getTimeout()
        {
            return timeout;
        }


        public int getPayload()
        {
            return payload;
        }


        public string getSound()
        {
            return alarm_sound;
        }

        public Boolean getAlarm()
        {
            return isalarm;
        }
    }
}
