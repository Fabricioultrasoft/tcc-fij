﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace FormInvisivel
{
    public class FileSend
    {
        public class InternetConnection
        {
            [DllImport("wininet.dll")]
            private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

            public static bool IsConnectedToInternet()
            {
                int Desc;
                return InternetGetConnectedState(out Desc, 0);
            }
        }
    }
}
