using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace manshin
{
    public class Networkconnect
    {
        [DllImport("wininet")]
        private static extern bool InternetGetConnectedState(out int connectionDescription, int reservedValue);

        /// <summary>
        /// 检测本机是否联网
        /// </summary>
        /// <returns></returns>
        public static bool IsConnectedInternet()
        {
            int i = 0;
            if (InternetGetConnectedState(out i, 0))
            {
                //已联网
                return true;
            }
            else
            {
                //未联网
                return false;
            }
        }
    }
}