﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Agente
{
    public class Internet
    {
        [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);

        // Um método que verifica se esta conectado
        public static Boolean IsConnected()
        {
            int Description;
            return InternetGetConnectedState(out Description, 0);
        }
    }
}
